using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_57_Konige
{
    internal class Koenig : Einwohner
    {
        public Koenig(int einkommen) : base(einkommen)
        {

        }
        public override int Steuern()
        {
            return 0;
        }
    }
}
