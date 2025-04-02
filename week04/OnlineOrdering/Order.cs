using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Costumer _costumer = new Costumer();

    public Order() {}
    public Order(Costumer costumer)
    {
        _costumer = costumer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public int GetTotalPrice()
    {
        int totalCost = 0;
        int costShipping;

        if (_costumer.IsInUsaOrNot())
        {
            costShipping = 5;
        }
        else
        {
            costShipping = 35;
        }
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        return totalCost + costShipping;   
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetProductLabel()}\n";
        }
        return label;
    }
    
    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCostumer Name: {_costumer.GetCustomerName()}\nCostumer Address: {_costumer.GetCustomerAddress()}";
    }
}
