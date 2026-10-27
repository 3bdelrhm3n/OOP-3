using System.Security.AccessControl;

namespace deliveryCenter;

internal class ExpressShipment : Shipment
{
    public decimal ExtraFee { get; set { if (value >= 0) ExtraFee = value; } }
    
    public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination,decimal extraFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        ExtraFee = extraFee;
    }
    public override decimal EstimatedCost { get { return DeliveryFee + (Weight * 5) + ExtraFee; }}
    
}

