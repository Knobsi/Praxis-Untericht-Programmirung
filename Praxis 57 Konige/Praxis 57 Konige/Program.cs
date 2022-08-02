using System;

namespace Praxis_57_Konige
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koenig koenig = new Koenig(1000000);
            Adel adel1 = new Adel(30000);
            Adel adel2 = new Adel(150);
            Bauer bauer = new Bauer(2000);
            Leibeigener leibeigener = new Leibeigener(150);
            Leibeigener leibeigener1 = new Leibeigener(5);

            
            Console.WriteLine(koenig);
            Console.WriteLine(adel1);
            Console.WriteLine(adel2);
            Console.WriteLine(bauer);
            Console.WriteLine(leibeigener);
            Console.WriteLine(leibeigener1);


            Console.WriteLine(Finanzsam.BerechneSteuerEinahmen(new Einwohner[] {koenig,adel1,adel2,bauer,leibeigener,leibeigener1}));
            
        }
    }
}
