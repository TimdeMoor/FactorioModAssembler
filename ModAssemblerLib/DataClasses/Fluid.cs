using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class Fluid : PrototypeBase
    {
        public ColorSpecification BaseColor { get; set; }
        public ColorSpecification FlowColor { get; set; }
        public int Temperature { get; set; }
        public IconSpecificaction Icon { get; set; }

        public Fluid(ColorSpecification baseColor, ColorSpecification flowColor, int temperature, IconSpecificaction icon)
        {
            BaseColor = baseColor;
            FlowColor = flowColor;
            Temperature = temperature;
            Icon = icon;
        }
    }
}
