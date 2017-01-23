using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Vaatekaappi vkaappi = new Vaatekaappi();
            Vartalo mina = new Vartalo();
            Hattu hattu = new Hattu("Lätsä", 0);
            vkaappi.Sisalto.Add(hattu);
            Paita paita = new Paita("T-paita");
            vkaappi.Sisalto.Add(paita);
            Housut housut = new Housut("Levikset");
            vkaappi.Sisalto.Add(housut);
            Kengat kengat = new Kengat("Sandaalit");
            vkaappi.Sisalto.Add(kengat);
            hattu = new Hattu("Pipo", 20);
            vkaappi.Sisalto.Add(hattu);
            paita = new Paita("Huppari");
            vkaappi.Sisalto.Add(paita);
            housut = new Housut("Shortsit");
            vkaappi.Sisalto.Add(housut);
            kengat = new Kengat("Maiharit");
            vkaappi.Sisalto.Add(kengat);
            Console.WriteLine("Vaatekaapin sisältö:");
            for (int i = 0; i < vkaappi.Sisalto.Count; i++)
            {
                Console.Write(vkaappi.Sisalto[i].Nimi + " ");
            }
            Console.WriteLine("\nUlkona vaikuttaisi lämpimältä, puetaan päälle.");
            mina.MitaPaalla();
            vkaappi.Sisalto[0].Pue(mina);
            vkaappi.Sisalto[1].Pue(mina);
            vkaappi.Sisalto[6].Pue(mina);
            vkaappi.Sisalto[3].Pue(mina);
            mina.MitaPaalla();

            Console.WriteLine("\nUlkona onkin tosi kylmä, vaihdetaan vaatteet.\n");
            vkaappi.Sisalto[2].Pue(mina);
            vkaappi.Sisalto[4].Pue(mina);
            vkaappi.Sisalto[5].Pue(mina);
            vkaappi.Sisalto[7].Pue(mina);
            mina.MitaPaalla();
            Console.ReadKey();
        }
    }
}
