using System;

namespace Praxis_6_Umwandlung_Längeneinheiten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufforderung einer Eingabe
            Console.Write("Wieviele mm wollen sie umrechnen");
            int laenge = Convert.ToInt32(Console.ReadLine());


            //Berechnung der Eingabe
            int km = laenge / 1_000_000;
            int kmRest = laenge % 1000000;

            int m = kmRest / 1000;
            int mRest = kmRest % 1000;

            int cm = mRest / 10;
            int cmRest = mRest % 10;

            int mm = cmRest / 1;


            //Ausgabe der Eingabe
            Console.WriteLine("Deine angegebenen " + laenge + "mm sind " + km + "km und " + m + "m und " + cm + "cm und " + mm + "mm Lang");

            //Formatirte ausgabe mit Platzhalter
            Console.WriteLine("{0} entsprechen {1} km {2} m {3} cm {4} mm", laenge, km, m, cm, mm);

            //Formatierte Ausgabe mit Interpolationsausgabe
            Console.WriteLine($"{laenge} sind {km} km {m} m {cm} cm {mm} mm");

        }
    }
}
