using System;
using System.Globalization;

namespace Praxis_48_DateTime_und_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            //Heutiges datum 
            Console.WriteLine(dateTime.ToString("d"));

            //Aktueler zeitpunkt
            Console.WriteLine(dateTime.ToString("T"));

            //Begin der ausbildung
            Console.WriteLine(DateTime.Parse("04.10.2021 08:00"));

            //Mein Geburtsdatum
            Console.WriteLine(DateTime.Parse("25.04.2002"));
            
            //Zeitspanne zwischen dem begin der ausbildung und heute

            TimeSpan dateTime2 = DateTime.Parse("04.10.2021 08:00") - DateTime.Now;
            Console.WriteLine(dateTime2);

            //Welcher wochentag ist heute
            Console.WriteLine(dateTime.ToString("dddd"));

            //Wie viele tage sind dieses jahr schon vergangen
            int a = 365 - DateTime.Now.DayOfYear;
            Console.WriteLine(a);

            //Seit was ist der ukraine krieg
            dateTime2 = DateTime.Parse("24.02.2022") - DateTime.Now;
            Console.WriteLine(dateTime2);

            //Wieviele stunden seit ausbildungsbeginn
            dateTime2 = DateTime.Parse("24.02.2022 08:00") - DateTime.Now;
            Console.WriteLine(dateTime2);

            //Ist ihr geburtsjahr ein schaltjahr
            if (DateTime.IsLeapYear(2002))
            {
                Console.WriteLine("2002 is nen schaltjahr");
            }

            //Wieviele stunde seit geburt
            dateTime2 = DateTime.Parse("25.04.2002") - DateTime.Now;
            Console.WriteLine(dateTime2);

            //
            Console.WriteLine(DateTime.Parse("10.05.2020"));
            Console.WriteLine(DateTime.Parse("11:30"));
            Console.WriteLine(DateTime.Parse("10.05.2020 21:00"));
            Console.WriteLine(DateTime.Parse("0:10:30"));


            DateTime date1 = new DateTime(2017, 2, 29, 6, 30, 15);

            Console.WriteLine(DateTime.ParseExact("29.02.2018","d,MM",null));

        }
    }
}
