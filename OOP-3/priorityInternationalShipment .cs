
using deliveryCenter;
using System.Runtime.InteropServices.Marshalling;

namespace OOP_3
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
        }
        public override void GenerateCustomReport() 
        {
            Console.WriteLine($"type {this.GetType().Name}");
            base.PrintShipment();
        }
    }
}
