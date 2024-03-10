namespace ClassLibrary;

public class WarehouseItem
{
    public string Name { get; set; }
    public string UnitOfMeasure { get; set; }
    public Money PricePerUnit { get; set; }
    public int Quantity { get; set; }
    public DateTime LastDeliveryDate { get; set; }

    public WarehouseItem(string name, string unitOfMeasure, Money pricePerUnit, int quantity, DateTime lastDeliveryDate)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty.", nameof(name));
        }

        if (string.IsNullOrEmpty(unitOfMeasure))
        {
            throw new ArgumentException("Unit of measure cannot be null or empty.", nameof(unitOfMeasure));
        }

        if (pricePerUnit == null)
        {
            throw new ArgumentNullException(nameof(pricePerUnit), "Price per unit cannot be null.");
        }

        if (quantity < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity cannot be negative.");
        }

        Name = name;
        UnitOfMeasure = unitOfMeasure;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
        LastDeliveryDate = lastDeliveryDate;
    }
}