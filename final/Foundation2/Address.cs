public class Address
{
    private string StreetAddress;
    private string City;
    private string StateProvince;
    private string Country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public bool IsInUSA() => Country.ToLower() == "usa";

    public string GetFormattedAddress() => $"{StreetAddress}\n{City}, {StateProvince}\n{Country}";
}
