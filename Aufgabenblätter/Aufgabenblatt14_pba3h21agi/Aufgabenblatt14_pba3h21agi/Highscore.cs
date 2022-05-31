using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabenblatt14_pba3h21agi
{
    internal class Highscore
    {
        private string player;
        public string Player
        {
            get { return player; }
            set { player = value; }
        }

        private int score;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }


        public Highscore(string player, int score)
        {
            Player = player;
            Score = score;
        }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
