namespace deliveryCenter;
public  class Shipment
{
    string trackingCode;
    string description;
    decimal weight;
    decimal deliveryFee;
    DeliveryAddress destination;

    public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
    {
        TrackingCode = trackingCode;
        Description = description;
        Weight   = weight;
        DeliveryFee  = deliveryFee;
        Destination = destination;
    }
    public string TrackingCode
    {
        get { return trackingCode; }
       private set
        {
            if (!string.IsNullOrWhiteSpace (value))
            {
                trackingCode = value;
            }
        }
    }

    public string Description
    {
        get { return description; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                description = value;
            }
        }
    }

    public decimal Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
            {
                weight = value;
            }
        }
    }

    public decimal DeliveryFee
    {
        get { return deliveryFee; }
       private set
        {
            if (value > 0)
            {
                deliveryFee = value;
            }
        }
    }

    public DeliveryAddress Destination
    {
        get { return destination; }
        set
        {
            destination = value;
        }
    }

    public virtual  decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5); }
    }
    public void UpdateDeliveryFee(decimal newFee)
    {
         DeliveryFee = newFee;
    }
    public Shipment (string trackingCode): this(trackingCode, "Unknown", 1, 50 , new DeliveryAddress ("unknown","unknown",0)) { }
    public void PrintShipment()
    {
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
        Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
        Console.WriteLine($"Destination: {destination.GetFullAddress()}");
    }

}
