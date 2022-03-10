using System;

namespace Praxis_32_kopieren_und_vergleichen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] toCopy = {1,5,2,6,8,2,4,2,5,8,9,3,4,4};
            int[] fromCopy = Copy(toCopy);

            Console.WriteLine(String.Join("|", fromCopy));
            fromCopy[2] = 20;
            Console.WriteLine(String.Join("|", fromCopy));
        }
        public static int[] Copy(int[] array)
        {
            int[] backCopy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                backCopy[i] = array[i];
            }
            return backCopy;
        }
    }
}
