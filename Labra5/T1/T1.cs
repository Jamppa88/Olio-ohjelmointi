using System;


namespace JAMK_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Tyre tyre = new Tyre();
            Car porsche = new Car("Porsche", "model 911", tyre);
            tyre = new Tyre("Continental", "Conti Trail Attack 2", "130/80-17 65S");
            Motorcycle mopedi = new Motorcycle("BMW", "RT 1200", tyre);
            Console.WriteLine("Nyt meillä on auto {0}, mallia {1}, ja jossa on neljä rengasta {2}.", porsche.Name, porsche.Model, porsche.TyreData());
            Console.WriteLine("Meillä on myös moottoripyörä {0}, mallia {1}, ja jossa on kaksi rengasta {2}.", mopedi.Name, mopedi.Model, mopedi.TyreData());
        }
    }
}
