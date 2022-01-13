using System;

namespace Praxis_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ggt = BerechneGGT(35, 49);
            int kgv = BerechneKGV(35, 49);
            Console.WriteLine($" der GGT ist {ggt} und der KGV ist {kgv}");
        }
        public static int BerechneGGT(int a,int b)
        {
            int ergebnis = 0;

            if(a == 0)
            {
                ergebnis = b;
            }
            else
            {
                while (b != 0)
                {

                    if (a > b)
                    {
                        a = a - b;

                    }
                    else
                    {
                        b = b - a;
                    }
                }
                ergebnis = a;
                
            }

            return ergebnis;
        }
        public static int BerechneKGV(int a,int b)
        {
            int ergebnis = 0;
            int ggt = BerechneGGT(a, b);

            ergebnis = a * b / ggt;

            return ergebnis;
        }
    }
}
