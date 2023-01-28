using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public static class Data
    {
        public static Dictionary<string, IconSpecificaction> Icons = new();
        public static Dictionary<string, Item> Items = new();
        public static Dictionary<string, Fluid> Fluids = new();
        public static Dictionary<string, ItemGroup> ItemGroups = new();
        public static Dictionary<string, ItemSubGroup> ItemSubGroups = new();   
        public static Dictionary<string, Technology> Technologies = new();
    }
}
