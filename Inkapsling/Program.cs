using Inkapsling;

var product1 = new Product("Dator", 1999.95, 10);
var product2 = new Product("Mobiltelefon", 895.50, 25);
var product3 = new Product("Rakblad", 19.95, 102);

var products = new List<Product> { product1, product2, product3 };

foreach (var product in products)
{
    Console.WriteLine("===== PRODUCT =====");
    Console.WriteLine($"Name: {product.Name}");
    Console.WriteLine($"Price: {product.Price}");
    Console.WriteLine($"Amount {product.Stock}");
    if (product.Stock < 5)
        Console.WriteLine("Running low on stock.");
    Console.WriteLine();
}

Console.WriteLine(TotalSaldo(products));
Console.WriteLine($"Discounted price for {product2.Name}: {product2.GiveDiscount(5)}");

static double TotalSaldo(List<Product> products)
{
    double sum = 0;

    foreach(var product in products)
    {
        sum += (product.Price * product.Stock);
    }

    return sum;
}