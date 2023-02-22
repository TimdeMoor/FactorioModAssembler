using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class ItemSubGroup : PrototypeBase
    {
        public ItemGroup Group { get; set; }

        public ItemSubGroup(string name, string order, ItemGroup subGroup)
        {
            Name = name;
            Order = order;
            Type = PrototypeDefinition.ItemSubGroup;
            Group = subGroup;
        }

        public ItemSubGroup(){}

        public override string ToString()
        {
            return 
            $$"""
            {
                {{base.ToString()}},
                group = "{{Group.Name}}",
            },
            """;
        }
    }
}
