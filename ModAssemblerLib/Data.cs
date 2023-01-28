using ModAssemblerLib.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib
{
    public static class Data
    {
        public static List<IconSpecificaction> Icons = new();
        public static List<Item> Items = new();
        public static List<Fluid> Fluids = new();
        public static List<ItemGroup> ItemGroups = new();
        public static List<ItemSubGroup> ItemSubGroups = new();
        public static List<Technology> Technologies = new();
    
        public static void Clear()
        {
            Icons.Clear();
            Items.Clear();
            Fluids.Clear();
            ItemGroups.Clear();
            ItemSubGroups.Clear();
            Technologies.Clear();
        }
    }
}
