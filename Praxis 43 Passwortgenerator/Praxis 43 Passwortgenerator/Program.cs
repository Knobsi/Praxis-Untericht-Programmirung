using System;

namespace Praxis_43_Passwortgenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie bitte einen satz ein der zur erstellung ihres passwortes dient");
            string satzFuerPasswort = Console.ReadLine();
            string satzPasswort = GenerierePWAusSatz(satzFuerPasswort);
            Console.WriteLine(satzPasswort);

        }
        public static string GenerierePWAusSatz(string satz)
        {
            string rueckgabe = "";
            string[] bearbeitung = satz.Split(" ");
            int laenge = 0;

            int bustabenZahl = 1;

            if (bearbeitung.Length < 8)
                bustabenZahl = 2;
            else
                bustabenZahl = 1;

                foreach (string item in bearbeitung)
                {
                    
                    rueckgabe += item.Substring(0,bustabenZahl);

                    char[] test = new char[item.Length];
                    test = item.ToCharArray();
                    foreach(char c in test)
                    {
                        if (c == '.')
                            rueckgabe += ".";
                        else if (c == ',')
                            rueckgabe += ",";
                        else if (c == '-')
                            rueckgabe += "-";
                        else if (c == '!')
                            rueckgabe += "!";
                        else if (c == '?')
                            rueckgabe += "?";
                        laenge++;
                    }
                }
           
            
            rueckgabe += Convert.ToString(laenge);
            return rueckgabe;
        }
    }
}
