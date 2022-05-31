using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_44
{
    internal class Artikel
    {
        int artikelNr;
        int lagerBestand;
        double preis;

        string bezeichner;
        string kategorie;
        string farbe;

        public Artikel(int artikelNr, int lagerBestand, double preis, string bezeichner, string kategorie, string farbe)
        {
            this.artikelNr = artikelNr;
            this.lagerBestand = lagerBestand;
            this.preis = preis;
            this.bezeichner = bezeichner;
            this.kategorie = kategorie;
            this.farbe = farbe;
        }

        public override string ToString()
        {
            return ($"{artikelNr}{lagerBestand}{preis}{bezeichner}{kategorie}{farbe}");
        }
    }
}
