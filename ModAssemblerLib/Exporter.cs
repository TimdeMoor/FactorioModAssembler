﻿using ModAssemblerLib.DataClasses;
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

        public static void exportItemGroups(string destinationPath)
        {
            StringBuilder sb = new();
            sb.AppendLine(Constants.GENERATEDSTRING);
            sb.AppendLine(Constants.DATAEXTEND);
            foreach (KeyValuePair<string, ItemGroup> itemGroup in Data.ItemGroups)
            {
                sb.AppendLine(itemGroup.Value.ToString());
            }
            sb.AppendLine("}})");
            FileWriter.WriteFile(destinationPath + "\\item-groups.lua", sb.ToString());
        }

        public static void exportItemSubGroups(string destinationPath)
        {
            StringBuilder sb = new();
            sb.AppendLine(Constants.GENERATEDSTRING);
            sb.AppendLine(Constants.DATAEXTEND);
            foreach (KeyValuePair<string, ItemSubGroup> itemSubGroup in Data.ItemSubGroups)
            {
                sb.AppendLine(itemSubGroup.Value.ToString());
            }
            sb.AppendLine("}})");
            FileWriter.WriteFile(destinationPath + "\\item-subgroups.lua", sb.ToString());
        }

        public static void exportFluids(string destinationPath)
        {
            StringBuilder sb = new();
            foreach (KeyValuePair<string, Fluid> fluid in Data.Fluids)
            {
                sb.Clear();
                sb.AppendLine(Constants.GENERATEDSTRING);
                sb.AppendLine(Constants.DATAEXTEND);
                sb.AppendLine(fluid.Value.ToString());
                sb.AppendLine("}})");
                FileWriter.WriteFile(destinationPath + "\\" + fluid.Value.Name.ToLower() + ".lua", sb.ToString());
            }
        }

        public static void exportItems(string destinationPath)
        {
            StringBuilder sb = new();
            foreach (KeyValuePair<string, Item> item in Data.Items)
            {
                sb.Clear();
                sb.AppendLine(Constants.GENERATEDSTRING);
                sb.AppendLine(Constants.DATAEXTEND);
                sb.AppendLine(item.Value.ToString());
                sb.AppendLine("}})");
                FileWriter.WriteFile(destinationPath + "\\" + item.Value.Name.ToLower() + ".lua", sb.ToString());
            }
        }
    }
}
