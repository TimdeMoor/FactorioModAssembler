using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class ColorSpecification
    {
        public float r = 0;
        public float g = 0;
        public float b = 0;
        public float a = 0;

        public ColorSpecification() { }
        public ColorSpecification(float r, float g, float b, float a)
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
            {r={{r}}, g={{g}}, b={{b}}, a={{a}}}
            """;
        }
    }
}
