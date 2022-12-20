﻿namespace ModAssemblerLib.DataClasses
{
    public class Item : PrototypeBase
    {
        public IconSpecificaction Icon { get; set; }
        public int StackSize { get; set; } = 50;
        public ItemSubGroup SubGroup { get; set; }

        public Item(string name, IconSpecificaction icon, string order, int stackSize, ItemSubGroup subGroup)
        {
            Name = name;
            Type = PrototypeDefinition.Item;
            Order = order;
            Icon = icon;
            StackSize = stackSize;
            SubGroup = subGroup;
        }

        public override string ToString()
        {
            return $$"""
            {
            {{base.ToString()}},
            {{Icon.ToString()}},
            subgroup = "{{SubGroup.Name}}",
            place_result = {TODO},
            stack_size = {{StackSize}},
            },
            """;
        }
    }
}