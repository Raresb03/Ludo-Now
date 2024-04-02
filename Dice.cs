using System;

namespace Ludo_Now
{
    class Dice
    {
        private Random rand = new Random();
        public int AruncaZarul()
        {
            return rand.Next(1, 7);
        }
    }
}
