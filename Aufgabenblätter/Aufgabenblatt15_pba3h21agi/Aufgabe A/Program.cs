using System;
using System.Collections.Generic;

namespace Aufgabe_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rennschnecke rs1 = new Rennschnecke("Turbo", Schneckenart.Stahlheml_Renschnecke, 12);
            Rennschnecke rs2 = new Rennschnecke("Batman", Schneckenart.Batman_Renschnecke, 10);
            Rennschnecke rs3 = new Rennschnecke("Schleimie", Schneckenart.Mosaik_Renschnecke, 11);
            Rennschnecke rs4 = new Rennschnecke("Ringel", Schneckenart.Ring_Renschnecke, 9);
            Rennschnecke rs5 = new Rennschnecke("Brownie", Schneckenart.Braune_Renschnecke, 8);
            Rennschnecke rs6 = new Rennschnecke("Roter Blitz", Schneckenart.Rote_Renschnecke, 13);

            List<Rennschnecke> rennen = new List<Rennschnecke>();
            rennen.Add(rs1);
            rennen.Add(rs2);
            rennen.Add(rs3);
            rennen.Add(rs4);
            rennen.Add(rs5);
            rennen.Add(rs6);

            Console.WriteLine(String.Join("|",rennen));

            for (int i = 0; i < 100; i++)
            {
                foreach (Rennschnecke rennschnecke in rennen)
                {
                    rennschnecke.Kriechen();
                }
            }

            Console.WriteLine(String.Join("|", rennen));
        }
    }
}
