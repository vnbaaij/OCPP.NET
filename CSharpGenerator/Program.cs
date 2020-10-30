using System;
using System.IO;
using System.Reflection;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

namespace CSharpGeneratorRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating C# for json schemas...");

            //var srcPath = @"C:\Source\OCPP.NET\Docs\V1.6\schemas\json";
            var srcPath = @"C:\Source\OCPP\OCPP.NET\Docs\V2.0.1\OCPP-2.0.1_part3_JSON_schemas";

            var destPath = @"C:\Source\OCPP\OCPP.NET\CSharpGenerator\classes";

            var schemaFiles = Directory.EnumerateFiles(srcPath, "*.json", SearchOption.AllDirectories);

            foreach (string currentFile in schemaFiles)
            {
                string schemaFile = currentFile[(srcPath.Length + 1)..];

                var schemaJson = File.ReadAllText(currentFile);
                var schema = JsonSchema.FromJsonAsync(schemaJson).Result;

                var settings = new CSharpGeneratorSettings
                {
                    Namespace = "OCPP.Generated",
                    GenerateDataAnnotations = false,
                };

                var generator = new CSharpGenerator(schema, settings);
                var code = generator.GenerateFile();

                string codeFile = schemaFile[0..^4] + "cs";

                File.WriteAllText(Path.Combine(destPath, codeFile), code);
                Console.WriteLine($"Converted {schemaFile} to {codeFile}");

            }


        }
    }
}
