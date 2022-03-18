using System;

namespace Praxis_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int durchschnitt = 0;
            string[] tage = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag" };
            int[] streckeInKm = { 134, 177, 123, 145, 152 };
            int[] fahrzeitInMin = { 95, 230, 115, 110, 125 };
            double[] geschwindigkeitInKmH = new double[streckeInKm.Length];

            for (int i = 0; i < streckeInKm.Length; i++)
            {
                geschwindigkeitInKmH[i] = streckeInKm[i] / (Convert.ToDouble(fahrzeitInMin[i]) / 60);
            }
            foreach (int i in geschwindigkeitInKmH)
            {
                durchschnitt += i;
            }
            durchschnitt /= geschwindigkeitInKmH.Length;
            for (int i = 0; i < geschwindigkeitInKmH.Length; i++)
            {
                Console.WriteLine($"An tag {tage[i]:F} ist er mit {geschwindigkeitInKmH[i]:F} km/h gefahren");
            }
            Console.WriteLine($"Die durchschnitsgeschwindigkeit ist {durchschnitt:F}");
        }
    }
}
