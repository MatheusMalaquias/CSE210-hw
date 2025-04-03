public class Product
{
    private string _name;
    private double _price;
    private int _quantity;
    private int _productId;

    public Product(string name, double price, int quantity, int productId)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _productId = productId;
    }

    public double totalPrice()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}