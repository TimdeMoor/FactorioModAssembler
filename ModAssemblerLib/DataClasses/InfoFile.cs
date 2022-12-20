using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class InfoFile
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string FactorioVersion { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Contact { get; set; }
        public string Homepage { get; set; }
        public List<InfoFileDependency> Dependencies { get; set; }
        public string Description { get; set; }

        public InfoFile() { }

        public InfoFile(string name, string version, string factorioVersion, string title, string author, string contact, string homepage, List<InfoFileDependency> dependencies, string description)
        {
            Name = name;
            Version = version;
            FactorioVersion = factorioVersion;
            Title = title;
            Author = author;
            Contact = contact;
            Homepage = homepage;
            Dependencies = dependencies;
            Description = description;
        }

        private string DependencyListToString()
        {
            StringBuilder sb = new();
            foreach (var d in Dependencies)
            {
                sb.Append("\t" + d.ToString() + "\n");
            }
            string temp = sb.ToString();
            return temp.Substring(0, temp.Length - 1);
        }

        public override string ToString()
        {
            return $$"""
            {
                "name": "{{Name}}",
                "version": "{{Version}}",
                "factorio_version": "{{FactorioVersion}}",
                "title": "{{Title}}",
                "author": "{{Author}}",
                "contact": "{{Contact}}",
                "homepage": "{{Homepage}}",
                "dependencies": [
                {{DependencyListToString()}}
                ]
                "description": "{{Description}}"
            }
            """;
        }
    }

    public class InfoFileDependency
    {
        string ModName { get; set; }
        string ModVersion { get; set; }

        public InfoFileDependency(string modName, string modVersion)
        {
            ModName = modName;
            ModVersion = modVersion;
        }


        public override string ToString()
        {
            return $$""" "{{ModName}} >= {{ModVersion}}" """;
        }
    }
}
