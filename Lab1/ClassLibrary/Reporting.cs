namespace ClassLibrary;

public class Reporting
{
    private Warehouse _warehouse;

    public Reporting(Warehouse warehouse)
    {
        _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse), "Warehouse cannot be null.");
    }

    public void RegisterArrival(WarehouseItem item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), "Item cannot be null.");
        }

        _warehouse.AddItem(item);
        Console.WriteLine($"Прибуткова накладна: {item.Name}, {item.Quantity} {item.UnitOfMeasure}");
    }

    public void RegisterDeparture(WarehouseItem item, int quantity)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), "Item cannot be null.");
        }

        if (quantity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than zero.");
        }

        if (!_warehouse.Items.Contains(item))
        {
            throw new InvalidOperationException("Item not found in warehouse.");
        }

        if (item.Quantity < quantity)
        {
            throw new InvalidOperationException("Not enough items in warehouse.");
        }

        item.Quantity -= quantity;
        Console.WriteLine($"Видаткова накладна: {item.Name}, {quantity} {item.UnitOfMeasure}");
    }

    public void InventoryReport()
    {
        Console.WriteLine("Звіт по інвентаризації:");
        foreach (var item in _warehouse.Items)
        {
            Console.WriteLine($"{item.Name}, {item.Quantity} {item.UnitOfMeasure}, {item.PricePerUnit.GetWholePart()}.{item.PricePerUnit.GetFractionalPart()} {item.PricePerUnit.Currency.Symbol}, {item.LastDeliveryDate}");
        }
    }
}