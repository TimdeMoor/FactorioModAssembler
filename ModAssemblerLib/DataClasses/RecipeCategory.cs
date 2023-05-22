using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class RecipeCategory
    {
        public string Name { get; set; }

        public RecipeCategory(string name)
        {
            Name = name;
        }

        public RecipeCategory(string input, bool import)
        {
            Name = Importer.ExtractValue(input, "name");
        }

        public RecipeCategory() { }

        public override string ToString()
        {
            return
                $$"""
                {
                    type = recipe-category,
                    name = {{Name}}
                },
                """;
        }
    }
}
