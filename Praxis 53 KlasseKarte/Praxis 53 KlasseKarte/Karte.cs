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
        public int ErmittleSkatWert()
        {
            int rueckgabe = 0;
            switch (wert)
            {
                case Kartenwert.A:
                    rueckgabe = 11;
                    break;
                case Kartenwert.N10:
                    rueckgabe = 10;
                    break;
                case Kartenwert.K:
                    rueckgabe = 4;
                    break;
                case Kartenwert.D:
                    rueckgabe = 3;
                    break;
                case Kartenwert.B:
                    rueckgabe = 2;
                    break;
                case Kartenwert.N9:
                case Kartenwert.N8:
                case Kartenwert.N7:
                    rueckgabe = 0;
                    break;
            }
            return rueckgabe;
        }
        public bool Sticht(Karte k,Spielvariante sv)
        {
            bool rueckgabe = false;
            if(IstTrumpf(sv) && !k.IstTrumpf(sv))
            {
                rueckgabe=true;
            }
            else if(!IstTrumpf(sv) && k.IstTrumpf(sv))
            {
                rueckgabe = false;
            }
            else if (IstTrumpf(sv) && k.IstTrumpf(sv))
            {
                if(wert == KartenWert. && k.ErmittleSkatWert() != 2)
                {
                    rueckgabe = true;
                }
                else if(ErmittleSkatWert() != 2 && k.ErmittleSkatWert() == 2)
                {
                    rueckgabe = false;
                }
                else if(ErmittleSkatWert() == 2 && k.ErmittleSkatWert() == 2)
                {
                    if(farbe < k.farbe)
                    {
                        rueckgabe = true;
                    }
                    else
                    {
                        rueckgabe = false;
                    }
                }
                else
                {
                    if (wert < k.wert)
                    {
                        rueckgabe = true;
                    }
                    else
                    {
                        rueckgabe = false;
                    }
                }
            }
            else
            {
                if(wert < k.wert)
                {
                    rueckgabe = true;
                }
                else
                {
                    rueckgabe = false;
                }
            }

            return rueckgabe;
        }
        public override string ToString()
        {
            return $"Karte = [Farbe = {farbe} Kartenwert = {wert}";
        }

    }
}
