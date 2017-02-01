using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
   public class Dice
    {
        private int result;
        private Random rng = new Random();
        public int Result { get { return result; } }
        public int Throw()
        {

            result = rng.Next(1, 7);
            return Result;
        }
        /*
        public List<int> Throw(int count)
        {
            List<int> results = new List<int>();
            ...koodia joka tekee työn...
            return results;
        }
        */
    }
}
