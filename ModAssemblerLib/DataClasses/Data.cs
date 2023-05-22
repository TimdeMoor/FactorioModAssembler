using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public static class Data
    {
        public static Dictionary<string, Icon> Icons = new();
        public static Dictionary<string, Item> Items = new();
        public static Dictionary<string, Fluid> Fluids = new();
        public static Dictionary<string, ItemGroup> ItemGroups = new();
        public static Dictionary<string, ItemSubGroup> ItemSubGroups = new();
        public static Dictionary<string, Technology> Technologies = new();
        public static Dictionary<string, RecipeCategory> RecipeCategories = new();

        public static Item GetItemByName(string name)
        {
             return Items.FirstOrDefault(x => x.Key == name).Value;
        }

        public static bool Add(Item item)
        {
            if (!Items.ContainsKey(item.Name))
            {
                Items.Add(item.Name, item);
                return true;
            }
            return false;
        }

        public static Fluid GetFluidByName(string name)
        {
            return Fluids.FirstOrDefault(x => x.Key == name).Value;
        }

        public static bool Add(Fluid fluid)
        {
            if (!Fluids.ContainsKey(fluid.Name))
            {
                Fluids.Add(fluid.Name, fluid);
                return true;
            }
            return false;
        }


        public static ItemGroup GetItemGroupByName(string name)
        {
            return ItemGroups.FirstOrDefault(x => x.Key == name).Value;
        }

        public static bool Add(ItemGroup itemGroup) 
        {
            if (!ItemGroups.ContainsKey(itemGroup.Name))
            {
                ItemGroups.Add(itemGroup.Name, itemGroup);
                return true;
            }
            return false;
        }

        public static ItemSubGroup GetItemSubGroupByName(string name)
        {
            return ItemSubGroups.FirstOrDefault(x => x.Key == name).Value;
        }

        public static bool Add(ItemSubGroup itemSubGroup)
        {
            if (!ItemSubGroups.ContainsKey(itemSubGroup.Name))
            {
                ItemSubGroups.Add(itemSubGroup.Name, itemSubGroup);
                return true;
            }
            return false;
        }

        public static Technology GetTechnologyByName(string name)
        {
            return Technologies.FirstOrDefault(x => x.Key == name).Value;
        }

        public static bool Add(Technology technology)
        {
            if (!Technologies.ContainsKey(technology.Name))
            {
                Technologies.Add(technology.Name, technology);
                return true;
            }
            return false;
        }

        public static RecipeCategory GetRecipeCategoryByName(string name)
        {
            return RecipeCategories.FirstOrDefault(x => x.Key == name).Value;
        }

        public static bool Add(RecipeCategory recipeCategory)
        {
            if (!RecipeCategories.ContainsKey(recipeCategory.Name))
            {
                RecipeCategories.Add(recipeCategory.Name, recipeCategory);
                return true;
            }
            return false;
        }
    }
}
