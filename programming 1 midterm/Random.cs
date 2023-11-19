using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MidtermLeftOrRight
{
    // ask tutor about this 
    internal class Random
    {
        public class Dice
        {
            private Random random;
            public Dice()
            {
                this.random = new Random();
            }
            public int Roll()
            {
               return random.Next();
            }

            Dice d20 = new Dice();
        }
    }
}
