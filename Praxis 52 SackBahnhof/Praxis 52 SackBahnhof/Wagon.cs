using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_52_SackBahnhof
{
    internal class Wagon
    {
        private string zielBahnhof;

        public string ZielBahnhof
        {
            get { return zielBahnhof; }
            set { zielBahnhof = value; }
        }

        public Wagon(string zielbahnhof)
        {
            this.zielBahnhof = zielbahnhof;
        }
        public override string ToString()
        {
            return $"Wagon = [ ZielBahnhof = {zielBahnhof}]";
        }

    }
}
