

namespace JAMK_IT
{
    abstract class Appliance
    {
        public bool Power { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color{ get; set; }

        public Appliance(string manu, string model, int mYear, string color)
        {
            Manufacturer = manu;
            Model = model;
            ModelYear = mYear;
            Color = color;
        }
        abstract public string DataSheet();
       
    }
    class Fridge : Appliance
    {
        private bool hasFreezer;
        public bool HasFreezer
        {
            get { return hasFreezer ; }
            set { hasFreezer = value; }
        }
        public int FridgeTemp { get; set; }
        public int FreezeTemp { get; set; }
        public Fridge(string manu, string model, int mYear, string color, bool hasFreezer)
            :base(manu,model, mYear,color)
        {
            HasFreezer = hasFreezer;
        }
        public override string DataSheet()
        {
            string temp = Manufacturer + " " + Model + " " + ModelYear.ToString() + " Has Freezer: " + ((HasFreezer) ? "Yes" : "No") ;
            return temp;
        }
    }
    class Oven : Appliance
    {
        public enum Heating {Kiertoilma, Tasalämpö };
        public int Temperature { get; set; }
        private Heating heatType;

        public Heating HeatType
        {
            get { return heatType; }
            set { heatType = value; }
        }
        public Oven(string manu, string model, int mYear, string color, Heating type)
            : base(manu, model, mYear, color)
        {
            HeatType = type;
        }
        public override string DataSheet()
        {
            string temp = Manufacturer + " " + Model + " " + ModelYear.ToString() + " Heating: " + ((HeatType == 0) ? "Kiertoilma" : "Tasalämpö");
            return temp;
        }
    }
}
