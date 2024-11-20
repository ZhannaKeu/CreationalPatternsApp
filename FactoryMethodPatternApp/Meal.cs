using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternApp
{
    public class Meal
    {
        public Dish Burger { get; }
        public Dish Drink { get; }
        public Dish Side { get; }

        public Meal(Dish burger, Dish drink, Dish side)
        {
            Burger = burger;
            Drink = drink;
            Side = side;
        }

        public decimal GetTotalPrice()
        {
            return (Burger?.Price ?? 0) + (Drink?.Price ?? 0) + (Side?.Price ?? 0);
        }

        public int GetTotalCalories()
        {
            return (Burger?.Calories ?? 0) + (Drink?.Calories ?? 0) + (Side?.Calories ?? 0);
        }

        public override string ToString()
        {
            return $"Комплексный обед:\n" +
                   $"- {Burger}\n" +
                   $"- {Drink}\n" +
                   $"- {Side}\n" +
                   $"Итого: {GetTotalCalories()} калорий, {GetTotalPrice():C}";
        }
    }
}
