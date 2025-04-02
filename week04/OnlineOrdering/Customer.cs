using System;

public class Costumer
{
    private string _name;
    private Address _address = new Address();

    public Costumer(){}
    public Costumer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public Boolean IsInUsaOrNot()
    {
        return _address.IsInUsaOrNot();
    }
    public String GetCustomerName()
    {
        return _name;
    }
    public String GetCustomerAddress()
    {
        return _address.GetAddressString();
    }
}
