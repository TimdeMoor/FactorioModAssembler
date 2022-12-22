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
        static string ExtractValue(string input, string key)
        {
            string[] split = Regex.Split(input, @",");
            int index = 0;
            foreach (string s in split)
            {
                split[index] = s.Replace("\r", "")
                                .Replace("\n", "")
                                .Replace("\"", "")
                                .Replace("data:extend", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("{", "")
                                .Replace("}", "")
                                .Trim();

                if (split[index].StartsWith(key))
                {
                    string ss = split[index].Substring(split[index].IndexOf(key) + key.Length).Replace("=", "").Trim();
                    return ss;
                }
                index++;
            }
            return "NULL";
        }
    }
}
