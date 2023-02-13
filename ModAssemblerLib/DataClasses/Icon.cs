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
        public string IconPath { get; set; } = string.Empty;

        public Icon(int iconSize, string iconPath)
        {
            IconSize = iconSize;
            IconPath = iconPath;
        }

        public Icon()
        {
        }

        public override string ToString()
        {
            return 
            $$"""
            icon = "{{IconPath}}",
                icon_size = "{{IconSize}}"
            """;
        }
    }
}
