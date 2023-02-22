using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class ItemGroup : PrototypeBase
    {
        public Icon Icon { get; set; }

        public ItemGroup(string name, string order, Icon icon)
        {
            Name = name;
            Type = PrototypeDefinition.ItemGroup;
            Order = order;
            Icon = icon;
        }

        public ItemGroup(string input)
        {
            Name = Importer.ExtractValue(input, "name");
            Type = PrototypeDefinition.ItemGroup;
            Order = Importer.ExtractValue(input, "order");
            Icon = Importer.ExtractIcon(input);
        }

        public ItemGroup(){}

        public override string ToString()
        {
            return 
            $$"""
            {
                {{base.ToString()}},
                {{Icon.ToString()}},
                inventory_order = "{{Order}}",
            },
            """;
        }
    }
}
