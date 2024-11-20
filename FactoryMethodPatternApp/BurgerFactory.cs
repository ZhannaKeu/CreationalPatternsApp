using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternApp
{
    public class BurgerFactory : DishFactory
    {
        public override Dish CreateDish()
        {
            return new Burger { Name = "Бургер", Calories = 300, Price = 5.99m };
        }
    }
}
