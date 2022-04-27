using System;

namespace Praxis_39_Teilsumme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr1;
            Random random = new Random();

            arr1 = new double[15];
            for (int i = 0; i <arr1.Length; i++)
            {
                arr1[i] = random.NextDouble();
            }
            BerechneArray.SubSum(arr1, 5, 10);
        }
    }
}
