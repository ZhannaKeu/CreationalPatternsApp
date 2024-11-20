using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternApp
{
    public class VegetarianMenuFactory : IMenuFactory
    {
        public Burger CreateBurger() => new Burger { Name = "Вегетарианский бургер", Calories = 250, Price = 4.99m };
        public Drink CreateDrink() => new Drink { Name = "Смузи", Calories = 150, Price = 3.49m };
        public Side CreateSide() => new Side { Name = "Салат", Calories = 100, Price = 2.99m };
    }
}
