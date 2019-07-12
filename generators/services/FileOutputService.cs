using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace DevTools.Services {
    public class FileOutputService : IFileOutputService {
        private StringBuilder content;
        public FileOutputService () {
            content = new StringBuilder ();
        }
        public void AppendLine (string line) {
            content.AppendLine (line);
        }

        public void SaveToFile () {
            var date = DateTime.Now.ToString ("yyyyMMdd-HHmmss");
            if(!Directory.Exists("output")) Directory.CreateDirectory("output");
            var fileName = $"output\\output-{date}.txt";
            using (var sw = new StreamWriter (fileName)) {
                sw.WriteLine (content.ToString ());
            }
            content.Clear ();
        }
    }
}