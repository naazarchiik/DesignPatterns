namespace ClassLibrary;

public class Product : IProduct
{
    public string Name { get; set; }
    public Money Price { get; set; }

    public Product(string name, Money price)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty.", nameof(name));
        }

        if (price == null)
        {
            throw new ArgumentNullException(nameof(price), "Price cannot be null.");
        }

        Name = name;
        Price = price;
    }

    public void ReducePrice(int amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be negative.");
        }

        if (Price.GetWholePart() < amount)
        {
            throw new InvalidOperationException("Cannot reduce price below zero.");
        }

        var newPrice = Price.GetWholePart() - amount ; 

        Price.SetWholePart(newPrice);
    }
}