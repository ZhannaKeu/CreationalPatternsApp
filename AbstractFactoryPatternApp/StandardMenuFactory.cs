using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternApp
{
    public class StandardMenuFactory : IMenuFactory
    {
        public Burger CreateBurger() => new Burger { Name = "Классический бургер", Calories = 300, Price = 5.99m };
        public Drink CreateDrink() => new Drink { Name = "Кола", Calories = 150, Price = 1.99m };
        public Side CreateSide() => new Side { Name = "Картофель фри", Calories = 200, Price = 2.49m };
    }
}
