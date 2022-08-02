using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_57_Konige
{
    internal class Finanzsam
    {
        public static int BerechneSteuerEinahmen(Einwohner[] einwohner)
        {
            int rueckgabe = 0;
            foreach (Einwohner a in einwohner)
            {
                rueckgabe += a.Steuern();
            }
            return rueckgabe;
        }
    }
}
