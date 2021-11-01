using System;

namespace Praxis_7_Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {

            //Deklaration und ausgabe von dateitypen
            //byte
            byte b1 = 113;
            Console.WriteLine(b1);
            byte b2 = 145;
            Console.WriteLine(b2);

            //sbyte
            sbyte sb1 = -113;
            Console.WriteLine(sb1);

            //short
            short s1 = short.MaxValue;
            Console.WriteLine(s1);
            short s2 = short.MinValue;
            Console.WriteLine(s2);

            //int
            int i1 = -123_456_789;
            Console.WriteLine(i1);
            int i2 = 0xA2B4;
            Console.WriteLine(i2);
            int i3 = 0b1001;
            Console.WriteLine(i3);

            //long
            long l1 = 9_876_543_210;
            Console.WriteLine(l1);
            long l2 = 110;
            Console.WriteLine(l2);


            //Implizirte konvertierung
            short s3 = b2;
            Console.WriteLine(s3);

            //Explizierte Konvertierung
            byte b3 = (byte)s3;
            Console.WriteLine(b3);


            short sx = 256;
            byte bx = (byte)sx;
            Console.WriteLine("Test  256 in byte " + bx);
        }
    }
}
