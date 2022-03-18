using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_36_Klasse_Würfel
{
    internal class Wuerfel
    {
        private int[] seiten;

        public Wuerfel()
        {
            this.seiten = new int[]{ 1,2,3,4,5,6};
        }
        public Wuerfel(int[] seiten)
        {
            this.seiten = seiten;
        }
        public Wuerfel(int anzahlSeiten)
        {
            seiten = new int[anzahlSeiten];
            for (int i = 0; i < seiten.Length; i++)
            {
                seiten[i] = i + 1;
            }
        }

        public int Wuerfeln()
        {
            Random r = new Random();

            return seiten[r.Next(seiten.Length)];
        }

        public override string ToString()
        {
            return $"{{{string.Join("|", seiten)}}}";
        }

    }
}
