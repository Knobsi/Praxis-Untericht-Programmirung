using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zusammen = 0;

            Console.Write("Größe des Arrays? : ");
            int arrayGroeße = Convert.ToInt32(Console.ReadLine());

            int[] arrray = new int[arrayGroeße];

            for (int i = 0; i < arrray.Length; i++)
            {
                Console.WriteLine($"Welche zahl kommen in den {i +1}ten Array :");
                arrray[i] = Convert.ToInt32(Console.ReadLine());
                zusammen += arrray[i];
            }

            #region for-schleife
            for (int i = 0; i < arrray.Length; i++)
            {
                Console.Write(arrray[i] + " | ");
            }
            #endregion

            Console.WriteLine(" \n");

            #region forech
            foreach(int i in arrray)
            {
                Console.Write(i + " | ");
            }
            #endregion

            Console.WriteLine(" \n");

            Console.WriteLine("Zusammen ergibt der Array :"+zusammen);


        }
    }
}
