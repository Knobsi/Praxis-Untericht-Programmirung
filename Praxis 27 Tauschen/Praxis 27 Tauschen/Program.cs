using System;
using System.Linq;

namespace Praxis_27_Tauschen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            Swap(array, 0, 9);
            Swap(array, 5, 8);
            Swap(array, 2, 7);
            Swap(array, 3, 4);
            Swap(array, 7, 2);
            Swap(array, 9, 3);

            Console.WriteLine(String.Join("|", array));

            #region AndereLösung
            //int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Random rnd = new Random();
            //array2 = array2.OrderBy(x => rnd.Next()).ToArray();
            //Console.WriteLine(String.Join("|", array2));
            #endregion

        }
        public static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
