public interface IList
{
    public Product[] Add(int id, string title, int price);

    public Product[] AddRange(Product[] newProducts);

    public bool Remove(Product item);

    public Product[] RemoveAt(int index);

    public Product[] Sort();

    public IEnumerable<Product> GetProducts(int max);
}