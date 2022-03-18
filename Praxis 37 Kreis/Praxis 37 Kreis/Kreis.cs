using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_37_Kreis
{
    internal class Kreis
    {
        private double radius;

        public Kreis(double radius)
        {
            this.radius = radius;
        }

        public double BerechneFlaeche()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public double BerechneUmfang()
        {
            return 2 * Math.PI * radius;
        }
        public double BerechneDurchmesser()
        {
            return 2 * radius;
        }
        public override string ToString()
        {
            return radius.ToString();
        }
    }
}
