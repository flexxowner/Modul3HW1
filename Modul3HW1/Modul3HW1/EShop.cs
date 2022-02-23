public class EShop : IList
{
    private Product[] _products;

    public int Lenght { get; set; } = 0;

    public EShop(Product[] products)
    {
        _products = products;
    }

    public Product[] Add(int id, string title, int price)
    {
        var list = new Product[_products.Length + 1];
        Array.Copy(_products, list, _products.Length);
        list[list.Length - 1] = new Product() { ID = id, Title = title, Price = price };
        _products = list;
        Lenght = _products.Length;
        return list;
    }

    public Product[] AddRange(Product[] newProducts)
    {
        var list = new Product[_products.Length + newProducts.Length];
        Array.Copy(_products, list, _products.Length);
        Array.Copy(newProducts, 0, list, _products.Length, 3);
        _products = list;
        Lenght = _products.Length;
        return list;
    }

    public IEnumerable<Product> GetProducts(int max)
    {
        for (int i = 0; i < max; i++)
        {
            if (i == _products.Length)
            {
                yield break;
            }
            else
            {
                yield return _products[i];
            }
        }
    }

    public bool Remove(Product item)
    {
        for (int i = 0; i < _products.Length; i++)
        {
            if (_products[i] == item)
            {
                RemoveAt(i);
                i--;
            }
        }

        return true;
    }

    public Product[] RemoveAt(int index)
    {
        try
        {
            var list = new Product[_products.Length - 1];
            for (int i = 0; i < index; i++)
            {
                list[i] = _products[i];
            }

            for (int i = index + 1; i < _products.Length; i++)
            {
                list[i - 1] = _products[i];
            }

            _products = list;
            Lenght = _products.Length;
            return list;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            throw;
        }
    }

    public Product[] Sort()
    {
        int temp;
        for (int i = 0; i < _products.Length; i++)
        {
            for (int j = i + 1; j < _products.Length; j++)
            {
                if (_products[i].Price > _products[j].Price)
                {
                    temp = _products[i].Price;
                    _products[i].Price = _products[j].Price;
                    _products[j].Price = temp;
                }
            }
        }

        return _products;
    }
}
