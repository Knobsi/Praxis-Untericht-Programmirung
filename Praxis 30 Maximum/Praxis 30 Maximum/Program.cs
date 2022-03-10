using System;

namespace Praxis_30_Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool pushNew = true;
            string charPush = "q";

            NewArrayPush();

            while (pushNew)
            {
                Console.WriteLine("Drücken sie Q zum Neustartn oder eine andere Taste zum abbruch");
                
                char nextTry = Convert.ToChar(Console.ReadLine());
                
                if(nextTry.ToString().ToLower() == charPush)
                {
                    NewArrayPush();
                }
                else
                    pushNew = false;
            }   
        }
        static int Maximum(int[] array)
        {
            int max = array[0];
            foreach ( int i in array)
            {
                if(max < i)
                    max = i;
            }
            return max;
        }
        static int Minimum(int[] array)
        {
            int min = array[0];
            foreach( int i in array)
            {
                if(min > i)
                    min = i;
            }
            return min;
        }
        static int Durchschnit(int[] array)
        {
            int durchschnit = 0;
            foreach (int i in array)
            {
                durchschnit += i;
            }
            durchschnit /= array.Length;
            return durchschnit;
        }
        static int Summe(int[] array)
        {
            int sum = 0;
            foreach( int i in array)
            {
                sum += i;
            }
            return sum;
        }
        static int IndexOfMaximum(int[] array)
        {
            int max = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            return index;
        }
        static int[] BubbleSort(int[] arr)
        {
            int[] toSort = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                toSort[i] = arr[i];
            }
            int temp;
            for (int j = 0; j <= toSort.Length - 2; j++)
            {
                for (int i = 0; i <= toSort.Length - 2; i++)
                {
                    if (toSort[i] > toSort[i + 1])
                    {
                        temp = toSort[i + 1];
                        toSort[i + 1] = toSort[i];
                        toSort[i] = temp;
                    }
                }
            }
            return toSort;
        }
        static int AlleMinusZusammen(int[] array)
        {
            int minus = 0;
            foreach (int  i in array)
            {
                if (i < 0)
                    minus -= i;
            }
            return minus;
        }
        static int AllePlusZusammen(int[] array)
        {
            int plus = 0;
            foreach (int i in array)
            {
                if (i > 0)
                    plus += i;
            }
            return plus;
        }

        static void NewArrayPush()
        {
            Console.Clear();
            int[] array = new int[20];
            Random rn = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rn.Next(-100, 101);
            }
            int max = Maximum(array);
            int min = Minimum(array);
            int durchschit = Durchschnit(array);
            int summe = Summe(array);
            int index = IndexOfMaximum(array);
            int[] arr = BubbleSort(array);
            int minusZusammen = AlleMinusZusammen(array);
            int plusZusammen = AllePlusZusammen(array);
            Console.WriteLine(string.Join("|", array));
            Console.WriteLine($"Die größte Zahl im array war die {max}");
            Console.WriteLine($"Der index von {max} war {index +1 }");
            Console.WriteLine($"Die kleinste Zahl im array war die {min}");
            Console.WriteLine($"Der Durchschnit ist {durchschit}");
            Console.WriteLine($"Die gesammtsumme ist {summe}");
            Console.WriteLine($"Die negativen zahlen zusammen sind {minusZusammen} und die positiven {plusZusammen}");
            Console.WriteLine($"Sortiert sähe der array so aus:");
            Console.WriteLine(string.Join("|", arr));
        }
    }
}
