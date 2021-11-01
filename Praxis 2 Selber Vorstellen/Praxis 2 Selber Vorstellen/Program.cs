using System;

namespace Praxis_2_Selber_Vorstellen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hallo wilkommen zur Steckbrieferstellung Ich Frage dich ein paar daten und Gebe sie dir dan als Steckbrief wieder aus Okay Dan lass uns starten");

            Console.WriteLine("Nun wie ist dein Name");
            string name =Console.ReadLine();

            Console.WriteLine("Wie ist dein alter");
            string age = Console.ReadLine();

            Console.WriteLine("Wie heißt deine Straße");
            string stret = Console.ReadLine();

            Console.WriteLine("Wie heißt dein Wohnort");
            string country = Console.ReadLine();

            Console.WriteLine("Wie heißen deine Hobbys");
            string Hobbys = Console.ReadLine();

            Console.WriteLine("Okay Ich fasse einmal zusammen");


            Console.WriteLine( "Name     "   +  name   + "\n"+ 
                               "Alter    "   +  age    + "\n" +
                               "Straße   "   + stret   + "\n" +
                               "Stat     "   + country + "\n" +
                               "Hobbys   "   + Hobbys);





        }
    }
}
