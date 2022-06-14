using System;
using System.Collections.Generic;

namespace Praxis_51_Wartezimmer
{
    internal class Program
    {
        static Queue<Patient> patients = new Queue<Patient>();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool programmRun = true;
            while (programmRun)
            {
                
                Console.WriteLine("Drücken sie die 1 um einen patienten hinzuzufügen die 2 um einen patienten zu suchen die 3 um die Warteschlange zu löschen die 4 um alle Patienten anzuzeigen und die 5 zum beenden dieses programms");
                string eingabe = Console.ReadLine();
                Console.Clear();
                if (eingabe == "1")
                {
                    CreateNewPatient();
                }
                else if(eingabe == "2")
                {
                    SearchPatient();
                }
                else if(eingabe == "3")
                {
                    DeletPatients();
                }
                else if(eingabe == "4")
                {
                    ShowPatients();
                }
                else if (eingabe == "5")
                {
                    programmRun = false;
                }
                else
                {
                    throw new Exception("Die eingabe war ungültig bitte passendes ergebnis eingeben");
                }
            }
        }
        static void CreateNewPatient()
        {
            Console.Write("Wie heißt die zu wartende person ? : ");
            patients.Enqueue(new Patient(Console.ReadLine()));
            Console.WriteLine("Patient hinzugefügt");
        }
        static void SearchPatient()
        {
            Console.WriteLine("Nach welchem Patient suchen sie ? : ");
            string name = Console.ReadLine();
            foreach (Patient item in patients)
            {
                if(item.Name == name)
                {
                    Console.WriteLine("Patient gibt es");
                    return;
                }
            }
            Console.WriteLine("Pattient gibt es nicht");
            
        }
        static void DeletPatients()
        {
            patients.Clear();
        }
        static void ShowPatients()
        {
            foreach (Patient item in patients)
            {
                Console.WriteLine(item);
            }
        }
    }
}
