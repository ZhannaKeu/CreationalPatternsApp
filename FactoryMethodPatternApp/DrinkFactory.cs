using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternApp
{
    public class DrinkFactory : DishFactory
    {
        public override Dish CreateDish()
        {
            return new Drink { Name = "Кола", Calories = 150, Price = 1.99m };
        }
    }
}
