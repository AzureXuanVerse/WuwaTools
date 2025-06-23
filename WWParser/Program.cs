using Google.FlatBuffers;
using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Microsoft.VisualBasic.FileIO;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Data.Entity;
using System.Reflection;

namespace WWParser
{
    class Program
    {
        static void Main()
        {
            System.IO.Directory.CreateDirectory("Config");
            DumpTablesForConfigDb("./ConfigDB/aki_base.csv");
            TextParser.ParseTexts();
        }

        public static void DumpTablesForConfigDb(string filePath)
        {
            Dictionary<string, List<string>> configDbTableMapping = new Dictionary<string, List<string>>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.SetDelimiters(",");
                parser.HasFieldsEnclosedInQuotes = true;

                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields()!;
                    string tableName = fields[0]!;
                    string configDb = fields[1];

                    if (!string.IsNullOrEmpty(configDb))
                    {
                        if (!configDbTableMapping.ContainsKey(configDb))
                        {
                            configDbTableMapping[configDb] = new List<string>();
                        }
                        configDbTableMapping[configDb].Add(tableName);
                    }
                }
            }

            foreach (var kvp in configDbTableMapping)
            {
                foreach (string tableName in kvp.Value)
                {
                    string dbname = $"{kvp.Key}".Replace(".db", "");
                    if (tableName == "CommonParam")
                    {
                        continue;
                    }
                    // Console.WriteLine($"Dumping {tableName} from {dbname}...");
                    if (File.Exists($"./ConfigDB/{dbname}.db"))
                    {
                        try {
                            Dump(dbname, tableName);
                        } catch (Exception) {
                            // Console.WriteLine($"Failed to dump {tableName}");
                        }
                    }
                }
            }
        }

        public static DataTable ReadAkiBaseCsvFile(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.SetDelimiters(",");
                parser.HasFieldsEnclosedInQuotes = true;

                string[] headers = parser.ReadFields()!;
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields()!;
                    DataRow row = dataTable.NewRow();

                    for (int i = 0; i < fields.Length; i++)
                    {
                        row[i] = fields[i];
                    }

                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }

        public static string? GetJsonKey(string tableName, SqliteConnection database)
        {
            var command = new SqliteCommand($"SELECT * FROM {tableName}", database);
            var reader = command.ExecuteReader();

            // Get the schema table
            var schemaTable = reader.GetSchemaTable();

            if (schemaTable != null && schemaTable.Rows.Count >= 2)
            {
                string? secondColumnName = null;
                // Get the name of the second column
                if (schemaTable.Rows[0]["ColumnName"].ToString() == "BinData")
                {
                    secondColumnName = schemaTable.Rows[1]["ColumnName"].ToString()!;
                }
                else
                {
                    secondColumnName = schemaTable.Rows[0]["ColumnName"].ToString()!;
                }
                // Console.WriteLine($"The name of the second column is: {secondColumnName} ---- {tableName}");
                return secondColumnName;
            }
            else
            {
                return null;
            }

        }

        public static void Dump(string Filename, string prop)
        {
            // Console.WriteLine($"Dumping {prop} to JSON...");
            using (var database = new SqliteConnection($"Filename=./ConfigDB/{Filename}.db"))
            {
                database.Open();

                var command = new SqliteCommand($"SELECT BinData FROM {prop.ToLower()}", database);
                var reader = command.ExecuteReader();

                // string? JsonKey = GetJsonKey(prop.ToLower(), database);

                var result = new List<object>();

                while (reader.Read())
                {
                    byte[] binData = (byte[])reader["BinData"];
                    string typeName = $"WWParser.Defs.{prop}";
                    Type type = Type.GetType(typeName) ?? throw new Exception($"Type {typeName} not found.");
                    MethodInfo method = type.GetMethod($"GetRootAs{prop}", new[] { typeof(ByteBuffer) }) ?? throw new Exception($"Method GetRootAs{prop} not found.");
                    var data = method.Invoke(null, new object[] { new ByteBuffer(binData) }) ?? throw new Exception($"Data not found.");
                    MethodInfo unPackMethod = data.GetType().GetMethod("UnPack") ?? throw new Exception($"UnPack method not found for type {typeName}.");
                    result.Add(unPackMethod.Invoke(data, null)!);
                }


                string jsondata = SerializeWithoutByteBuffer(result);
                string json = ProcessJsonData(jsondata).Replace("\\u", @"\u");

                var serialized = Regex.Replace(json, @"\\u(?<Value>[a-fA-F0-9]{4})", m =>
                {
                    var hex = m.Groups["Value"].Value;
                    var intValue = Convert.ToInt32(hex, 16);
                    return char.ConvertFromUtf32(intValue);
                });

                // if (JsonKey != null)
                // {
                //     File.WriteAllText($"./Config/{prop}.json", MakeKeyValue(serialized, JsonKey));
                // }
                // else
                // {
                    File.WriteAllText($"./Config/{prop}.json", serialized);
                // }
            }
        }

        public static string MakeKeyValue(string json, string key)
        {
            // Parse the JSON array
            JArray jsonArray = JArray.Parse(json);

            // Create a new JObject to store key-value pairs
            JObject keyValueJson = new JObject();

            // Iterate over each object in the array
            foreach (JObject obj in jsonArray)
            {
                // Extract the value of the specified key
                JToken keyValue = obj[key]!;

                // If the key exists, add it to the new JObject
                if (keyValue != null)
                {
                    keyValueJson[keyValue.ToString()] = obj;
                }
            }

            // Convert the JObject to string and return
            return keyValueJson.ToString();
        }

        static string ProcessJsonData(string jsonData)
        {
            JArray jsonArray = JArray.Parse(jsonData);
            foreach (JObject jsonObj in jsonArray)
            {
                foreach (JProperty property in jsonObj.Properties())
                {
                    if (property.Value.Type == JTokenType.String &&
                        property.Value.ToString().StartsWith("{") &&
                        property.Value.ToString().EndsWith("}"))
                    {
                        try
                        {
                            property.Value = JObject.Parse(property.Value.ToString());
                        }
                        catch (JsonReaderException) { }
                    }

                    if (property.Value.Type == JTokenType.String &&
                        property.Value.ToString().StartsWith("[{") &&
                        property.Value.ToString().EndsWith("}]"))
                    {
                        try
                        {
                            property.Value = JArray.Parse(property.Value.ToString());
                        }
                        catch (JsonReaderException) { }
                    }
                }
            }

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                StringEscapeHandling = StringEscapeHandling.EscapeNonAscii
            };

            return JsonConvert.SerializeObject(jsonArray, Formatting.Indented, settings);
        }

        static string SerializeWithoutByteBuffer<T>(T obj)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                ContractResolver = new CamelCaseKeyContractResolver(),
                StringEscapeHandling = StringEscapeHandling.EscapeNonAscii
            };
           
            return JsonConvert.SerializeObject(obj, settings);
        }

        public class CamelCaseKeyContractResolver : DefaultContractResolver
        {
            protected override string ResolvePropertyName(string propertyName)
            {
                return Camelize(propertyName);
            }

            private string Camelize(string input)
            {
                if (string.IsNullOrEmpty(input))
                    return input;

                var words = input.Split(new[] { ' ', '_' }, StringSplitOptions.RemoveEmptyEntries);

                var camelizedWords = words.Select((word, index) =>
                    index == 0 ? word.ToLowerInvariant() : char.ToUpperInvariant(word[0]) + word.Substring(1).ToLowerInvariant());

                var result = string.Join("", camelizedWords);
                return result.First().ToString().ToUpper() + result.Substring(1);
            }
        }
    }
}
