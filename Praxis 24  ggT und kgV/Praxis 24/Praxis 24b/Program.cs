using System;

namespace Praxis_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ggt = BerechneGGT(35, 49);
            int kgv = BerechneKGV(35, 49);
            Console.WriteLine($"der GGT ist {ggt} und der KGV ist {kgv}");

            long ggt2 = BerechneGGT(35, 49);
            long kgv2 = BerechneKGV(35, 49);
            Console.WriteLine($"der GGT ist {ggt2} und der KGV ist {kgv2}");

            int ggt3 = BerechneGGT(35, 49, 63);
            int kgv3 = BerechneKGV(35, 49, 63);
            Console.WriteLine($"der GGT ist {ggt3} und der KGV ist {kgv3}");
        }
        #region 1
        public static int BerechneGGT(int a, int b)
        {
            int ergebnis = 0;

            if (a == 0)
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
        public static int BerechneKGV(int a, int b)
        {
            int ergebnis = 0;
            int ggt = BerechneGGT(a, b);

            ergebnis = a * b / ggt;

            return ergebnis;
        }
        #endregion
        #region 2
        public static long BerechneGGT(long a, long b)
        {
            long ergebnis = 0;

            if (a == 0)
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
        public static long BerechneKGV(long a, long b)
        {
            long ergebnis = 0;
            long ggt = BerechneGGT(a, b);

            ergebnis = a * b / ggt;

            return ergebnis;
        }
        #endregion
        #region 3
        public static int BerechneGGT(int a, int b, int c)
        {
            return BerechneGGT(BerechneGGT(a, b), c);
        }
        public static int BerechneKGV(int a, int b, int c)
        {
            return BerechneKGV(BerechneKGV(a, b), c);
            #endregion
        }
    }
}
