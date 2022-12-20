using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class ColorSpecification
    {
        public int r = 0;
        public int g = 0;
        public int b = 0;
        public int a = 0;

        public ColorSpecification() { }
        public ColorSpecification(int r, int g, int b, int a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public override string ToString()
        {
            return
            $$"""
            {{{r}},{{g}},{{b}},{{a}}}
            """;
        }
    }
}
