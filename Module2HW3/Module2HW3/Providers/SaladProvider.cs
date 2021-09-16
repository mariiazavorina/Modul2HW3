using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class SaladProvider
    {
        private readonly Vegetables[] _salad = new Vegetables[7];
        public void AddToSalad()
        {
            _salad[0] = new CanBeEatenRaw() { Name = "Cucumber", CaloricContent = 15, ColorOfFruit = "Green", MustBePeeled = false, SummerRipeningMonth = "July" };
            _salad[1] = new CanBeEatenRaw() { Name = "Tomato", CaloricContent = 24, ColorOfFruit = "Red", MustBePeeled = false, SummerRipeningMonth = "August" };
            _salad[2] = new CantBeEatenRaw() { Name = "Eggplant", CaloricContent = 24, ColorOfFruit = "Purple", CookingMethod = "Bake", SummerRipeningMonth = "August" };
            _salad[3] = new CantBeEatenRaw() { Name = "Corn", CaloricContent = 86, ColorOfFruit = "Yellow", CookingMethod = "Boil", SummerRipeningMonth = "August" };
            _salad[4] = new Leaves() { Name = "Basil", CaloricContent = 27, ColorOfLeaves = "Purple", SummerRipeningMonth = "July" };
            _salad[5] = new Leaves() { Name = "Spinach", CaloricContent = 23, ColorOfLeaves = "Green", SummerRipeningMonth = "June" };
            _salad[6] = new AutumnSeasonal() { Name = "Pumpkin", CaloricContent = 28, AutumnRipeningMonth = "September" };
            var saladService = new SaladService();
            saladService.SortVegetables(_salad);
        }

        public Vegetables[] GetSalad()
        {
            Vegetables[] salad = _salad;
            return salad;
        }
    }
}
