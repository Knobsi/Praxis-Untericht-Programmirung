using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_34_Klasse_Luftballon
{
    internal class Luftballon
    {
        //Eigenschaften, felder, oder Atribute
        private string farbe;
        private string form;

        private double maxVolume;
        private double volume;

        private bool verknotet;

        public Luftballon(string farbe, string form, double maxVolume)
        {
            this.farbe = farbe;
            this.form = form;
            this.maxVolume = maxVolume;
        }

        public override string ToString()
        {
            return $" Luftballon {{{farbe} ist {form} und hat das maximal volumen {maxVolume} und hat derzeitig das volumen von {volume} und ist vernotet {verknotet}}}";
        }
    }
}
