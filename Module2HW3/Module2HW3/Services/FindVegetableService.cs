using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class FindVegetableService : FindService
    {
        public override Vegetables FindVegetable(Vegetables[] salad, string name)
        {
            Vegetables vegetable = salad.FindVegetable(name);
            return vegetable;
        }
    }
}
