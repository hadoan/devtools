using System;
using System.Collections.Generic;

namespace DevTools.Services {
    public class Command {
        private string _type;
        private string _command;
        public CommandType Type { get; set; }
        public CommandSubType SubType { get; set; }

        public dynamic CommandParams { get; set; }

        public string type {
            get { return _type; }
            set {
                _type = value;
                if (value == "generate") Type = CommandType.Generate;
            }
        }
        public string command {
            get { return _command; }
            set {
                _command = value;
                if (value == "props") SubType = CommandSubType.GenerateProps;
            }
        }
        public List<DataItem> data { get; set; }

    }

    public class DataItem {
        public string property { get; set; }
        public string type { get; set; }
    }

}