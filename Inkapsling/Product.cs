namespace Inkapsling;

internal class Product
{
    private string name;
    private double price;
    private int stock;

    public string Name
    {
        get { return name; }
        set 
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));

            name = value;
        }
    }

    public double Price
    {
        get { return price; }
        set 
        {
            if (value < 0)
                throw new ArgumentException(nameof(value));

            price = value;
        }
    }

    public int Stock
    {
        get => stock;
    }

    public Product(string name, double price, int stock)
    {
        this.name = name;
        this.price = price;
        this.stock = stock;
    }

    public void AddAmount(int amount)
    {
        stock += amount;
    }

    public void SellProduct(int amount)
    {
        if (stock - amount < 0)
            throw new ArgumentException("Not enough product in storage.");

        stock -= amount;
    }

    public double GiveDiscount(double percent)
    {
        if (percent >= 100 || percent < 0)
            throw new ArgumentException("Discount can't be less than 0 or greater than 100.");

        return price - (percent / 100 * price);
    }
}
