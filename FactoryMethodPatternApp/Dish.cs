using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternApp
{
    public abstract class Dish : IComparable<Dish>
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Calories} калорий, Цена: {Price:C}";
        }

        public int CompareTo(Dish other)
        {
            if (other == null) return 1;
            return Price.CompareTo(other.Price);
        }
    }
}
