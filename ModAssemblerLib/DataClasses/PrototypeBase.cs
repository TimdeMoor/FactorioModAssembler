using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class PrototypeBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Order { get; set; } = "a";


        public override string ToString()
        {
            return
            $$"""
            name = "{{Name}}",
            type = "{{Type}}",
            order = "{{Order}}"
            """;
        }
    }
}
