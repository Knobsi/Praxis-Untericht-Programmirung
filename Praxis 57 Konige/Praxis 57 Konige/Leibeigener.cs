using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_57_Konige
{
    internal class Leibeigener : Bauer
    {
        public Leibeigener(int einkommen) : base(einkommen)
        {

        }
        public override int Steuern()
        {
            int zuVEk = base.ZuVersteuerndesEinkommen();
            if(zuVEk < 0)
            {
                return  0;
            }
            else
            {
                return  base.ZuVersteuerndesEinkommen() - 12;
            }
        }
    }
}
