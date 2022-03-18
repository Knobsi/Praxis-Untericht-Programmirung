using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_11
{
    internal class Monster
    {
        private int energy;
        private int power;
        private Random rn = new Random(); 

        public Monster()
        { 
            this.energy = 10;
            this.power = rn.Next(2,6);
        }

        public int Atack()
        {
            if(IsAlive())
            {
                return power;
            }
            else
            {
                return 0;
            }
        }

        public void Hit(int power)
        {
            energy -= power;
        }
        public bool IsAlive()
        {
            if(energy <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void CheckEnergy()
        {
            if(energy <= 0)
            {
                energy = 0;
                Console.WriteLine("**********MONSTER DEAD*********");
            }
        }
    }
}
