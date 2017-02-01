using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> ostokset = new List<Product>();
            ostokset.Add(new Product("Maito", 1.10));
            ostokset.Add(new Product("Karhu III", 1.09));
            ostokset.Add(new Product("Näkkileipä", 2.30));
            ostokset.Add(new Product("Oltermanni", 5.95));
            ostokset.Add(new Product("Banaani", 0.20));

            Console.WriteLine("Ostoskorin sisältö:");
            foreach (var item in ostokset)
            {
                Console.WriteLine("- {0}, {1:f2}€", item.Name, item.Price);
            }
            Console.ReadKey();
        }
    }
}
