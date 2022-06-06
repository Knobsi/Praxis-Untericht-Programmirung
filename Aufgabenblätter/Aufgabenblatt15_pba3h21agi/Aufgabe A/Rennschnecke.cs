using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_A
{
    internal class Rennschnecke
    {
        private string name;

        public string Name
        {
            get { return name; }       }
        private Schneckenart art;

        public Schneckenart Art
        {
            get { return art; }
        }
        private int maxGeschwindigkeit;

        public int MaxGeschwindigkeit
        {
            get { return maxGeschwindigkeit; }
        }
        private int strecke = 0;
        private Random rn = new Random();

        public Rennschnecke(string name, Schneckenart art, int maxGeschwindigkeit)
        {
            this.name = name;
            this.art = art;
            this.maxGeschwindigkeit = maxGeschwindigkeit;
        }
        public void Kriechen()
        {
            strecke += rn.Next(0, maxGeschwindigkeit+1);
        }
        public override string ToString()
        {
            return $"Renschnecke = [name = {name}, art = {art}, maxGeschwindigkeit = {maxGeschwindigkeit}, strecke = {strecke}]";
        }
    }
}
