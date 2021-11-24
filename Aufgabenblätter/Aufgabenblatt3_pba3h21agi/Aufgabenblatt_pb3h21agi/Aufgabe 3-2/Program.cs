// Autor : Leon.Gießelmann
using System;

namespace Aufgabe_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aufgabe a

            int temp1;
            int temp2;
            int temp3;

            Console.Write("Gib bitte die erste zahl ein");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gib nun bitte die zweite zahl ein");
            int b = Convert.ToInt32(Console.ReadLine());

            //if (a > b)
            //{
            //    temp = a;
            //    b = a;
            //    a = temp;
            //}

            Console.WriteLine($"der kleinere wert ist {a} groß und der größere wert ist {b} groß");

            #endregion

            #region Aufgabe b


            Console.Write("Nun fügen wir noch eine dritte zahl hinzu");
            int c = Convert.ToInt32(Console.ReadLine());

            temp1 = a;
            temp2 = b;
            temp3 = c;

            if(a > b || a > c)
            {
                if(a > c)
                {

                    temp1 = c;
                    c = a;
                    a = temp1;

                }
                temp1 = b;
                b = a;
                a = temp1;

            }
            if(b > c || b > a)
            {
                if(b > c)
                {
                    temp1 = c;
                    c = b;
                    b = temp1;
                }
                temp1 = a;
                a = b;
                b = temp1;

            }
            if(a > b || a > c)
            {

                if(a > b )
                {

                    temp1 = b;
                    b = a;
                    a = temp1;

                }

                temp1 = c;
                c = a;
                a = temp1;
            }

             
            Console.WriteLine($"Der wert kleinste wert ist {c} danch in der mitte ist {b} und der größte ist {a}");


            #endregion

        }
    }
}
