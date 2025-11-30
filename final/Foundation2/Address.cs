public class Address
{
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private bool _isDomestic;
    private int _price;

    public Address(string city, string stateOrProvince, string country)
    {
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;

        if (country == "USA")
        {
            _isDomestic = true;
            _price = 5;
        }

        else
        {
            _isDomestic = false;
            _price = 35;
        }
    }

    public int GetPrice()
    {
        return _price;
    }

    public string GetAddress()
    {
        return $"{_city}, {_stateOrProvince}, {_country}";
    }

    public bool GetDomestic()
    {
        return _isDomestic;
    }
}