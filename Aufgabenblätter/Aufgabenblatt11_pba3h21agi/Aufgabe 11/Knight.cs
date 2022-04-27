using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_11
{
    internal class Knight
    {
        private int energy = 100;
        private int lives = 3;
        private string name;

        public Knight(string name)
        {
            this.name = name;
            energy = 100;
            lives = 3;
        }
        public void Run()
        {
            if(IsAlive())
            {
                energy -= 2;
                Console.WriteLine("**********PLAYER RUN - 2 ENERGY**********");
                CheckEnergyAndLives();
            }
        }
        public void Jump()
        {
            if (IsAlive())
            {
                energy -= 5;
                Console.WriteLine("**********PLAYER JUMPED - 5 Energy**********");
                CheckEnergyAndLives();
            }
            
        }
        public void LoadEnergy()
        {
            if (IsAlive())
            {
                energy += 10;
                Console.WriteLine("**********PLAYER + 10 ENERGY**********");
            }
        }
        public int Attack()
        {
            int power = 0;
            switch(energy / 20)
            {
                case 0:
                case 1:
                case 2:
                      power = 1;
                break;

                case 3:
                case 4:
                      power = 3;
                break;

                case 5:
                      power = 5;
                break;

            }
            return power;
        }
        public void Hit(int power)
        {
            energy -= power;
            CheckEnergyAndLives();
        }
        public bool IsAlive()
        {
            if(energy < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void CheckEnergyAndLives()
        {
            if(energy <= 0 && lives > 0)
            {
                lives--;
                energy = 100;
            }
            if(energy <= 0 && lives == 0)
            {
                Console.WriteLine("**********PLAYER DEAD**********");
            }
        }
        public override string ToString()
        {
            return ($"Knight = {name} Energy = {energy} Lives = {lives}");
        }
    }
}
