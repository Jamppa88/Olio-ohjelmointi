using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Toteuta sovellus, jolla voidaan käsitellä erilaisia kuviota(esim.Circle ja Rectangle). 
 * Laadi erillinen abstrakti Shape-luokka, josta muut kuviot peryityvät.
 * Määrittele Shape-luokan ominaisuutena kuvion nimi (Name) ja abstraktit Area- ja Circumference-metodit(pinta-ala ja ympärysmitta). 
 * Peri Circle- ja Rectangle-luokat Shape-luokasta ja toteuta Area- ja Circumference-metodit.
 * Luo Shapes-luokka ja sen sisälle List-tietorakenne, jonne voit aina lisätä kuvioita.
 * Toteuta pääohjelma, jossa käytät Shapes-luokkaa, luo muutamia eri kuviota ja lisää ne Shapes-luokassa olevaan List-tietorakenteeseen.
 * Käy pääohjelmassa lopuksi läpi Shapes-luokan List-tietorakenne ja tulosta kaikki sen sisältämät kuviot.
 */

namespace JAMK.IT
{
    abstract class Shape
    {
        public string Name { get; set; }
        abstract public double Circumference();
        abstract public double Area();
    }
    class Circle: Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
        public override double Circumference()
        {
            return Radius * 2 * Math.PI;
        }
        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }
    }
    class Rectangle: Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
        public override double Circumference()
        {
            return 2 * (Width + Height);
        }
        public Rectangle(string name, double height, double width)
        {
            Name = name;
            Height = height;
            Width = width;
        }
    }
    class Shapes
    {
        public List<Shape> Kuviot = new List<Shape>(); 
    }
}
