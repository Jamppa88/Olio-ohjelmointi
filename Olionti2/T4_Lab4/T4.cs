using System;


namespace JAMK_IT
{
    class Program
    {
        static int biCount = 0;
        static int boCount = 0;
        static void Main(string[] args)
        {
            Bike bike1 = new JAMK_IT.Bike("Jopo", "Street", 2016, "Blue", false, "");
            Bike bike2 = new Bike("Tunturi", "StreetPower", 2010, "Black", true, "Shimano");
            Boat boat1 = new Boat("Suvi", "S900", 1990, "White", "Rowboat", 3);
            Boat boat2 = new Boat("Yamaha","Model 1000",2010,"Yellow","Motorboat",5);
            Tulosta(bike1);
            Tulosta(bike2);
            Tulosta(boat1);
            Tulosta(boat2);
            Console.ReadLine();
        }

        static void Tulosta(Bike bike)
        {
            biCount++;
            Console.WriteLine("Bike{0} info:", biCount);
            Console.WriteLine(" - Name: {0}, Model: {1}, Model Year: {2}, Color: {3}, GearWheels: {4}, Gear Name: {5}", bike.Name, bike.Model, bike.ModelYear, bike.Color, bike.GearWheels, bike.GearName);
        }
        static void Tulosta(Boat boat)
        {
            boCount++;
            Console.WriteLine("Boat{0} info:", boCount);
            Console.WriteLine(" - Name: {0}, Model: {1}, Model Year: {2}, Color: {3}, Seats: {4}, Type: {5}", boat.Name, boat.Model, boat.ModelYear, boat.Color, boat.Seats, boat.Type);
        }
    }
}
