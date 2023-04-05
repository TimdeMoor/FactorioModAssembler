using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib
{
    public static class Constants
    {
        public static string GENERATEDSTRING = $"--File last edited by modassembler at {DateTime.Now}";
        public static string DATAEXTEND = "Data:Extend({{";
        public static List<string> IMPORTFILTERS = new List<string>() {"\r","\n","\t","\"","data:extend", "{", "}", "(", ")", ":"};
    }
}
