using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_58_Verleihservice
{
    internal class Baumaschine : Leihfarzeug
    {
        private double mittarifProStunde;

        public double MittarifProStunde
        {
            get { return mittarifProStunde; }
            set { mittarifProStunde = value; }
        }


        private bool liferservice;

        public bool Liferservice
        {
            get { return liferservice; }
            set { liferservice = value; }
        }


        public Baumaschine(string fahrzeugID, string bezeichnung, double mittarifProTag, double versicherungspauschale, double mittarifProStunde, bool liferservice)
                            : base(fahrzeugID, bezeichnung, mittarifProTag, versicherungspauschale)
        {
            Liferservice = liferservice;
            MittarifProStunde = mittarifProStunde;
        }

        public override double BerechneMitpreis(TimeSpan dauer)
        {
            double mitpreis = 0;

            double hours = dauer.TotalHours;
            if (liferservice)
            {
                mitpreis += 100;
            }
            if(hours < 8)
            {
                mitpreis += mittarifProStunde * hours;
            }
            else
            {
                return mitpreis = base.BerechneMitpreis(dauer);
            }
            return mitpreis;
        }

        public override string ToString()
        {
            return $"Transporter [FahrzeugID={FahrzeugID}, bezeichnung={Bezeichnung}, mittarifProTag={MittarifProTag} Euro, versicherungspauschale={Versicherungspauschale}]";
        }
    }
}
