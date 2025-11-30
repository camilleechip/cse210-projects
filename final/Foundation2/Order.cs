using System.Data.SqlTypes;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Emit;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product p in _products)
        {
            label += $" {p.GetProductName()}, ID: {p.GetProductId()} |";
        }
        
        return label.Trim();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}, {_customer.GetAddress()}";
    }

    public int GetTotalCost()
    {
        int total = 0;

        foreach(Product p in _products)
        {
            total += p.GetQuantity() * p.GetPricePerUnit();
        }

        total += _customer.IsDomestic() ? 5 : 35;

        return total;
    }

}
