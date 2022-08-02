using System;

namespace Praxis_57_Konige
{
    internal class Einwohner
    {
        private int einkommen;

        public int Einkommen
        {
            get { return einkommen; }
            set { 
                if(value >= 0)
                {
                    einkommen = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Einkommen zu klein");
                }
                }
        }

        public Einwohner (int einkommen)
        {
            this.einkommen = einkommen;
        }

        public int ZuVersteuerndesEinkommen()
        {
            return einkommen;
        }
        public virtual int Steuern()
        {
            double rückgabe = 0;
            rückgabe = ZuVersteuerndesEinkommen() / 10;

            if (rückgabe < 1)
            {
                return 1;
            }
            else
            {
                return (int)Math.Floor(rückgabe);
            }
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}[Einkommen = {Einkommen},ZuVersteuerndesEinkommen()= {ZuVersteuerndesEinkommen()} Stuer = {Steuern()}]";
        }
    }
}
