namespace JAMK_IT
{
    class Tyre
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string TyreSize { get; set; }

        public Tyre()
        {
            Brand = "Nokia";
            Type = "Hakkapeliitta";
            TyreSize = "205R16";
        }
        public Tyre(string brand, string type, string tyreSize)
        {
            Brand = brand;
            Type = type;
            TyreSize = tyreSize;
        }
    }
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public Vehicle() { }
        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;

        }

        
    }
    class Car: Vehicle
    {
        public Tyre[] Tyres = new Tyre[4];
        public Car() { }
        public Car(string name, string model, Tyre tyre):base(name, model)
        {
            for (int i= 0; i < Tyres.Length; i++)
            {
                Tyres[i] = tyre;
            }
        }
        public string TyreData()
        {
            return Tyres[0].Brand + " " + Tyres[0].Type + " " + Tyres[0].TyreSize; 
        }
    }
    class Motorcycle : Vehicle
    {
        public Tyre[] Tyres = new Tyre[2];
        public Motorcycle() { }
        public Motorcycle(string name, string model, Tyre tyre):base(name, model)
        {
            for (int i = 0; i < Tyres.Length; i++)
            {
                Tyres[i] = tyre;
            }
        }
        public string TyreData()
        {
            return Tyres[0].Brand + " " + Tyres[0].Type + " " + Tyres[0].TyreSize;
        }
    }
}
