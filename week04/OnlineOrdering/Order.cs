public class Order 
{
    private Customer _customer;
    private List<Product> _products;
    private double _totalPrice;
    public Order( Customer customer, List<Product> products)
    {
        
        _customer = customer;
        _products = products;
        CalculateTotalPrice();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
        CalculateTotalPrice();
    }

    private void CalculateTotalPrice()
    {
        _totalPrice = 0;
        foreach (var product in _products)
        {
            _totalPrice += product.totalPrice();
        }

        if (_customer.LivesInUSA())
        {
            _totalPrice += 5.00; // Shipping fee for USA customers
        }
        else
        {
            _totalPrice += 35.00; // Shipping fee for non-USA customers
        }
    }

    public double GetTotalPrice()
    {
        return _totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label\n";
        packingLabel += "Products:\n";

        foreach (var product in _products)
        {
            packingLabel += $"{product.GetName()} - {product.GetQuantity()} units\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label" +
               $"\nCustomer: {_customer.GetName()}" +
               $"\nAddress: {_customer.GetFullAddress()}";
    }
}