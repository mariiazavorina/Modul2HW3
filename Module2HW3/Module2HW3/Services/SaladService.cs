using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class SaladService : ISaladService
    {
        public int TotalCaloricContent(Vegetables[] salad)
        {
            var totalCaloricContent = 0;
            for (var i = 0; i < 7; i++)
            {
                totalCaloricContent += salad[i].CaloricContent;
            }

            return totalCaloricContent;
        }

        public void SortVegetables(Vegetables[] salad)
        {
            Array.Sort(salad, new VegetableComparer());
        }
    }
}
