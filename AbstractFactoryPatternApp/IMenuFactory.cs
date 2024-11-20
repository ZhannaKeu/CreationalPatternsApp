using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternApp
{
    public interface IMenuFactory
    {
        Burger CreateBurger();
        Drink CreateDrink();
        Side CreateSide();
    }
}
