using System;

namespace Praxis_7_Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {

            //Deklaration und ausgabe von dateitypen
            //Ganzzahlen
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

            //Nachkommazahlen
            //float
            float f1 = 15.3f;
            Console.WriteLine(f1);
            float f2 = 12345.6789f;
            Console.WriteLine(f2);

            //double
            double d1 = 3.5d;
            Console.WriteLine(d1);
            double d2 = 12345.6789d;
            Console.WriteLine(d2);
            double d3 = -1.602176620898e19d;
            Console.WriteLine(d3);

            //decimal
            decimal m1 = 0.123456789123456789012345678901234567890m;
            Console.WriteLine(m1);
            decimal m2 = -1.602176620898e19m;
            Console.WriteLine(m2);


            // Eingabe von Kommazahlen über die Konsole
            Console.Write("float? ");
            float fx = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(fx);

            Console.Write("double ?");
            double dx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(dx);

        }
    }
}
