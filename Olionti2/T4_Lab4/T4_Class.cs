namespace JAMK_IT
{
    class Vehicle
    {
        public string Name{ get; set; }
        public string Model{ get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        public Vehicle(string name, string model, int modelYear, string color)
        {
            Name = name;
            Model = model;
            ModelYear = modelYear;
            Color = color;
        }
    }

    class Bike : Vehicle
    {
        public bool GearWheels{ get; set; }
        public string GearName{ get; set; }

        public Bike(string name, string model, int modelYear, string color, bool gearWheels, string gearName)
            :base(name, model, modelYear, color) 
        {
            GearWheels = gearWheels;
            GearName = gearName;
        }
    }
    class Boat : Vehicle
    {
        public string Type{ get; set; }
        public int Seats { get; set; }

        public Boat(string name, string model, int modelYear, string color, string type, int seats)
            :base(name, model, modelYear, color)
        {
            Type = type;
            Seats = seats;
        }
    }
}
