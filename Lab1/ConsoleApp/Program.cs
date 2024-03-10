using System.Text;
using ClassLibrary;

namespace ConsoleApp;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        
        // Створюємо нові об'єкти валют
        ICurrency dollar = new Dollar();
        ICurrency euro = new Euro();

        // Створюємо нові об'єкти грошей
        Money money1 = new Money(100, 50, dollar);
        Money money2 = new Money(200, 25, euro);

        // Створюємо новий товар
        Product product = new Product("Продукт 1", money1);
        Console.WriteLine($"Ціна продукту {product.Name}: {product.Price.GetWholePart()}.{product.Price.GetFractionalPart()} {product.Price.Currency.Symbol}");

        
        // Зменшуємо ціну товару
        product.ReducePrice(10);
        Console.WriteLine($"Нова ціна продукту {product.Name}: {product.Price.GetWholePart()}.{product.Price.GetFractionalPart()} {product.Price.Currency.Symbol}");

        // Створюємо новий склад
        Warehouse warehouse = new Warehouse();

        // Створюємо новий товар для складу
        WarehouseItem warehouseItem = new WarehouseItem("Товар 1", "шт", money1, 10, DateTime.Now);

        WarehouseItem warehouseItem2 = new WarehouseItem("Товар 2", "шт", money2, 20, DateTime.Now);

        
        // Додаємо товар на склад
        warehouse.AddItem(warehouseItem);
        Console.WriteLine($"Товар {warehouseItem.Name} додано на склад.");
        
        warehouse.AddItem(warehouseItem2);
        Console.WriteLine($"Товар {warehouseItem2.Name} додано на склад.");

        // Створюємо новий об'єкт звітності
        Reporting reporting = new Reporting(warehouse);

        // Реєструємо надходження товару
        reporting.RegisterArrival(warehouseItem);
        Console.WriteLine($"Товар {warehouseItem.Name} зареєстровано як отриманий.");
        
        reporting.RegisterArrival(warehouseItem2);
        Console.WriteLine($"Товар {warehouseItem2.Name} зареєстровано як отриманий.");

        // Реєструємо відвантаження товару
        reporting.RegisterDeparture(warehouseItem, 3);
        Console.WriteLine($"Товар {warehouseItem.Name} зареєстровано як відвантажений.");

        // Створюємо звіт по інвентаризації
        reporting.InventoryReport();
    }
}