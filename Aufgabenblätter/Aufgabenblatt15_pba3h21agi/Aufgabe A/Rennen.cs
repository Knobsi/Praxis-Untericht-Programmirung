using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_A
{
    internal class Rennen
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        private Renndistanz distanz;

        public Renndistanz Distanz
        {
            get { return distanz; }
        }

        private int maxTeilnehmer;

        public int MaxTeilnehmer
        {
            get { return maxTeilnehmer; }
        }

        private List<Rennschnecke> teilnehmer;

        public List<Rennschnecke> Teilnehmer
        {
            get { return teilnehmer; }
        }

        public Rennen(string name, Renndistanz distanz, int maxTeilnehmer)
        {
            this.name = name;
            this.distanz = distanz;
            this.maxTeilnehmer = maxTeilnehmer;
            this.teilnehmer = new List<Rennschnecke>();
        }

        public bool AddRenschnecke(Rennschnecke neuerTeilnehmer)
        {
            if(neuerTeilnehmer != null)
            {
                if (NimmtTeil(neuerTeilnehmer.Name))
                {
                    return false;
                }
                if (teilnehmer.Count > maxTeilnehmer)
                {
                    return false;
                }
                teilnehmer.Add(neuerTeilnehmer);
                return true;
            }

            return false;
        }
        public bool NimmtTeil(string schneckenName)
        {
            foreach (Rennschnecke i in teilnehmer)
            {
                if(i.Name == schneckenName)
                {
                    return true;
                }
            }
            return false;
        }
        bool RemoveRenschnecke(string schneckenName)
        {
            for (int i = 0; i < teilnehmer.Count; i++)
            {
                if(teilnehmer[i].Name == schneckenName)
                {
                    teilnehmer.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public void LasseSchneckeKriechen()
        {
            foreach (Rennschnecke rennschnecke in teilnehmer)
            {
                rennschnecke.Kriechen();
            }
        }
        public Rennschnecke ErmittleGewinner()
        {
            if (AktuellSchnellsteSchnecke().Strecke >= Convert.ToInt32(distanz))
            {
                return AktuellSchnellsteSchnecke();
            }
            return null;
            
        }
        private Rennschnecke AktuellSchnellsteSchnecke()
        {
             
            teilnehmer.Sort(SortBySpeed);
            return teilnehmer[0];
        }

        private int SortBySpeed(Rennschnecke x, Rennschnecke y)
        {
            return x.Strecke.CompareTo(y.Strecke);
        }
        public Rennschnecke Durchführen()
        {
            while(ErmittleGewinner() == null)
            {
                LasseSchneckeKriechen();
            }
            foreach (Rennschnecke rennschnecke in teilnehmer)
            {
                rennschnecke.Strecke = 0;
            }
            return ErmittleGewinner();
        }

        public override string ToString()
        {
            return $"Rennen = [Name = {name}, distanz = {distanz} maxTeilnehmer= {maxTeilnehmer} teilnehmer = {string.Join("|", teilnehmer)}]";
        }

    }
}
