using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK-IT
{
    class Program
    {
        static void Main(string[] args)
        {
            T1();
        }

        // Tehtävä 1
        static void T1()
        {
            string input;
            bool exit = false;
            
            Heater kiuas = new Heater();
            Console.WriteLine("Tämä on kämynen kiuas simulaattori, jolla voi laittaa kiukaan päälle, ja säätää sen lämpöä ja sen antamaa kosteutta.\n");
            while (!exit) { 
                Console.WriteLine("Mitä haluat tehdä? Power = on/off, lämpötilaa säädät t###, ja kosteutta h0-100.\nPoistu sovelluksest kirjoittamalla x.");
                Console.Write("Arvot: Power = {0}, lämmöt = {1}, kosteus = {2}.\n\n> ", kiuas.Power, kiuas.Temperature, kiuas.Humidity);
                input = Console.ReadLine();
                int[] menu = CipherInput(input);
                switch (menu[0])
                {
                    case 99:
                        break;
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        kiuas.Power = true;
                        break;
                    case 2:
                        kiuas.Power = false;
                        break;
                    case 3:
                        kiuas.Temperature = menu[1];
                        break;
                    case 4:
                        kiuas.Humidity = menu[1];
                        break;

                }
                Console.Clear();
            }
        
        }
        static int[] CipherInput(string input)
        {
            int[] temp = new int[2];
            if (input == "on" || input == "On" || input == "ON")
                temp[0] = 1;
            else if (input == "off" || input == "Off" || input == "OFF")
                temp[0] = 2;
            else if (input[0] == 't')
            {
                string val = input.Substring(1);
                if (!int.TryParse(val, out temp[1]))
                {
                    Console.WriteLine("Illegal input!");
                    temp[0] = 99;
                }
                else
                    temp[0] = 3;
            }
            else if (input[0] == 'h')
            {
                string val = input.Substring(1);
                if (!int.TryParse(val, out temp[1]))
                {
                    Console.WriteLine("Illegal input!");
                    temp[0] = 99;
                }
                else if (int.TryParse(val, out temp[1]) && (temp[1] <= 0 || temp[1] >= 100))
                    temp[0] = 4;
                else
                {
                    Console.WriteLine("Illegal input!");
                    temp[0] = 99;
                }
            }
            else if (input == "x")
                temp[0] = 0;
            else { 
                Console.WriteLine("Illegal input!");
                temp[0] = 99;
            }
            return temp;
        }
    }

    class Heater
    {
        public bool Power { get; set; }
        private int temperature;
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (Power)
                {
                    if (value >= 0 || value <= 100)
                    {
                        temperature = value;
                    }
                }
            }
        }
        private int humidity;
        public int Humidity {
            get {
                return humidity;
            }
            set {
                if (Power) {
                    if (value >= 0 || value <= 100)
                    {
                        humidity = value;
                    }
                    else
                        Console.WriteLine("Invalid value!");

                }
            }
        }// End Humidity
        public Heater()
        {
            Power = false;
            Temperature = 21;
            Humidity = 0;
         
        }
    } // End Heater

  
   
    
}
