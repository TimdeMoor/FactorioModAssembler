using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib
{
    public static class Constants
    {
        public static List<string> IMPORTFILTERS = new List<string>() {"\r","\n","\t","\"","data:extend", "{", "}", "(", ")", ":"};
    }
}
