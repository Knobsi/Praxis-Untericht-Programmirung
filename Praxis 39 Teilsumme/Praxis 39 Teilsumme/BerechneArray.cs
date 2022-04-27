using System;
using System.Collections.Generic;
using System.Text;

namespace Praxis_39_Teilsumme
{
    internal class BerechneArray
    {

        public static double SubSum(double[] array, int startIndex,int endIndex)
        {
            if(startIndex < 0 || startIndex < endIndex || endIndex > array.Length)
            {
                Console.WriteLine($"Summe der Elemente von {startIndex} bis {endIndex}: n.def.");
                return 0;
            }
            else
            {
                double sum = 0;

                for (double i = array[startIndex]; i < array[endIndex]; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"Summe der Elemente von {startIndex} bis {endIndex}: {sum}");
                return sum;
            }
            
        }


    }
}
