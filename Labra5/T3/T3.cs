using System;

/* Tehtävässä tulee toteuttaa muutamia luokkia, joiden avulla testataan abstraktien metodien toimivuutta.

Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, 
jonka toteutus on jätetty toteuttamatta (abstrakti metodi).

Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia (paino, pituus, nimi).
Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella. 
Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa

Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa". 
Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". Lisää aikuiselle ominaisuus auto (String). Lisää vauvalle ominaisuus vaippa (String).

Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille.

    */

namespace JAMK_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Vauva vauva = new Vauva();
            Aikuinen aikune = new Aikuinen();
            vauva.Nimi = "Venla";
            vauva.Ika = 1;
            vauva.Pituus = 50;
            vauva.Paino = 9;
            vauva.Vaippa = "Pampers";

            aikune.Nimi = "Pekka";
            aikune.Ika = 21;
            aikune.Paino = 89;
            aikune.Pituus = 190;
            aikune.Auto = "VW Passat";

            vauva.Liiku();
            Console.WriteLine(vauva.Ika);
            vauva.Kasva();
            Console.WriteLine(vauva.Ika);

            aikune.Liiku();
            Console.WriteLine(aikune.Ika);
            aikune.Kasva();
            Console.WriteLine(aikune.Ika);
        }
    }
}
