using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.Enums
{
    public static class FileDefination
    {
        public enum File
        {
            InfoFile, Changelog, Credits, Readme, Data, DataUpdates
        }

        public static readonly Dictionary<File, string> Files = new()
        {
            {File.InfoFile, ""},
            {File.Changelog, ""},
            {File.Credits, ""},
            {File.Readme, ""},
            {File.Data, ""},
            {File.DataUpdates, ""},
        };
    }
}
