using System;

public class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product() { }
    public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public int GetTotalCost()
    {
        return _price * _quantity;
    }
    public string GetProductLabel()
    {
        return $"Product Name: {_name}\nProduct Id: {_productId}";
    }
}
