using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                split[index] = SanitizeInput(s);

                if (split[index].StartsWith(key))
                {
                    string ss = split[index].Substring(split[index].IndexOf(key) + key.Length).Replace("=", "").Trim();
                    return ss;
                }
                index++;
            }
            return "NULL";
        }

        public static string SanitizeInput(string input)
        {
            return input.Replace("\r", string.Empty)
                        .Replace("\n", string.Empty)
                        .Replace("\t", string.Empty)
                        .Replace("\"", string.Empty)
                        .Replace("data:extend", string.Empty)
                        .Replace("(", string.Empty)
                        .Replace(")", string.Empty)
                        .Replace("{", string.Empty)
                        .Replace("}", string.Empty)
                        .Trim();
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
    }
}
