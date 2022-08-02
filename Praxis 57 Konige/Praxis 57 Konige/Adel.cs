using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_57_Konige
{
    internal class Adel : Einwohner
    {
        public Adel(int einkommen) : base(einkommen)
        {

        }
        public override int Steuern()
        {
            int steuer = base.Steuern();
            if(steuer < 20)
            {
                return 20;
            }
            else
            {
                return steuer;
            } 

        }
    }
}
