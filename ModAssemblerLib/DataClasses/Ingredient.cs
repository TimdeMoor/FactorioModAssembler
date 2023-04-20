using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class Ingredient
    {
        public string ItemName { get; set; }
        public int ItemCount { get; set; }

        public Ingredient() { }
        public Ingredient(string itemName, int itemCount)
        {
            ItemName = itemName;
            ItemCount = itemCount;
        }

        public Ingredient(string input)
        {
            //TODO ImportString
        }

        public override string ToString()
        {
            return $$"""'{{{ItemName}}', {{ItemCount}}},""";
        }
    }
}
