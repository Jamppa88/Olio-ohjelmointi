using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Tee ohjelma, jossa voidaan käsitellä TV-ohjelmia. TV-ohjelman tietoina tulee käsitellä: ohjelman nimi, kanava (jolta ohjelma tulee), 
 * alku- ja loppuaika sekä pienimuotoinen infoteksti ohjelmasta. 
 * Luo pääohjelmassa muutamia TV-ohjelmaolioita (tiedot voit alustaa suoraan koodista, ei tarvitse kysyä käyttäjältä) ja tallenna ne levylle. 
 * Mieti käytätkö jotain tietorakennetta apunasi. 
 * Toteuta ohjelmaan myös tiedostonlukeminen ja tulosta TV-oliot näkyville.
 */

namespace JAMK_IT
{
    class TVOhjelma
    {
        public string Nimi { get; set; }
        public string Kanava { get; set; }
        public int Alkuaika { get; set; }
        public int Loppuaika{ get; set; }
        public string InfoTeksti{ get; set; }
        public TVOhjelma() { }
        public TVOhjelma(string nimi, string kanava, int alku, int loppu, string kuvaus)
        {
            Nimi = nimi;
            Kanava = kanava;
            Alkuaika = alku;
            Loppuaika = loppu;
            InfoTeksti = kuvaus;
        }
    }
}
