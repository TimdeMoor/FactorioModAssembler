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
                split[index] = SanitizeInput(s, Constants.IMPORTFILTERS);

                if (split[index].StartsWith(key))
                {
                    return split[index].Substring(split[index].IndexOf(key) + key.Length).Replace("=", "").Trim();
                }
                index++;
            }
            return "NULL";
        }

        public static Icon ExtractIcon(string input)
        {
            return new Icon()
            {
                LocalPath = ExtractValue(input, "icon"),
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

        public static string SanitizeInput(string input, List<string> filters, bool trim = true)
        {
            string tempInput = input;
            foreach(string filter in filters)
            {
                tempInput = tempInput.Replace(filter, string.Empty);

                if (trim)
                {
                    tempInput = tempInput.Trim();
                }
            }
            return tempInput;
        }

        public static string[] ExtractArray(string input, string key)
        {
            List<string> output = new List<string>();

            string value = ExtractValueBetweenCharacters(input, "[", "]");
            string[] split = value.Split("\t");
            
            foreach (string s in split)
            {
                string temp = SanitizeInput(s, Constants.IMPORTFILTERS, true);
                if(temp != "")
                {
                    output.Add(temp);
                }
            }
            
            return output.ToArray();
        }

        public static string ExtractValueBetweenCharacters(string input, string startChar, string endChar)
        {
            string[] split = input.Split(startChar[0]);
            string[] split2 = split[1].Split(endChar[0]);
            return split2[0];
        }
    }
}
