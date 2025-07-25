public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private List<double> _costs = new List<double>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.CalculateTotalCost();
        }
        double shipping = _customer.LiveInUsa() ? 5 : 35;
        return totalPrice + shipping;
    }

    public string GetPackingLabel()
    {
        string Label = "Packing Label:\n";
        foreach (var product in _products)
        {
            Label += $"{product.GetProduct()}\n";
        }
        return Label;
    }

    public string GetShippingLabel(Customer customer)
    {
        return customer.GetCustomer();
    }
}