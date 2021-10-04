using System;
namespace Coin_Toss
{
    class Coin
    {
        private string sideUp;
        Random rand = new Random();
        public Coin()
        {
            sideUp = "Heads";
        }
        public void Toss()
        {
            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }
        public string GetSideUp()
        {
            return sideUp;
        }
    }
}