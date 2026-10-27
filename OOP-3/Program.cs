using OOP_3;
using System.Threading.Channels;

namespace deliveryCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryAddress original = new DeliveryAddress("Alex", "abo qeur", 66);
            DeliveryAddress copy = original;
            copy.City="Cairo";
            copy.Street = "maadi";
            copy.BuildingNumber = 55;
             
            Driver driver = new Driver(1, "John Doe", 1234567890);
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            for (int i=1; i<=3; i++)
            {
                Console.WriteLine($"--- Enter data for shipment {i} ---");
                Console.WriteLine("TrackingCode: ");
                string code = Console.ReadLine();
                Console.WriteLine("Description: ");
                string description = Console.ReadLine();
                Console.WriteLine("Weight: ");
                decimal weight = decimal.Parse(Console.ReadLine());
                Console.WriteLine("DeliveryFee: ");
                decimal fee = decimal.Parse(Console.ReadLine());
                Console.WriteLine("City: ");
                string city = Console.ReadLine();
                Console.WriteLine("Street: ");
                string street = Console.ReadLine();
                Console.WriteLine("BuildingNumber");
                int building = int.Parse(Console.ReadLine());

                DeliveryAddress address = new DeliveryAddress(city, street, building);
                Shipment shipment = new Shipment(code, description, weight, fee, address);

                deliveryCenter.AddShipment(shipment);
                Console.WriteLine();
            }
            deliveryCenter.driver = driver;

            Console.WriteLine("=== All shipments ===");
            for (int i = 0; i < 3; i++)
            {
                deliveryCenter[i].PrintShipment();
                Console.WriteLine();
            }
            Console.Write("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment found = deliveryCenter[searchCode];

            if (found.TrackingCode != null)
                found.PrintShipment();
            else
                Console.WriteLine("Shipment not found.");



            Console.WriteLine("---- Struct copy test----");
            Console.WriteLine($"Original : {original }");
            Console.WriteLine($"Copy : {copy }");
            
            StandardShipment standardShipment = new StandardShipment("STD123", "Standard Package", 2.5m, 15.0m, new DeliveryAddress("New York", "5th Avenue", 101));
            ExpressShipment expressShipment = new ExpressShipment("EXP456", "Express Package", 3.0m, 20.0m, new DeliveryAddress("Los Angeles", "Main Street", 202), 10.0m);
            InternationalShipment internationalShipment = new InternationalShipment("INT789", "International Package", 4.0m, 25.0m, new DeliveryAddress("London", "Baker Street", 303), "United Kingdom", 5.0m);

        }
    }
}
