public static class Starter
{
    public static void Run()
    {
        var products = new Product[]
            {
                new Product() { ID = 09, Price = 1100, Title = "PS5" }
            };
        EShop shop = new EShop(products);
        NewProducts newProd = new NewProducts();

        shop.Add(06, "PS4", 800);
        shop.Add(07, "Nintendo", 1000);
        shop.Add(09, "Keybord HyperX", 900);
        shop.AddRange(newProd.newProducts);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Shop Data Base:");
        Console.ResetColor();
        Console.WriteLine("------------------------------------");

        foreach (var item in shop.GetProducts(10))
        {
            Console.WriteLine($"{item.Title} - {item.Price}$: ID - {item.ID} \n");
            Console.WriteLine("------------------------------------");
        }

        shop.Remove(products[0]);
        shop.RemoveAt(2);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("After deleting:");
        Console.ResetColor();

        foreach (var item in shop.GetProducts(5))
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{item.Title} - {item.Price}$: ID - {item.ID} \n");
        }

        shop.Sort();
        Console.WriteLine("------------------------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("After sorting:");
        Console.ResetColor();

        foreach (var item in shop.GetProducts(5))
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{item.Title} - {item.Price}$: ID - {item.ID} \n");
        }
    }
}
