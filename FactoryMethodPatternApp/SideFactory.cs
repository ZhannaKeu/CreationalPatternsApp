using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternApp
{
    public class SideFactory : DishFactory
    {
        public override Dish CreateDish()
        {
            return new Side { Name = "Картофель фри", Calories = 200, Price = 2.49m };
        }
    }
}
