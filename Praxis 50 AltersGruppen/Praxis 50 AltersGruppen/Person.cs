using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_50_AltersGruppen
{
    internal class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Name war nicht gegeben");
                }
                else
                {
                    name = value;
                }
            }
        }


        private string vorname;

        public string Vorname
        {
            get { return vorname; }
            set
            { 
                if(value == null)
                {
                    throw new ArgumentNullException("Vorname war nicht gegeben");
                }
                else
                {
                    vorname = value;
                }
            }
        }

        private DateTime geburtsTag;

        public DateTime GeburtsTag
        {
            get { return geburtsTag; }
            set 
            {
                if(value > DateTime.Now)
                {
                    throw new ArgumentException("Datum in der Zukunft nicht möglich");
                }
                else if(value == null)
                {
                    throw new ArgumentException("Datum darf nicht null sein");
                }
                else
                {
                    geburtsTag = value;
                }
            }
        }

        public Person(string name, string vorname, DateTime geburtsTag)
        {
            Name = name;
            Vorname = vorname;
            GeburtsTag = geburtsTag;
        }

        public int BestimmeAlter()
        {
            int years = DateTime.Now.Year - geburtsTag.Year;
            //if (DateTime.Now <(geburtsTag.AddYears(years)))  { years--; }
            if(DateTime.Today.Month < geburtsTag.Month || DateTime.Today.Month == geburtsTag.Month && DateTime.Today.Day < geburtsTag.Day) { years--; }
            return years;
        }
        public AltersGruppe BestimmeAltersGruppe()
        {
            int alter = BestimmeAlter();
            AltersGruppe altersGruppe;

            if (alter >= 18)
            {
                altersGruppe = AltersGruppe.Erwachsener;
            }
            else if (alter >= 12)
            {
                altersGruppe = AltersGruppe.Jugentlicher;
            }
            else if (alter >= 3)
            {
                altersGruppe = AltersGruppe.Kind;
            }
            else if (alter >= 1)
            {
                altersGruppe = AltersGruppe.KleinKind;
            }
            else 
            {
                TimeSpan days = DateTime.Today - geburtsTag;
                if (days.Days > 28)
                {
                    altersGruppe = AltersGruppe.Säugling;
                }
                else
                {
                    altersGruppe = AltersGruppe.Neugeborenes;
                } 
            }
            return altersGruppe;
            
        }
        public override string ToString()
        {
            return $"Person = [name = {name}, vorname = {vorname}, Geburtstag = {geburtsTag.ToShortDateString()}]";
        }
    }
}
