using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class VegetableComparer : IComparer<Vegetables>
    {
        public int Compare(Vegetables p1, Vegetables p2)
        {
            if (p1.CaloricContent > p2.CaloricContent)
            {
                return 1;
            }
            else if (p1.CaloricContent < p2.CaloricContent)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
