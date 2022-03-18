using System;

namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight ritter1 = new Knight("BABO");
            Monster mob1 = new Monster();
            Monster mob2 = new Monster();
            Monster mob3 = new Monster();


            Random rand = new Random();
            
            while(ritter1.IsAlive())
            {
                int rundOrJump = rand.Next(0,2);
                if(rundOrJump == 0)
                {
                    ritter1.Jump();
                }
                else if(rundOrJump == 1)
                {
                    ritter1.Run();
                }

                int spawnChance = rand.Next(1,11);

                if(spawnChance == 8)
                {
                    if(mob1.IsAlive())
                    {
                        while (mob1.IsAlive())
                        {
                            mob1.Hit(ritter1.Attack());
                            Console.WriteLine($"**********Player hittet mob1 white {ritter1.Attack()} Damage**********");
                            if (mob1.IsAlive())
                            {
                                ritter1.Hit(mob1.Atack());
                                Console.WriteLine($"**********Mob 1 hittet Player white {mob1.Atack()} Damage**********");
                            }
                        }
                        ritter1.LoadEnergy();
                    }
                    else if(mob2.IsAlive())
                    {
                        while (mob2.IsAlive())
                        {
                            mob2.Hit(ritter1.Attack());
                            Console.WriteLine($"**********Player hittet mob2 white {ritter1.Attack()} Damage**********");
                            if (mob2.IsAlive())
                            {
                                ritter1.Hit(mob2.Atack());
                                Console.WriteLine($"**********Mob 1 hittet Player white {mob2.Atack()} Damage**********");
                            }
                            
                        }
                        ritter1.LoadEnergy();
                    }
                    else if( mob3.IsAlive())
                    {
                        while (mob3.IsAlive())
                        {
                            mob3.Hit(ritter1.Attack());
                            Console.WriteLine($"**********Player hittet mob2 white {ritter1.Attack()} Damage**********");
                            if(mob3.IsAlive())
                            {
                                ritter1.Hit(mob3.Atack());
                                Console.WriteLine($"**********Mob 1 hittet Player white {mob3.Atack()} Damage**********");
                            }
                            
                        }
                        ritter1.LoadEnergy();
                    }
                    
                }
           
            }
        }
    }
}
