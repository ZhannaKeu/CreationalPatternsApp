//Описание задачи:
//Создайте иерархию блюд (бургеры, напитки, гарниры) с параметрами (калорийность, цена, размер порции). Реализуйте меню ресторана, используя Factory Method для создания блюд разных категорий и Builder для формирования комплексных обедов.
//Задачи:
//Factory Method:
//Создайте фабрики для различных категорий блюд:
//BurgerFactory для бургеров.
//DrinkFactory для напитков.
//SideFactory для гарниров.
//Builder:
//Реализуйте построение комплексного обеда, включающего бургер, напиток и гарнир, с расчетом общей цены и калорийности.
//Добавьте методы для настройки комплексного обеда, например, выбор напитка и добавление дополнительных ингредиентов в бургер.
//Добавьте:
//Возможность сортировки блюд по цене.
//Поиск блюд, соответствующих заданному диапазону калорийности и цены.


using FactoryMethodPatternApp;

var burgerFactory = new BurgerFactory();
var drinkFactory = new DrinkFactory();
var sideFactory = new SideFactory();

// Создание блюд
var burger = burgerFactory.CreateDish();
var drink = drinkFactory.CreateDish();
var side = sideFactory.CreateDish();

// Построение комплексного обеда
var builder = new MealBuilder();
var meal = builder.AddBurger(burger)
                  .AddDrink(drink)
                  .AddSide(side)
                  .Build();

// Вывод комплексного обеда
Console.WriteLine(meal);

// Сортировка блюд по цене
Console.WriteLine("\nМеню, отсортированное по цене:");
var menu = new List<Dish> { burger, drink, side };
menu.Sort(); // Сортировка через IComparable
foreach (var dish in menu)
{
    Console.WriteLine(dish);
}

// Поиск блюд по калорийности
Console.WriteLine("\nБлюда с калорийностью от 150 до 300:");
var foundDishes = FindDishesByCalories(menu, 150, 300);
foreach (var dish in foundDishes)
{
    Console.WriteLine(dish);
}

static List<Dish> FindDishesByCalories(List<Dish> menu, int minCalories, int maxCalories)
{
    var result = new List<Dish>();
    foreach (var dish in menu)
    {
        if (dish.Calories >= minCalories && dish.Calories <= maxCalories)
        {
            result.Add(dish);
        }
    }
    return result;
}