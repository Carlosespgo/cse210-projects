public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUsa()
    {
        return _city.ToLower() == "usa" || _city.ToLower() == "united states";
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}\n{_state}, {_country}";
    }
}