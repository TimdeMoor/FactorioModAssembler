using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public class IngredientList
    {
        private List<Ingredient> List = new List<Ingredient>();

        public IngredientList()
        { 
            List = new();
        }

        public bool Add(Ingredient i)
        {
            if (!List.Contains(i))
            {
                List.Add(i);
                return true;
            }
            return false;
        }

        public bool Remove(Ingredient i)
        {
            if (List.Contains(i))
            {
                List.Remove(i);
                return true;
            }
            return false;
        }
    }
}
