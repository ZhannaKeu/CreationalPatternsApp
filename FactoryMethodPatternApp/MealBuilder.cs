using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternApp
{
    public class MealBuilder
    {
        private Dish _burger;
        private Dish _drink;
        private Dish _side;

        public MealBuilder AddBurger(Dish burger)
        {
            _burger = burger;
            return this;
        }

        public MealBuilder AddDrink(Dish drink)
        {
            _drink = drink;
            return this;
        }

        public MealBuilder AddSide(Dish side)
        {
            _side = side;
            return this;
        }

        public Meal Build()
        {
            return new Meal(_burger, _drink, _side);
        }
    }
}
