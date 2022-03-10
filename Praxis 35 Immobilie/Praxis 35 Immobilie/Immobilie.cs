using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_35_Immobilie
{
    internal class Immobilie
    {
        //atribute
        private string beschreibung;
        private double wohlflaeche;
        private int anzahlZimmer;
        private int baujahr;
        private double kaufpreis;
        private bool verkauft;

        public Immobilie(string beschreibung, double wohlflaeche, int anzahlZimmer, int baujahr, double kaufpreis,bool verkauft)
        {
            this.beschreibung = beschreibung;
            this.wohlflaeche = wohlflaeche;
            this.anzahlZimmer = anzahlZimmer;
            this.baujahr = baujahr;
            this.kaufpreis = kaufpreis;
            this.verkauft = verkauft;
        }
        public override string ToString()
        {
            return $"Haus {{ name :{beschreibung} wohnfläche :{wohlflaeche} Anzahl zimmer : {anzahlZimmer} Baujahr : {baujahr} Kaufpreis : {kaufpreis} Verkauft : {verkauft}}}";
        }
    }
}
