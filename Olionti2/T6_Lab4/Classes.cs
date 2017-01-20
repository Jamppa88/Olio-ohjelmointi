using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
