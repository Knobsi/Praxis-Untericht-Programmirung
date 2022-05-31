using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabenblatt14_pba3h21agi
{
    internal class HighscoreManager
    {
        private List<Highscore> ergebnisse;
        public List<Highscore> Ergebnisse
        {
            get { return ergebnisse; }
        }
        public HighscoreManager()
        {
            ergebnisse = new List<Highscore>();
            LoadTestData();
        }

        public List<Highscore> GetTopTen()
        {
            List<Highscore> topTen = new List<Highscore>();
            Ergebnisse.Sort(sorting);

            for (int i = 0; i < 10; i++)
            {
                topTen.Add(Ergebnisse[i]);
            }

            

            return topTen;
        }

        int sorting(Highscore x,Highscore y)
        {
            return -x.Score.CompareTo(y.Score);
        }

        public bool AddNewScore(string player, int score)
        {
            if (score <= 0)
            {
                throw new ArgumentException("Übergebener spieler hat nicht genug punkte um eingetragen zu werden");
            }
            foreach (var item in Ergebnisse)
            {
                if (item.Player == player)
                {
                    if (item.Score > score)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool AddNewScore(Highscore highscore)
        {
            if (highscore.Score <= 0)
            {
                throw new ArgumentException("Übergebener spieler hat nicht genug punkte um eingetragen zu werden");
            }
            foreach (var item in Ergebnisse)
            {
                if (item.Player == highscore.Player)
                {
                    if(item.Score > highscore.Score)
                    {
                        return true;
                    }                  
                }
            }
            return false;
        }
        public List<Highscore> GetPlayerHighscoreList(string player)
        {
            List<Highscore> playerHighscoreList = new List<Highscore>();
            foreach (var item in Ergebnisse)
            {
                if(item.Player == player)
                {
                    playerHighscoreList.Add(item);
                }
            }
            return playerHighscoreList;
        }
        public int FindHighestScoreForPlayer(string player)
        {
            foreach (var item in Ergebnisse)
            {
                if (item.Player == player)
                {
                    return item.Score;
                }
            }
            
            return 0;
        }
        private void LoadTestData()
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                ergebnisse.Add(new Highscore($"BOB{(i + 1)}", random.Next(800, 10000)));
            }
        }
        public override string ToString()
        {
            return $"{string.Join("|", Ergebnisse)}";
        }
    }
}
