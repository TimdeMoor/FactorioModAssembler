using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ModAssemblerLib.DataClasses;

namespace ModAssemblerLib
{
    public static class Importer
    {
        public static string ExtractValue(string input, string key)
        {
            string[] split = Regex.Split(input, @",");
            int index = 0;
            foreach (string s in split)
            {
                split[index] = s.Replace("\r", "")
                                .Replace("\n", "")
                                .Replace("\t", "")
                                .Replace("\"", "")
                                .Replace("data:extend", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("{", "")
                                .Replace("}", "")
                                .Trim();

                if (split[index].StartsWith(key))
                {
                    return split[index].Substring(split[index].IndexOf(key) + key.Length).Replace("=", "").Trim();
                }
                index++;
            }
            return "NULL";
        }

        public static IconSpecificaction ExtractIcon(string input)
        {
            return new IconSpecificaction()
            {
                IconPath = ExtractValue(input, "icon"),
                IconSize = (int)Convert.ToInt64(ExtractValue(input, "icon_size")),
            };
        }

        public static ItemGroup ExtractItemGroup(string input)
        {
            return new ItemGroup()
            {
                Type = PrototypeDefinition.ItemGroup,
                Order = ExtractValue(input, "order"),
                Icon = ExtractIcon(input),
                Name = ExtractValue(input, "name"),
            };
        }

        public static ItemSubGroup ExtractItemSubGroup(string input)
        {
            return new ItemSubGroup()
            {
                Name = ExtractValue(input, "name"),
                Order = ExtractValue(input, "order"),
                Type = PrototypeDefinition.ItemSubGroup,
                Group = ExtractItemGroup(input),
            };
        }
    }
}
