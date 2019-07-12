using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DevTools.Services {
    public class FileInputHandlerService : BaseHandlerService, IFileInputCommandHandlerService {
        private string fileName;

        public FileInputHandlerService(IFileOutputService fileOutputService) : base(fileOutputService)
        {
        }

        public void Handle (string fileName) {
            if (!System.IO.File.Exists (fileName)) {
                Console.WriteLine ($"{fileName} couldn't be found at {AppContext.BaseDirectory}.");
                return;
            }

            try {
                var inputText = System.IO.File.ReadAllText (fileName);
                var command = JsonConvert.DeserializeObject<Command>(inputText);

                ProcessCommand(command);
            } catch (Exception ex) {
                Console.WriteLine ($"Error: {ex.Message}");
                Help ();
                Console.WriteLine ($"Error Detail: {ex}");
            }
        }

        public void SetFileName (string fileName) {
            this.fileName = fileName;
        }
    }
}