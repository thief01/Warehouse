using backend.Models;

namespace backend.Services;

public interface IProductService
{
    bool Add(Product product);

    bool Remove(string name);
    
    Product Get(string name);

    List<Product> GetAll();
}
public class ProductService : IProductService
{
    private readonly List<Product> _products =new List<Product>();
    public bool Add(Product product)
    {
        _products.Add(product);
        return true;
    }

    public bool Remove(string name)
    {
        return _products.RemoveAll(x => x.Name == name) > 0;
    }
    
    public Product Get(string name)
    {
        return _products.FirstOrDefault(x => x.Name == name);
    }

    public List<Product> GetAll()
    {
        return _products;
    }
}