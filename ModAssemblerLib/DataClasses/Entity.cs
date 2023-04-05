using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class Entity : PrototypeBase
    {
        public Icon icon { get; set; }
        public string fastReplaceableGroup { get; set; }


        public Entity()
        {
        }
    }
}
