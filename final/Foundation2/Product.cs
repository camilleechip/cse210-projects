public class Product
{
    private string _productName;
    private int _productId;
    private int _quantity;
    private int _ppu;

    public Product(string productName, int productId, int quantity, int ppu)
    {
        _productName = productName;
        _productId = productId;
        _quantity = quantity;
        _ppu = ppu;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public int GetPricePerUnit()
    {
        return _ppu;
    }
}