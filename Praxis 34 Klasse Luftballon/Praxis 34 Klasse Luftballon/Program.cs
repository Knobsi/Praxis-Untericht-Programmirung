using System;

namespace Praxis_34_Klasse_Luftballon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Luftballon roterLuftballon = new Luftballon("rot","rund",1.2);
            Luftballon gruenerLuftballon = new Luftballon("grün", "Viereckig", 3.8);

            roterLuftballon.Aufpusten(0.4);

            Console.WriteLine(roterLuftballon);
            Console.WriteLine(gruenerLuftballon);
        }
    }
}
