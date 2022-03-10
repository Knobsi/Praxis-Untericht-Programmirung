using System;

namespace praxis_31_Array_Algorythmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, -45, 223, 12, 15, 78 };

            double mittelWert = BerechneMittelwert(array);
            Console.WriteLine("Mittelwert "+mittelWert);
        }
        static double BerechneMittelwert(int[] array)
        {
            double mittelWert = 0;

            for (int i = 0; i < array.Length; i++)
            {
                mittelWert += array[i];
            }
            mittelWert /= array.Length;
            return mittelWert;
        }

    }
}
