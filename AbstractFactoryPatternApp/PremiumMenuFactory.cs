using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternApp
{
    public class PremiumMenuFactory : IMenuFactory
    {
        public Burger CreateBurger() => new Burger { Name = "Премиум бургер", Calories = 400, Price = 7.99m };
        public Drink CreateDrink() => new Drink { Name = "Молочный коктейль", Calories = 300, Price = 4.99m };
        public Side CreateSide() => new Side { Name = "Круассаны", Calories = 350, Price = 3.99m };
    }
}
