using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK_IT
{
    class Elevator
    {
        public readonly int MaxFloor = 5;
        public readonly int MinFloor = 1;
        private int currentFloor;
        public int CurrentFloor
        {
            get
            {
                return currentFloor;
            }
            set
            {
                if (value >= MinFloor && value <= MaxFloor)
                    currentFloor = value;
            }
        }
        public Elevator()
        {
            currentFloor = MinFloor;
        }

    }
}
