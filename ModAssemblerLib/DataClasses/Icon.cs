using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class Icon
    {
        public int IconSize { get; set; } = 32;
        public string LocalPath { get; set; } = string.Empty;

        public Icon(int iconSize, string iconPath)
        {
            IconSize = iconSize;
            LocalPath = iconPath;
        }

        public Icon()
        {
        }

        public override string ToString()
        {
            return 
            $$"""
            icon = "{{LocalPath}}",
                icon_size = "{{IconSize}}"
            """;
        }
    }
}
