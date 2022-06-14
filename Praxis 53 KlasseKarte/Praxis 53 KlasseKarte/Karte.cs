using System;

namespace Praxis_53_KlasseKarte
{
    internal class Karte
    {
        private Farbe farbe;

        public Farbe Farbe
        {
            get { return farbe; }
            set { farbe = value; }
        }
        private Kartenwert wert;

        public Kartenwert Wert
        {
            get { return wert; }
            set { wert = value; }
        }

        public Karte(Farbe farbe,Kartenwert wert)
        {
            this.farbe = farbe;
            this.wert = wert;
        }
        public bool IstTrumpf(Spielvariante sv)
        {
            bool isTrumpf = false;
            if(wert == Kartenwert.B)
            {
                switch (sv)
                {
                    case Spielvariante.Kreuzspiel:

                        if (farbe == Farbe.Kreuz)
                        {
                            isTrumpf = true;
                        }

                        break;
                    case Spielvariante.Pikspiel:

                        if (farbe == Farbe.Pik)
                        {
                            isTrumpf = true;
                        }

                        break;
                    case Spielvariante.Herzspiel:

                        if (farbe == Farbe.Herz)
                        {
                            isTrumpf = true;
                        }

                        break;
                    case Spielvariante.Karospiel:

                        if (farbe == Farbe.Karo)
                        {
                            isTrumpf = true;
                        }

                        break;
                }
            }
            
            return isTrumpf;
        }
        public int VergleicheMit(Karte k,Spielvariante sv)
        {
            if(this.Wert > k.Wert || this.farbe > k.farbe && this.Wert > k.Wert)
            {
                Console.WriteLine("Die vorhandee karte ist besser");
                return 1;
            }
            else if (this.Wert == k.Wert && this.farbe == k.farbe)
            {
                Console.WriteLine("Die vorhandee karte ist gleich");
                return 0;
            }
            else if (this.Wert < k.Wert || this.farbe < k.farbe && this.Wert < k.Wert)
            {
                Console.WriteLine("Die vorhandee karte ist schlechter");
                return -1;
            }
            return 0;
        }
        public override string ToString()
        {
            return $"Karte = [Farbe = {farbe} Kartenwert = {wert}";
        }

    }
}
