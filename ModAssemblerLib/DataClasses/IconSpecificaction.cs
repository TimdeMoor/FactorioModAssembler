using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class IconSpecificaction
    {
        public int IconSize { get; set; } = 32;
        public string IconPath { get; set; } = string.Empty;

        public IconSpecificaction(int iconSize, string iconPath)
        {
            IconSize = iconSize;
            IconPath = iconPath;
        }

        public IconSpecificaction()
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
