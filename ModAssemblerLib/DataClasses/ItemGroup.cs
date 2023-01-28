using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class ItemGroup : PrototypeBase
    {
        public IconSpecificaction Icon { get; set; }

        public ItemGroup(string name, string order, IconSpecificaction icon)
        {
            Name = name;
            Type = PrototypeDefinition.ItemGroup;
            Order = order;
            Icon = icon;
        }

        public ItemGroup()
        {
        }

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
