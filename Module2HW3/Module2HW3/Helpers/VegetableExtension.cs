using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public static class VegetableExtension
    {
        public static Vegetables FindVegetable(this Vegetables[] salad, string name)
        {
            Vegetables vegetable = null;
            for (var i = 0; i < salad.Length; i++)
            {
                if (salad[i].Name == name)
                {
                    vegetable = salad[i];
                    break;
                }
                else
                {
                    i++;
                }
            }

            return vegetable;
        }
    }
}
