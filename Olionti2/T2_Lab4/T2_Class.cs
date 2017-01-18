using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK_IT
{
    class Amplifier
    {
        public readonly int MaxAmp = 100;
        public readonly int MinAmp = 0;
        private int currentAmp;
        public int CurrentAmp
        {
            get
            {
                return currentAmp;
            }
            set
            {
                if (value < MinAmp)
                    currentAmp = MinAmp;
                else if (value > MaxAmp)
                    currentAmp = MaxAmp;
                else
                    currentAmp = value;
            }
        }
        public Amplifier()
        {
            currentAmp = MinAmp;
        }
        public Amplifier(int i)
        {
            CurrentAmp = i;
        }
    }
}
