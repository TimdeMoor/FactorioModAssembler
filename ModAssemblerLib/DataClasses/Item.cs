namespace ModAssemblerLib.DataClasses
{
    public class Item : PrototypeBase
    {
        public Icon Icon { get; set; }
        public int StackSize { get; set; } = 50;
        public ItemSubGroup ItemSubGroup { get; set; }

        public Item(string name, Icon icon, string order, int stackSize, ItemSubGroup subGroup)
        {
            Name = name;
            Type = PrototypeDefinition.Item;
            Order = order;
            Icon = icon;
            StackSize = stackSize;
            ItemSubGroup = subGroup;
        }

        public Item(string input)
        {
            Name = Importer.ExtractValue(input, "name");
            Type = PrototypeDefinition.Item;
            Order = Importer.ExtractValue(input, "order");
            //Icon = Data.Icons.FirstOrDefault(x => x.Key == )
            StackSize = int.Parse(Importer.ExtractValue(input, "stack_size"));
            ItemSubGroup = Data.GetItemSubGroupByName(Importer.ExtractValue(input, "name"));
        }

        public Item() { }

        public override string ToString()
        {
            return $$"""
            {
            {{base.ToString()}},
            {{Icon.ToString()}},
            subgroup = "{{ItemSubGroup.Name}}",
            place_result = {TODO},
            stack_size = {{StackSize}},
            },
            """;
        }
    }
}