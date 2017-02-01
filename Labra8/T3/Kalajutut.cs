using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Kalastaja
    {
        public string Name { get; set; }
        public string PuhNum { get; set; }
        public Kalastaja(string name, string puhNum)
        {
            Name = name;
            PuhNum = puhNum;
        }
        public List<Kala> Kalat = new List<Kala>();
    }
    class Kala
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public double Weight { get; set; }
        public Kalapaikka FoundAt { get; set; }
        public Kala(string name, int length, double weight, Kalapaikka foundAt)
        {
            Name = name;
            Length = length;
            Weight = weight;
            FoundAt = foundAt;
        }
        
    }
    class Kalapaikka
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public Kalapaikka(string name, string place)
        {
            Name = name;
            Place = place;
        }
    }
}
