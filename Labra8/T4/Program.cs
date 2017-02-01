using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();
            shapes.Kuviot.Add(new Circle("ympyrä", 2));
            Console.WriteLine("Circle {0} Radius: {1}, Area: {2}, Circumference: {3}", shapes.Kuviot[0].Name, (Circle)shapes.Kuviot[0].Ra)
        }
    }
}
