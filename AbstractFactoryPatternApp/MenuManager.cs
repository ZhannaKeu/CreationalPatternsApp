using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternApp
{
    public class MenuManager
    {
        private readonly IMenuFactory _menuFactory;

        public MenuManager(IMenuFactory menuFactory)
        {
            _menuFactory = menuFactory;
        }

        public List<Dish> GenerateMenu()
        {
            return new List<Dish>
            {
                _menuFactory.CreateBurger(),
                _menuFactory.CreateDrink(),
                _menuFactory.CreateSide()
            };
        }
    }
}
