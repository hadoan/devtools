using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.RepresentationModel;

namespace DevTools.Services
{
    public class FileInputHandlerService : BaseHandlerService, IFileInputCommandHandlerService
    {
        private string fileName;

        public void Handle(string fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Console.WriteLine($"{fileName} couldn't be found at {AppContext.BaseDirectory}.");
                return;
            }


            try
            {
                var yamlText = System.IO.File.ReadAllText(fileName);
                // Console.WriteLine($"Yaml text:");
                // Console.WriteLine(yamlText);
                 // Setup the input
                var input = new StringReader(yamlText);

                // Load the stream
                var yaml = new YamlStream();
                yaml.Load(input);

                 // Examine the stream
                var mapping =
                    (YamlMappingNode)yaml.Documents[0].RootNode;

                var dict = new Dictionary<string,YamlNode>();
                foreach (var entry in mapping.Children)
                {
                    Console.WriteLine($"Key: {entry.Key} Value: {entry.Value}");
                    dict.Add(entry.Key.ToString(),entry.Value);
                }

                        

                // foreach (var command in lines)
                // {
                //     ProcessCommand(command);
                // }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Help();
                Console.WriteLine($"Error Detail: {ex}");
            }
        }

        public void SetFileName(string fileName)
        {
            this.fileName = fileName;
        }
    }
}