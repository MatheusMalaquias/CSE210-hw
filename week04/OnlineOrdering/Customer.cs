public class Customer
{
    private string _name;
    private Address _address; 

    public Customer(string name, Address address, string phoneNumber)
    {
        _name = name;
        _address = address;

    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
    public string GetName()
    {
        return _name;
    }

}