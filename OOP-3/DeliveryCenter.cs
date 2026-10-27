using OOP_3;

namespace deliveryCenter;

internal class DeliveryCenter
{
   private Shipment[] Shipments;

    public Driver driver { get; set; }
    public DeliveryCenter()
    {
        Shipments =new Shipment[20];
    }
    public Shipment this [int index]
    {
        get 
        { 
           if (index >= 0 && index < Shipments.Length)
            {
                return Shipments[index];
            }
            return default;
        }
        set
        {
            if (index >= 0 && index < Shipments.Length)
            {
                Shipments[index] = value;
            }
        }
    }

    public Shipment this [string trackingCode]
    {
        get
        {
            foreach (Shipment s in Shipments)
            {
                if (s.TrackingCode == trackingCode && s.TrackingCode != null)
                    return s;
            }
            return default;
        }
    }

    public bool AddShipment(Shipment shipment)
    {
        for (int i = 0; i < Shipments.Length; i++)
        {
            if (Shipments[i].TrackingCode == null)
            {
                Shipments[i] = shipment;
                return true;
            }
        }
        return false;
    }
    public bool RemoveShipment(string trackingCode)
    {
        for (int i = 0; i < Shipments.Length; i++)
        {
            if (Shipments[i].TrackingCode == trackingCode)
            {
                Shipments[i] = null;
                return true;
            }
        }
        return false;
    }
    public void printAllShipments()
    {
        foreach (Shipment s in Shipments)
        {
            if (s.TrackingCode != null)
            {
                Console.WriteLine(s);
            }
        }
    }

}
