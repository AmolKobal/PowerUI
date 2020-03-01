using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerUI
{
    class Command
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Version { get; set; }

        public Command()
        { }

        public Command(string name, string type, string source, string version)
        {
            Name = name;
            Type = type;
            Source = source;
            Version = version;
        }
    }

    struct CommandInfo
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Version { get; set; }
    }
}
