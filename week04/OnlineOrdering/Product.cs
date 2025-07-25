public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        double totalCost = _price * _quantity;
        return totalCost;
    }

    public string GetProduct()
    {
        return $"·{_productId} - {_name} ({_quantity})";
    }

}