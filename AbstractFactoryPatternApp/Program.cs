//Задача: Ресторан быстрого питания(Абстрактная фабрика)

//Описание задачи:
//Реализуйте систему для управления меню ресторана быстрого питания. Используйте паттерн Abstract Factory для создания блюд из разных категорий (бургеры, напитки, гарниры) в зависимости от типа меню (вегетарианское, стандартное, премиум).

//Задачи:

//    Создайте абстрактную фабрику IMenuFactory для производства блюд, включая методы:
//        CreateBurger() – создает бургер.
//        CreateDrink() – создает напиток.
//        CreateSide() – создает гарнир.

//    Реализуйте конкретные фабрики:
//        VegetarianMenuFactory для вегетарианского меню.
//        StandardMenuFactory для стандартного меню.
//        PremiumMenuFactory для премиального меню.

//    Создайте класс для управления меню, позволяющий:
//        Генерировать набор блюд, используя выбранную фабрику.
//        Выводить состав меню с подсчетом общей калорийности и стоимости.
//        Сортировать блюда по цене.
//        Искать блюда по калорийности.

// Выбор фабрики
using AbstractFactoryPatternApp;

Console.WriteLine("Выберите тип меню: 1 - Вегетарианское, 2 - Стандартное, 3 - Премиум");
int choice = int.Parse(Console.ReadLine() ?? "1");

IMenuFactory menuFactory;

if (choice == 1)
{
    menuFactory = new VegetarianMenuFactory();
}
else if (choice == 2)
{
    menuFactory = new StandardMenuFactory();
}
else if (choice == 3)
{
    menuFactory = new PremiumMenuFactory();
}
else
{
    menuFactory = new StandardMenuFactory(); // Значение по умолчанию
}

// Создание меню
var menuManager = new MenuManager(menuFactory);
var menu = menuManager.GenerateMenu();

// Вывод меню
Console.WriteLine("\nМеню ресторана:");
foreach (var dish in menu)
{
    Console.WriteLine(dish);
}

// Сортировка блюд по цене
Console.WriteLine("\nМеню, отсортированное по цене:");
for (int i = 0; i < menu.Count - 1; i++)
{
    for (int j = i + 1; j < menu.Count; j++)
    {
        if (menu[i].Price > menu[j].Price)
        {
            var temp = menu[i];
            menu[i] = menu[j];
            menu[j] = temp;
        }
    }
}

foreach (var dish in menu)
{
    Console.WriteLine(dish);
}

// Поиск блюд по калорийности
Console.WriteLine("\nБлюда с калорийностью от 150 до 300:");
List<Dish> foundDishes = new List<Dish>();

foreach (var dish in menu)
{
    if (dish.Calories >= 150 && dish.Calories <= 300)
    {
        foundDishes.Add(dish);
    }
}

foreach (var dish in foundDishes)
{
    Console.WriteLine(dish);
}

