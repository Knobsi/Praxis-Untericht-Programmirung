using System;

namespace Praxis_58_Verleihservice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baumaschine b1 = new Baumaschine("B20258", "Mobilbagger 17,5 t", 280, 30, 42, true);
            Baumaschine b2 = new Baumaschine("B20533", "Radlader 4,9 t", 157, 25, 25, false);

            Transporter t1 = new Transporter("T30124", "VW Transporter TS Pritschenwagen", 95, 32, 2.8);
            Transporter t2 = new Transporter("T31123", "Mercedes-Benz Atego Kipper", 215, 55, 7.5);

            Leihfarzeug[] leihfarzeugs = {b1,b2,t1,t2};

            foreach (var item in leihfarzeugs)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.BenoetigterFuehrerschein());
                Console.WriteLine(item.BerechneMitpreis(new TimeSpan(6,0,0)));
            }
        }
    }
}
