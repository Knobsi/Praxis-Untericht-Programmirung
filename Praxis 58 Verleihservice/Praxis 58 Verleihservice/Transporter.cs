using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_58_Verleihservice
{
    internal class Transporter : Leihfarzeug
    {
        private double zugelassenesGesamtgewicht;

       

        public double ZugelassenesGesamtgewicht
        {
            get { return zugelassenesGesamtgewicht; }
            set { zugelassenesGesamtgewicht = value; }
        }

        public Transporter(string fahrzeugID, string bezeichnung, double mittarifProTag, double versicherungspauschale, double zugelassenesGesamtgewicht) 
            : base(fahrzeugID, bezeichnung, mittarifProTag, versicherungspauschale)
        {
            ZugelassenesGesamtgewicht=zugelassenesGesamtgewicht;
        }

        public override Fuehrerschein BenoetigterFuehrerschein()
        {
            if(zugelassenesGesamtgewicht >= 3.5)
            {
                return Fuehrerschein.C_Klasse_LKW;
            }
            return base.BenoetigterFuehrerschein(); //oder : Fuehrerschein.B_Klasse_PKW
        }
        public override string ToString()
        {
            return $"Transporter [FahrzeugID={FahrzeugID}, bezeichnung={Bezeichnung}, mittarifProTag={MittarifProTag} Euro, versicherungspauschale={Versicherungspauschale}, zugelassenesGesamtgewicht={ZugelassenesGesamtgewicht}]";
        }
    }
}
