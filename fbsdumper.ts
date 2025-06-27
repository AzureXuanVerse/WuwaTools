import fs from 'fs';
import { exit } from 'process';
import path from 'path';

function dumpFiles(allFiles: string[], basePath: string) {
    allFiles.forEach((file: any) => {
        if (!file.includes(".js")) {
            return;
        }
    
        const filedata = require(`${basePath}/${file}`);

        if (file == "ConfigMap.js" || file == "ConfigDefineBase.js") {
            return;
        }

        const classData = filedata[Object.keys(filedata)[0]];
    
        function toSnakeCase(str:string) {
            return str.replace(/(([a-z])(?=[A-Z][a-zA-Z])|([A-Z])(?=[A-Z][a-z]))/g,'$1_').toLowerCase()
        }
    
        function inferTypeFromMethod(method: Function): string {
            const methodString = method.toString();
    
            // Check for common patterns to infer types
            if (methodString.includes("readInt32")) {
                return "int";
            } else if (methodString.includes("readInt64")) {
                return "long";
            } else if (methodString.includes("__string(")) {
                return "string";
            } else if (methodString.includes("readFloat32")) {
                return "float";
            } else if (methodString.includes("readFloat64")) {
                return "double";
            } else if (methodString.includes("readInt8")) {
                return "bool";
            } else if (methodString.includes("||new ")) { 
                return `${methodString.split("||new ")[1].split(")")[0].split(".")[1]}`;
            } else if (methodString.includes("|| new ")) { 
                return `${methodString.split("|| new ")[1].split("(")[0].split(".")[1]}`;
            }
    
    
            console.log(`Could not infer type from method: ${methodString}`);
    
            // Default to unknown if no pattern matches
            throw "";
            return "unknown";
        }
    
        function restoreFlatBufferSchema(classObject: any): string {
            const fields: { name: string; type: string }[] = [];
    
            // Inspect the class prototype
            const prototype = classObject.prototype;
    
            // Analyze properties (getters)
            const propertyNames = Object.getOwnPropertyNames(prototype)
                .filter((prop) => {
                    const descriptor = Object.getOwnPropertyDescriptor(prototype, prop);
                    return descriptor && typeof descriptor.get === "function"; // Only getters
                });
    
            // Map property names to inferred types
            for (const prop of propertyNames) {
                const descriptor = Object.getOwnPropertyDescriptor(prototype, prop);
    
                if (descriptor && typeof descriptor.get === "function") {
                    // Parse the getter to find the method it calls
                    const getterString = descriptor.get.toString();
                    // console.log(`Getter: ${getterString}`);
                    const match = getterString.match(/return this\.(\w+)\(\)/);
    
                    if (match && match[1]) {
                        const methodName = match[1]; // e.g., "id", "montage", "malevariant"
                        const method = prototype[methodName];
    
                        if (typeof method === "function") {
                            let type = inferTypeFromMethod(method);
                            let ret = method.toString().split(":")[1];
                            if (ret && ret.includes("}") && !ret.startsWith("null;return\"string\"")) {
                                ret = ret.split("}")[0];
                                if (ret.startsWith(".")) {
                                    ret = "0" + ret;
                                }
                                ret = ret.replace("e2", "00");
                                ret = ret.replace("e3", "000");
                                ret = ret.replace("e4", "0000");
                                ret = ret.replace("e5", "00000");
                                ret = ret.replace("e6", "000000");
                                // console.log(`Ret: ${ret}`);
                                
                                if (type == "bool" && ret.includes(".")) {
                                    var enumname = ret.split(".")[1];
                                    type = `${enumname}`;
                                } else {
                                    if (ret != "0" && ret != "null" && ret != "BigInt(\"0\")") {
                                        type = `${type} = ${ret}`;
                                    }
                                }
                            }
                            fields.push({ name: prop, type });
                        }
                    } else if (getterString.includes("ConvertToArray")) {
                        const methodname = getterString.split("Length(),this.")[1].split(",this")[0];
                        const method = prototype[methodname];
    
                        if (typeof method === "function") {
                            const type = "["+inferTypeFromMethod(method)+"]";
                            fields.push({ name: prop, type });
                        } else {
                            console.log(`Could not parse ARRAY getter: ${getterString} from file ${file}`);
                            exit(1);
                        }
                    } else if (getterString.includes("ConvertToMap")) {
                        const methodname = `${descriptor.get.name.toLowerCase()}`.replace("get ", "");
                        const method = prototype[methodname];
    
                        if (typeof method === "function") {
                            let type = `${method.toString().split("||new ")[1].split(")")[0].split(".")[1]}`;
                            if (method.toString().includes("__vector")) {
                                type = `[${type}]`;
                            }
                            fields.push({ name: prop, type });
                        } else {
                            console.log(`Could not parse MAP getter: ${getterString} from file ${file}`);
                            exit(1);
                        }
                    } else {
                        console.log(`Could not parse NORMAL getter: ${getterString} from file ${file}`);
                        exit(1);
                    }
                }
            }

            if (file.startsWith("Dic") && !(file.startsWith("Dice"))) {
                const prototype = classObject.prototype;
                const method = prototype["key"];
                let type = inferTypeFromMethod(method);
                let prop = "key"
                fields.push({ name: prop, type });

                const method2 = prototype["value"];
                let type2 = inferTypeFromMethod(method2);
                let prop2 = "value"
                fields.push({ name: prop2, type: type2 });
            }
    
            // Construct the FlatBuffers schema
            const schemaLines = [`table ${classObject.name} {`];
            fields.forEach((field) => {
                schemaLines.push(`    ${toSnakeCase(field.name)}:${field.type};`);
            });
            schemaLines.push(`}\n`);
    
            return schemaLines.join('\n');
        }

        if (classData.prototype == undefined) {
            // get enum values
            const keys = Object.keys(classData);
            const values = Object.values(classData);
            console.log(`enum ${file.split(".")[0]} : int {`);
            for (let i = 0; i < keys.length; i++) {
                let key = keys[i];
                if (!isNaN(parseInt(key))) {
                    continue;
                }
                console.log(`    ${keys[i]} = ${values[i]},`);
            }
            console.log("}\n");
        } else {
            const schema = restoreFlatBufferSchema(classData);
            console.log(schema);
        }
    });
}


console.log(`// AUTOGENERATED FBS SCHEMA BY Hiro420\nnamespace WWParser.Defs;\n`);

const allSubTypeFiles = fs.readdirSync('./JavaScript/Core/Define/Config/SubType');
dumpFiles(allSubTypeFiles, './JavaScript/Core/Define/Config/SubType');

const allFiles = fs.readdirSync('./JavaScript/Core/Define/Config');
dumpFiles(allFiles, './JavaScript/Core/Define/Config');
