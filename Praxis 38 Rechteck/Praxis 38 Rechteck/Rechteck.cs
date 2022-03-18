using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_38_Rechteck
{
    internal class Rechteck
    {
        private double breite;
        public double Breite
        {
            get { return breite; }
            set { 
                if(value <= 0)
                {
                    throw new ArgumentException("Breite muss größer als 0 sein");
                }
                
                breite = value; }
        }
        private double laenge;
        public double Laenge
        {
            get { return laenge; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Länge muss größer als 0 sein");
                }

                laenge = value;
            }
        }

        public Rechteck(double breite, double laenge)
        {
            this.breite = breite;
            this.laenge = laenge;
        }
        public Rechteck(double seite)
        {
            breite=seite;
            laenge=seite;
        }
        public double BerechneFlaeche()
        {
            double flaeche = breite * laenge;
            return flaeche;
        }
        public double BerechneUmfang()
        {
            double umfang = (2* breite) +(2*laenge);
            return umfang;
        }
        public double BerechneDiagonale()
        {
            double diagonale = Math.Sqrt(Math.Pow(laenge,2)+ Math.Pow(breite,2));
            return diagonale;
        }
        public override string ToString()
        {
            return ($"Rechteck[breite={breite:F} Länge={laenge:F}]");
        }
    }
}
