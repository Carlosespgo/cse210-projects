using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Avenida Las Palmas #45", "Medellín", "Antioquia", "Colombia");
        Customer customer1 = new Customer("Laura Martínez", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Diana Rice 1kg", "PROD001", 1.05, 2));
        order1.AddProduct(new Product("Vegetable oil 900ml", "PROD002", 2.13, 1));
        order1.AddProduct(new Product("AA eggs x12", "PROD003", 1.95, 1));
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel(customer1));
        Console.WriteLine();
        Console.WriteLine($"Total price: {order1.CalculateTotalPrice()}");
        Console.WriteLine("-------------------------------------------------------");

        Address address2 = new Address("Calle: 742 Evergreen Terrace", "Springfield", "Illinois", "United States");
        Customer customer2 = new Customer("Emily Johnson", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Milk 1 Gallon", "PROD004", 3.49, 1));
        order2.AddProduct(new Product("Whole Wheat Bread", "PROD005", 2.99, 2));
        order2.AddProduct(new Product("Ground Coffee 12oz", "PROD006", 5.99, 1));
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel(customer2));
        Console.WriteLine();
        Console.WriteLine($"Total price: {order2.CalculateTotalPrice()}");
        Console.WriteLine("-------------------------------------------------------");
    }
}