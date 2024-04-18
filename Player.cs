using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirk_Module2CodingChallenge
{
    internal class Player
    {
        //Attributes
        private string name;
        private int score;
        private int livesLeft;
        private int gold;

        //Constructors
        public Player(string name)
        {
            this.name = name;
        }

        public Player(string name, int startingLives)
        {
            this.name = name;
            livesLeft = startingLives;
        }//end method

        //Methods = behaviors or tasks that the object can perform
        public int GetScore()
        {
            return score;
        }//end method

        public int GetGold()
        {
            return gold;
        }//end method

        public void AddGold(int foundGold)
        {
            gold += foundGold;
        }//end method

        public void LoseGold(int lostGold)
        {
            gold -= lostGold;
        }//end method
        
        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }//end method

        public void Kill()
        {
            //No neg lives
            if (livesLeft > 0)
            {
                livesLeft --;
            }
        }//end method

        public int GetLivesLeft()
        {
            return livesLeft;
        }//end method

    }//end class

}//end namespace
