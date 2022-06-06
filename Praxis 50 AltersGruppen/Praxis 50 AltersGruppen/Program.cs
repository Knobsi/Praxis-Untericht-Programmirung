using System;

namespace Praxis_50_AltersGruppen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person("Bobsen","Bob",new DateTime(2012,02,29));

            Console.WriteLine(bob.Vorname);
            Console.WriteLine(bob.Name);
            Console.WriteLine(bob.GeburtsTag.ToShortDateString());

            Console.WriteLine(bob);

            Console.WriteLine("Alter ist gleich = " + bob.BestimmeAlter());
            Console.WriteLine("Seine AltersGruppe ist = " +bob.BestimmeAltersGruppe());

            AltersGruppe groupX = bob.BestimmeAltersGruppe();
            switch (groupX)
            {
                case AltersGruppe.Neugeborenes:
                    break;
                case AltersGruppe.Säugling:
                    break;
                case AltersGruppe.KleinKind:
                    break;
                case AltersGruppe.Kind:
                    break;
                case AltersGruppe.Jugentlicher:
                    break;
                case AltersGruppe.Erwachsener:
                    break;
                default:
                    break;
            }

            int x = (int)groupX;
            Console.WriteLine(x);
        }
    }
}
