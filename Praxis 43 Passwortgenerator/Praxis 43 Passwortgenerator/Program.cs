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
            if(bearbeitung.Length < 8)
            {
                foreach (string item in bearbeitung)
                {
                    
                    rueckgabe += item.Substring(0,2);
                    laenge++;

                    char[] test = new char[item.Length];
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
                    }
                }
            }
            else
            {
                foreach (string item in bearbeitung)
                {

                    rueckgabe += item.Substring(0,1);
                    laenge++;

                    char[] test = new char[item.Length];
                    foreach (char c in test)
                    {
                        if(c == '.')
                            rueckgabe += ".";
                        else if(c ==',')
                            rueckgabe += ",";
                        else if(c =='-')
                            rueckgabe += "-";
                        else if(c =='!')
                            rueckgabe += "!";
                        else if (c == '?')
                            rueckgabe += "?";
                    }
                }
            }
            rueckgabe += Convert.ToString(laenge);
            return rueckgabe;
        }
    }
}
