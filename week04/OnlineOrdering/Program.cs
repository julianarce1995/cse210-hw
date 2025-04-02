using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("11a Roosvelt", "Cali", "Valle del Cauca", "Colombia");
        Costumer costumer1 = new Costumer("Juan", address1);
        Order order1 = new Order(costumer1);
        Product product11 = new Product("printer", 106, 150, 9);
        Product product12 = new Product("Laptop", 101, 210, 1);
        Product product13 = new Product("Mouse", 102, 25, 3);
        order1.AddProduct(product11);
        order1.AddProduct(product12);
        order1.AddProduct(product13);

        Address address2 = new Address("1600 Amphitheatre Parkway", "Mountain View", "California", "USA");
        Costumer costumer2 = new Costumer("Camilo", address2);
        Order order2 = new Order(costumer2);
        Product product21 = new Product("keyboard", 103, 80, 4);
        Product product22 = new Product("Monitor", 104, 300, 7);
        Product product23 = new Product("headphones", 125, 300, 2);
        order2.AddProduct(product21);
        order2.AddProduct(product22);
        order2.AddProduct(product23);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("total price: " + order1.GetTotalPrice()+"\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("total price: " + order2.GetTotalPrice()+"\n");
    }
}