using ModAssemblerLib.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib
{
    public static class Exporter
    {
        public static void ExportAll()
        {
            
        }

        public static void exportItems(string destinationPath)
        {
            foreach(KeyValuePair<string,Item> item in Data.Items)
            {
                FileWriter.WriteFile(destinationPath, item.Value.ToString());
            }
        }

        public static void exportItemGroups(string destinationPath)
        {
            foreach(KeyValuePair<string, ItemGroup> itemGroup in Data.ItemGroups)
            {
                FileWriter.WriteFile(destinationPath + itemGroup.Value.Name + ".lua", itemGroup.Value.ToString());
            }
        }

        public static void exportItemSubGroup(string destinationPath)
        {
            foreach(KeyValuePair<string, ItemSubGroup> itemSubGroup in Data.ItemSubGroups)
            {
                FileWriter.WriteFile(destinationPath, itemSubGroup.Value.ToString());
            }
        }
    }
}
