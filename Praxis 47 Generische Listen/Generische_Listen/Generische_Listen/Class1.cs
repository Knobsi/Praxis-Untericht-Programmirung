using System;
using System.Collections.Generic;
using System.Text;

namespace Generische_Listen
{
    internal class Pizza
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int anzahlZutaten;
        public int AnzahlZutaten
        {
            get { return anzahlZutaten; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Anzahl Zutaten muss mindestens 1 sein");
                else
                    anzahlZutaten = value;
            }
        }

        private double preis;
        public double Preis
        {
            get { return preis; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Preis darf nicht negativ sein");
                else
                    preis = value;
            }
        }

        public Pizza(string name, int anzahlZutaten, double preis)
        {
            Name = name;
            AnzahlZutaten = anzahlZutaten;
            Preis = preis;
        }

        public double BerechneMiniPreis()
        {
            double preis = Math.Round(Preis * 0.7, 1);

            return preis;
        }

        public double BerechneMaxiPreis()
        {
            double preis = Math.Round(Preis * 1.45, 1);
            return preis;
        }

        public override string ToString()
        {
            return Name + " " + AnzahlZutaten + " " + Preis;
        }
    }
}
