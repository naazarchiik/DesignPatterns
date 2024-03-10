namespace ClassLibrary;

public class Warehouse(List<WarehouseItem> items)
{
    public List<WarehouseItem> Items { get; set; } = items;

    public Warehouse() : this(new List<WarehouseItem>())
    {
    }

    public void AddItem(WarehouseItem item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), "Item cannot be null.");
        }

        if (!Items.Contains(item))
        {
            Items.Add(item);
        }
    }
}