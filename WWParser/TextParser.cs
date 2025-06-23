using System.Text;
using Newtonsoft.Json;
using System.Data.SQLite;
using Newtonsoft.Json.Linq;


namespace WWParser
{
    class TextParser
    {
        static List<string> langs = new List<string> { "de", "en", "es", "fr", "id", "ja", "ko", "pt", "ru", "th", "vi", "zh-Hans", "zh-Hant" };

        static Dictionary<string, object> Decode(Dictionary<string, object> db)
        {
            if (!db.ContainsKey("BinData") || db["BinData"] == null)
                return db;

            byte[] binData = Convert.FromBase64String(db["BinData"].ToString()!);
            db["BinData"] = Encoding.UTF8.GetString(binData);

            return db;
        }

        static List<string> DbGetTables(string path)
        {
            List<string> tables = new List<string>();

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={path}"))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT name FROM sqlite_master WHERE type='table';";
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tables.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return tables;
        }

        static void DbToJson(string inputPath, string tableName, string outputPath)
        {
            if (!File.Exists(inputPath))
                return;

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={inputPath}"))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM {tableName}";
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        Dictionary<string, Dictionary<string, object>> output = new Dictionary<string, Dictionary<string, object>>();
                        while (reader.Read())
                        {
                            string id = reader["Id"].ToString()!;
                            object content = reader["Content"];

                            Dictionary<string, object> contentObject = new Dictionary<string, object>
                            {
                                { "Id", reader["Id"] },
                                { "Content", content }
                            };

                            output[id] = contentObject;
                        }

                        // Converting Dictionary to JObject
                        JObject json = JObject.FromObject(output);

                        // Writing JObject to file
                        File.WriteAllText(outputPath, json.ToString());
                    }
                }
            }
        }

        public static void ParseTexts()
        {
            string path = "ConfigDB";

            foreach (string lang in langs)
            {
                foreach (string langDbPath in Directory.GetFiles(Path.Combine(path, lang), "*.db"))
                {
                    List<string> tables = DbGetTables(langDbPath);
                    foreach (string tableName in tables)
                    {
                        DbToJson(langDbPath, tableName, Path.Combine("Config", lang, $"{tableName}.json"));
                    }
                }
            }
        }
    }
}