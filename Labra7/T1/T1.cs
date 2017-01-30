using System;


namespace JAMK_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = null;
            System.IO.StreamReader inputFile = null;
            string input;
            bool exit = false;
            try
            {
                outputFile = new System.IO.StreamWriter("T1TextLines.txt");
                Console.WriteLine("Tiedosto avattu onnistuneesti!");
                while (!exit)
                {
                    Console.Write("Anna talletettava teksti(enter lopettaa): ");
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        exit = true;
                    }
                    else
                    {
                        outputFile.WriteLine(input);
                    }
                }
                outputFile.Close();
                inputFile = new System.IO.StreamReader("T1TextLines.txt");
                Console.WriteLine("Tiedoston sisältö:");
                Console.Write(inputFile.ReadToEnd());
                inputFile.Close();
                
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                    
                }
            }
            
            
        }
    }
}
