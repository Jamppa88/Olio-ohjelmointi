using System;
using System.Collections.Generic;


namespace JAMK_IT
{
    class Vaatekaappi
    {
        ;
        public List<Vaate> Sisalto = new List<Vaate>(); 
    }
    class Vartalo
    {
        Hattu hattu;
        Paita paita;
        Housut housut;
        Kengat kengat;

        public void Pukeudun(Vaate vaate)
        {
            if (vaate.ID == "Hattu")
            {
                hattu = (Hattu)vaate;
                Console.WriteLine("Puetaan hattua...");
            }

            else if (vaate.ID == "Paita")
            {
                paita = (Paita)vaate;
                Console.WriteLine("Puetaan paitaa...");
            }
                
            else if (vaate.ID == "Housut")
            {
                housut = (Housut)vaate;
                Console.WriteLine("Puetaan housuja...");
            }
                
            else if (vaate.ID == "Kengat")
            {
                kengat = (Kengat)vaate;
                Console.WriteLine("Puetaan kenkiä...");
            }
                
        }
        public void MitaPaalla()
        {
            Console.Write("Hattu: {0}, ", (hattu == null)?"Ei ole":hattu.Nimi);
            Console.Write("Paita: {0}, ", (paita == null) ? "Ei ole" : paita.Nimi);
            Console.Write("Housut: {0}, ", (housut == null) ? "Ei ole" : housut.Nimi);
            Console.WriteLine("Kengät: {0}.", (kengat == null) ? "Ei ole" : kengat.Nimi);
        }
    }
    abstract class Vaate
    {
        public string ID { get; }
        public string Nimi { get; set; }
        public Vaate(string nimi)
        {
            Nimi = nimi;
            ID = ToString();
        }
        abstract public void Pue(Vartalo body);
        public override string ToString()
        {
            return "Vaate";
        }
    }
    class Hattu: Vaate
    {
        public int LampoKerroin { get; set; }
        public Hattu(string nimi, int lk):base(nimi){ LampoKerroin = lk; }
        public override void Pue(Vartalo body)
        {
            body.Pukeudun(this);
        }
        public override string ToString()
        {
            return "Hattu";
        }
    }
    class Paita :Vaate
    {
        public Paita(string nimi):base(nimi){ }
        public override void Pue(Vartalo body)
        {
            body.Pukeudun(this);
        }
        public override string ToString()
        {
            return "Paita";
        }
    }
    class Housut : Vaate
    {
        public Housut(string nimi):base(nimi){ }
        public override void Pue(Vartalo body)
        {
            body.Pukeudun(this);
        }
        public override string ToString()
        {
            return "Housut";
        }
    }
    class Kengat : Vaate
    {
        public Kengat(string nimi):base(nimi){ }
        public override void Pue(Vartalo body)
        {
            body.Pukeudun(this);
        }
        public override string ToString()
        {
            return "Kengat";
        }
    }
}
