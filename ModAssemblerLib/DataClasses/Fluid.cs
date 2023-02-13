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
        public int DefaultTemperature { get; set; }
        public int MaxTemperature { get; set; }
        public Icon Icon { get; set; }

        public Fluid(ColorSpecification baseColor, ColorSpecification flowColor, int temperature, Icon icon, int maxTemperature)
        {
            BaseColor = baseColor;
            FlowColor = flowColor;
            DefaultTemperature = temperature;
            Icon = icon;
            MaxTemperature = maxTemperature;
        }

        public Fluid(string input)
        {
            string[] splittedInput = Importer.SanitizeInput(input, Constants.IMPORTFILTERS, true).Split("\n");

            for (int i = 0; i < splittedInput.Length; i++)
            {
                splittedInput[i] = splittedInput[i].Trim();
            }
            
            Name = Importer.ExtractValue(input, "name");
            Type = PrototypeDefinition.Fluid;
            Order = Importer.ExtractValue(input, "order");
            
        }

        public Fluid(){ }

        public override string ToString()
        {
            return 
                $$"""
                {
                    {{base.ToString()}},
                    {{Icon.ToString()}},
                    base_color = "{{BaseColor.ToString()}}",
                    flow_color = "{{FlowColor.ToString()}}",
                    default_temperature = "{{DefaultTemperature.ToString()}}",
                    max_temperature = "{{MaxTemperature}}",
                }
                """;
        }
    }
}
