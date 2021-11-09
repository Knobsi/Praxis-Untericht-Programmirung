using System;

namespace Praxis_10_Unicode_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Aufforderung der eingabe
            Console.Write("Bitte geben sie eine zahl ein die sie in ein zeichen umwandeln wollen ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            // Convertierung der zahl in ein char
            char zeichen = Convert.ToChar(zahl1);

            // Ausgabe des zeichens 
            Console.WriteLine($"Dein zeichen was aus der zahl {zahl1} geworden ist ist das zeichen {zeichen}");


            //Drei zeilen
            int zahl = Convert.ToInt32(Console.ReadLine());
            char charZahl = Convert.ToChar(zahl);
            Console.WriteLine(charZahl);


            //Zwei zeilen
            char baum = Convert.ToChar(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(baum);

            //Eine zeile 
            Console.WriteLine(Convert.ToChar(Convert.ToInt32(Console.ReadLine())));
        

        }
    }
}
