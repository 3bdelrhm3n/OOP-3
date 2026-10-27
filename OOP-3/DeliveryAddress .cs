namespace deliveryCenter;

public  struct DeliveryAddress
{
    public string Street;
    public string City;
    public int BuildingNumber;

    public DeliveryAddress(string city, string street, int buildingNumber)
    {
        Street = street;
        City = city;
        BuildingNumber = buildingNumber;
    }

    public string GetFullAddress()
    {
        return $"{Street} {BuildingNumber}, {City}";
    }

}
