using System;

struct Product
{
    public int id;
    public string name;
    public int quantity;
    public double price;
}

class Program
{
    static Product[] products = new Product[100];
    static int productCount = 0;

    static void Main()
    {
    }

    static void AddProduct()
    {
        Product product = new Product();

        Console.Write("Enter Product ID: ");
        product.id = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Product Name: ");
        product.name = Console.ReadLine()!;

        Console.Write("Enter Quantity: ");
        product.quantity = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Price: ");
        product.price = double.Parse(Console.ReadLine()!);

        products[productCount] = product;
        productCount++;
    }

    static void DisplayProducts()
    {
        for (int i = 0; i < productCount; i++)
        {
            Console.WriteLine("ID: " + products[i].id);
            Console.WriteLine("Name: " + products[i].name);
            Console.WriteLine("Quantity: " + products[i].quantity);
            Console.WriteLine("Price: " + products[i].price);
            Console.WriteLine();
        }
    }

    static void SearchProduct(int id)
    {
        for (int i = 0; i < productCount; i++)
        {
            if (products[i].id == id)
            {
                Console.WriteLine("ID: " + products[i].id);
                Console.WriteLine("Name: " + products[i].name);
                Console.WriteLine("Quantity: " + products[i].quantity);
                Console.WriteLine("Price: " + products[i].price);
                return;
            }
        }

        Console.WriteLine("Product not found.");
    }

    static void EditProduct(int id)
    {
        for (int i = 0; i < productCount; i++)
        {
            if (products[i].id == id)
            {
                Console.Write("Enter Product Name: ");
                products[i].name = Console.ReadLine()!;

                Console.Write("Enter Quantity: ");
                products[i].quantity = int.Parse(Console.ReadLine()!);

                Console.Write("Enter Price: ");
                products[i].price = double.Parse(Console.ReadLine()!);

                return;
            }
        }

        Console.WriteLine("Product not found.");
    }

    static void DeleteProduct(int id)
    {
        for (int i = 0; i < productCount; i++)
        {
            if (products[i].id == id)
            {
                for (int j = i; j < productCount - 1; j++)
                {
                    products[j] = products[j + 1];
                }

                productCount--;
                return;
            }
        }

        Console.WriteLine("Product not found.");
    }
}
