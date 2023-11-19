using programming_1_midterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MidtermLeftOrRight
{
    internal class RightPath
    {
        bool hasBestFriend;
        public Friend CurrentFriend;
        public Player CurrentPlayer;
        public RightPath(Player placeholder, Friend placeholder2)
        {
            CurrentPlayer = placeholder;
            CurrentFriend = placeholder2;
        }
        public void RightPathGameplay(bool hasBestFriend)
        {
            WriteLine("\nGiven that today is such a wonderful day, you decide to sleep in a little bit before you actually get a start on your day. Once you’re up and moving, much later in the afternoon than you would be on a normal day, you decide to take a simple stroll down to the market to see if you can overhear any interesting new gossip. As you reach the center square, you run into your best friend.");
            ReadKey();
            // ask tutor about null error 
            WriteLine($"{CurrentFriend.BestFriendName}:  Oh, hey {CurrentPlayer.Name}.");
        }
    }
}
