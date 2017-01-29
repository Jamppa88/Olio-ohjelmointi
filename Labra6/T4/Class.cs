
using System.Collections.Generic;

/* Toteuta ohjelma, jolla voidaan lisätä, poistaa ja listata SM-Liiga-joukkueen JYP pelaajia. 
 * Luo Pelaaja-luokka jolla on ominaisuudet Etunimi, Sukunimi, Ikä ja Numero. Löydät täältä JYP pelaajat kaudella 2016-17. 
 * Luo myös Joukkue-luokka. Luokalla on ominnaisuudet Nimi, Kotikaupunki ja Pelaajat. Ominaisuus Pelaajat on siis lista Pelaaja-olioita. 
 * Tee Joukkue-luokalle sisäinen metodi HaePelaajat(string joukkue), jota konstruktori kutsuu. 
 * HaePelaajat metodi luo Pelaajat-listaan oikeat pelaajat.
 * Bonustehtävä: missä ja miten pitäisi pelaajatietoja silloin tallessa kun ohjelma ei ole käynnissä? 
 * Listaa erilaiset vaihtoehdot. Toteuta niistä tekstitiedosto-pohjainen ratkaisu.

 */

namespace JAMK_IT
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ika { get; set; }
        public int Numero { get; set; }
        public Pelaaja() { }
        public Pelaaja(string enimi, string snimi, int ika, int numero)
        {
            Etunimi = enimi;
            Sukunimi = snimi;
            Ika = ika;
            Numero = numero;
        }
    }
    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki{ get; set; }
        public List<Pelaaja> Pelaajat = new List<Pelaaja>();

        private void HaePelaajat(string joukkue)
        {
            if (joukkue == "JYP")
            {
                Pelaaja peluri = new Pelaaja("Juho","Olkinuora",26,45);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Markus", "Ruusu", 19, 97);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Pekka", "Tuokkola", 33, 83);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Olli", "Aitola", 24, 60);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Joona", "Erving", 22, 53);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Niklas", "Friman", 23, 20);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Jaakko", "Jokinen", 23, 16);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Mikko", "Kalteva", 32, 7);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Mikko", "Kuukka", 31, 91);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Kai", "Lehtinen", 26, 59);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Alex", "Lindroos", 21, 34);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Sami", "Niku", 20, 8);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Juha", "Uotila", 32, 11);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Urho", "Vaakanainen", 18, 13);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Juuso", "Vainio", 22, 5);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Nolan", "Yonkman", 35, 43);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Valtteri", "Hotakainen", 26, 21);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Juha-Pekka", "Hytönen", 35, 15);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Henri", "Kanninen", 22, 71);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Janne", "Kolehmainen", 30, 55);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Arttu", "Likola", 22, 41);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Ossi", "Louhivaara", 33, 23);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Anssi", "Löfman", 29, 25);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Michel", "Miklik", 34, 18);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Joonas", "Nättinen", 26, 9);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Tuomas", "Pihlman", 34, 49);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Robert", "Rooba", 23, 88);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Micke", "Saari", 22, 40);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Mikko", "Salmio", 25, 33);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Joel", "Sund", 23, 29);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Antti", "Suomela", 22, 14);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Janne", "Tavi", 27, 22);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Riku", "Tiainen", 21, 81);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Jani", "Tuppurainen", 36, 12);
                this.Pelaajat.Add(peluri);
                peluri = new Pelaaja("Jerry", "Turkulainen", 18, 32);
                this.Pelaajat.Add(peluri);
            }
        }
        public Joukkue(string nimi, string kaupunki)
        {
            Nimi = nimi;
            Kotikaupunki = kaupunki;
            HaePelaajat(nimi);
        }
    }
}
