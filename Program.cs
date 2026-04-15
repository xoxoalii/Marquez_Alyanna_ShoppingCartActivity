using System;

class Product
{
    public int Id;
    public string Name;
    public double Price;
    public int RemainingStock;

    public void DisplayProduct()
    {
        Console.WriteLine($"{Id}. {Name} - ₱{Price} (Stock: {RemainingStock})");
    }
    
    public double GetItemTotal(int quantity)
    {
        return Price * quantity;
    }

    public bool HasEnoughStock(int quantity)
    {
        return quantity <= RemainingStock;
    }

    public void DeductStock(int quantity)
    {
        RemainingStock -= quantity;
    }
}

class CartItem
{
    public Product Product;
    public int Quantity;
    public double Subtotal;

    public void UpdateSubtotal()
    {
        Subtotal = Product.Price * Quantity;
    }
}

class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Television", Price = 30000, RemainingStock = 5 },
            new Product { Id = 2, Name = "Washing Machine", Price = 5000, RemainingStock = 10 },
            new Product { Id = 3, Name = "Speaker", Price = 800, RemainingStock = 7 },
            new Product { Id = 4, Name = "Refrigerator", Price = 13000, RemainingStock = 3 }
        };

        Console.WriteLine("=== STORE MENU ===");
        foreach (var p in products)
        {
            p.DisplayProduct();
        }
        
        Console.Write("Enter product number: ");
        if (!int.TryParse(Console.ReadLine(), out int productNumber) ||
            productNumber < 1 || productNumber > products.Length)
        {
            Console.WriteLine("Invalid product number.");
            continue;
        }

        Product selectedProduct = products[productNumber - 1];   

                    if (selectedProduct.RemainingStock == 0)
            {
                Console.WriteLine("This product is out of stock.");
                continue;
            }

            Console.Write("Enter quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity.");
                continue;
            }

            if (!selectedProduct.HasEnoughStock(quantity))
            {
                Console.WriteLine("Not enough stock available.");
                continue;
            }
    }
}
