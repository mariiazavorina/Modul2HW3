using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Starter
    {
        public void Run()
        {
            var saladProvider = new SaladProvider();
            saladProvider.AddToSalad();
            Vegetables[] salad = saladProvider.GetSalad();
            var saladService = new SaladService();
            var totalCaloricContent = saladService.TotalCaloricContent(salad);
            FindService find = new FindVegetableService();
            var vegetable = Console.ReadLine();
            Vegetables foundVeg = find.FindVegetable(salad, vegetable);
            Console.WriteLine($"Total caloric content is {totalCaloricContent}.");
            if (foundVeg == null)
            {
                Console.WriteLine("There is no vegetable with this name in salad.");
            }
            else
            {
                Console.WriteLine($"There is the {foundVeg.Name} in salad. Its caloric content is {foundVeg.CaloricContent}.");
            }
        }
    }
}
