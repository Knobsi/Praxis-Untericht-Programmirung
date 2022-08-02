using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_58_Verleihservice
{
    public class Leihfarzeug
    {
        #region Atribute und propertis
        private string farzeugID;

        public string FahrzeugID
        {
            get { return farzeugID; }
            set { farzeugID = value; }
        }

        private string bezeichnung;

        public string Bezeichnung
        {
            get { return bezeichnung; }
            set { bezeichnung = value; }
        }
        private double mittarifProTag;

        public double MittarifProTag
        {
            get { return mittarifProTag; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Miete muss größer als 0 sein");
                }
                else
                {
                    mittarifProTag = value;
                }
            }
        }
        private double versicherungspauschale;

        public double Versicherungspauschale
        {
            get { return versicherungspauschale; }
            set { versicherungspauschale = value; }
        }
        #endregion

        public Leihfarzeug(string fahrzeugID, string bezeichnung, double mittarifProTag, double versicherungspauschale)
        {
            FahrzeugID = fahrzeugID;
            Bezeichnung = bezeichnung;
            MittarifProTag = mittarifProTag;
            Versicherungspauschale = versicherungspauschale;
        }
        public virtual double BerechneMitpreis(TimeSpan dauer)
        {
            int anzahlTage = (int)Math.Ceiling(dauer.TotalDays); // Ab einer sec ist der tag überschritten

            /*
             int anzahlTage = dauer.TotalHouers / 24;           //Ab einer stunde ist der tag überschritten
            if(Totaldauer.Houser % 24 != 0
            {
            anzahlTage++;
            }
             */

            return anzahlTage * MittarifProTag + versicherungspauschale; 

        }
        public virtual Fuehrerschein BenoetigterFuehrerschein()
        {
            return Fuehrerschein.B_Klasse_PKW;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
