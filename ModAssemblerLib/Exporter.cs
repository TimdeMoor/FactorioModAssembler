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
        public static void Export()
        {

        }

        private static void exportItems()
        {
            foreach(KeyValuePair<string,Item> item in Data.Items)
            {
                item.Value.ToString();
            }
        }
    }
}
