using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK_IT
{
    class Radio
    {
        public bool Power { get; set; }
        private int volume;

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value < 10)
                    volume = value;
            }
        }
        private double frequency;

        public double Frequency
        {
            get { return frequency; }
            set
            {
                if (value >= 2000 && value <= 26000)
                    frequency = value;
            }
        }
        public Radio()
        {
            Power = false;
            Volume = 0;
            Frequency = 2000;
        }


    }
}
