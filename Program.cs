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

        CartItem[] cart = new CartItem[5];
        int cartCount = 0;

        string choice = "Y";

        while (choice.ToUpper() == "Y")
        {
            Console.WriteLine("\n=== PRODUCT MENU ===");
            foreach (var p in products)
            {
                p.DisplayProduct();
            }

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
        
            bool found = false;
            for (int i = 0; i < cartCount; i++)
            {
                if (cart[i].Product.Id == selectedProduct.Id)
                {
                    cart[i].Quantity += quantity;
                    cart[i].UpdateSubtotal();
                    found = true;
                    break;
                }
            }
                    if (!found)
            {
                if (cartCount >= cart.Length)
                {
                    Console.WriteLine("Cart is full.");
                    continue;
                }

                cart[cartCount] = new CartItem
                {
                    Product = selectedProduct,
                    Quantity = quantity
                };
                cart[cartCount].UpdateSubtotal();
                cartCount++;
            }

            selectedProduct.DeductStock(quantity);

            Console.WriteLine("Added to cart!");
            Console.WriteLine(" ");
            Console.Write("Add another item? (Y/N): ");
            choice = Console.ReadLine();
        }

                Console.WriteLine("\n=== RECEIPT ===");
        double grandTotal = 0;

        for (int i = 0; i < cartCount; i++)
        {
            Console.WriteLine($"{cart[i].Product.Name} x{cart[i].Quantity} = ₱{cart[i].Subtotal}");
            grandTotal += cart[i].Subtotal;
        }

        Console.WriteLine($"Grand Total: ₱{grandTotal}");

        double discount = 0;
        if (grandTotal >= 5000)
        {
            discount = grandTotal * 0.10;
            Console.WriteLine("Discount (10%): ₱" + discount);
        }

        double finalTotal = grandTotal - discount;
        Console.WriteLine("Final Total: ₱" + finalTotal);

    }
}
