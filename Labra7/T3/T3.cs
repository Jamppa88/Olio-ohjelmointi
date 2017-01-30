using System;


/* Tee ohjelma, joka kysyy käyttäjältä lukuja (joko kokonaisluku tai reaaliluku) ja tallenna kokonaisluvut eri tiedostoon kuin reaaliluvut. 
 * Sovellus tulee lopettaa, jos käyttäjä ei syötä kokonais- tai reaalilukua. Tarkista tiedostojen sisältö jollain tekstieditorilla.
 */

namespace JAMK_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter writeIntegers = null;
            System.IO.StreamWriter writeDoubles = null;
            System.IO.StreamReader readIntegers = null;
            System.IO.StreamReader readDoubles = null;
            int inInt;
            double inDouble;
            string input;
            bool exit = false;
            try
            {
                writeIntegers = new System.IO.StreamWriter("ints.txt");
                writeDoubles = new System.IO.StreamWriter("doubles.txt");
                while (!exit)
                {
                    Console.Write("Anna luku (lopetus enterillä): ");
                    input = Console.ReadLine();
                    if (input == "")
                        exit = true;
                    else if (int.TryParse(input, out inInt))
                    {
                        writeIntegers.WriteLine(inInt);
                    }
                    else if (double.TryParse(input, out inDouble))
                    {
                        writeDoubles.WriteLine(inDouble);
                    }
                    else
                        Console.WriteLine("Tuntematon syöte!");
                }
                writeIntegers.Close();
                writeDoubles.Close();
                readIntegers = new System.IO.StreamReader("ints.txt");
                readDoubles = new System.IO.StreamReader("doubles.txt");
                Console.WriteLine("Syötetyt kokonaisluvut: ");
                Console.Write(readIntegers.ReadToEnd());
                Console.WriteLine("Syötetyt reaaliluvut: ");
                Console.Write(readDoubles.ReadToEnd());
                Console.ReadKey();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }finally
            {
                if (writeIntegers != null)
                {
                    writeIntegers.Close();
                }
                if (writeDoubles != null)
                {
                    writeDoubles.Close();
                }
                if (readDoubles != null)
                {
                    readDoubles.Close();
                }
                if (readIntegers != null)
                {
                    readIntegers.Close();
                }
            }
            
        }
    }
}
