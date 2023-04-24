using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class Technology : PrototypeBase
    {
        public Icon Icon { get; set; }
        public TechnologyIngredient TechnologyIngredient { get; set; }
        public List<TechnologyEffect> Effects { get; set; }
        public List<Technology>? Prerequisites { get; set; }

        public override string ToString()
        {
            return
            $$"""
            {
            type = "{{Type}}",
            name = "{{Name}}",
            {{Icon.ToString()}},
            effects = {{{Effects.ToString()}}},
            unit = {{TechnologyIngredient.ToString()}},
            },
            """;
        }
        private string GetEffectsString()
        {
            StringBuilder sb = new();
            foreach (var effect in Effects)
            {
                sb.AppendLine(effect.ToString());
            }
            return sb.ToString();
        }
    }

    public class TechnologyIngredient
    {
        public IngredientList IngredientList { get; set; }
        public int Time { get; set; }
    }

    public class TechnologyEffect
    {
        public string Name { get; set; }
        public string ModifierPrototype { get; set; }

        public TechnologyEffect()
        {
        }

        public override string ToString()
        {
            return
            $$"""
            {
            type = "{{ModifierPrototype}}",
            recipe = 
            }
            """;
        }
    }
}
