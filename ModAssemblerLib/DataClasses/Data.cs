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

        public static Item GetItemByName(string name)
        {
             return Items.FirstOrDefault(x => x.Key == name).Value;
        }

        public static Fluid GetFluidByName(string name)
        {
            return Fluids.FirstOrDefault(x => x.Key == name).Value;
        }

        public static ItemGroup GetItemGroupByName(string name)
        {
            return ItemGroups.FirstOrDefault(x => x.Key == name).Value;
        }

        public static ItemSubGroup GetItemSubGroupByName(string name)
        {
            return ItemSubGroups.FirstOrDefault(x => x.Key == name).Value;
        }

        public static Technology GetTechnologyByName(string name)
        {
            return Technologies.FirstOrDefault(x => x.Key == name).Value;
        }
    }
}
