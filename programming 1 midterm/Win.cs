using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MidtermLeftOrRight
{
    internal class Win
    {
        public static void WinConditionsMetLeft(bool hasGawain)
        {
            if(hasGawain == true)
            {
                WriteLine("\nYou turn to show Gawain the ring that is now yours, either to keep or gift to someone else.");
                ReadKey();
                WriteLine("Gawain: What a find! Is that the one you came for?");
                ReadKey(); 
                WriteLine("You nod, still too in awe of the ring you’re holding to speak.");
                ReadKey(); 
                WriteLine("Gawain: Excellent! Well, I’m satisfied if you are. I’ll accompany you back to your village, and then we must part ways, I fear.");
                ReadKey();
                WriteLine("\nThus, you and Gawain exit the abandoned lair, the ring weighing heavily in your pocket. Yet you still feel as light as ever. Maybe even more so, now that you’ve fulfilled your quest. You can’t wait to tell everybody at home about it!");
                ReadKey();
                WriteLine("Your journey home is mercifully uneventful. You and Gawain part ways at the entrance to your town and you watch him wander off down the road, searching for his next quest. It feels strangely melancholic. Though you didn’t know him for long, he was still a friend to you. All that being said, you’re probably going to need a while to recover from all that traveling…");
                ReadKey();
                WriteLine("\n\n===== THE END =====");

                CreditsForThePlayer();
            }
            else
            {
                WriteLine("\nYou stand frozen in the dragon’s abandoned lair for a good long moment, beholding the ring that you’ve won and contemplating what on earth you should do next. Eventually, you snap out of your reverie and decide that your first plan of action should be to get out of this dingy cave and start back to your home. With that in mind, you exit the cave, leaving behind the piles and piles of other treasures for other adventurers. You got what you came for, so it wouldn’t be fair to take more.");
                ReadKey();
                WriteLine("Your journey home is relatively uneventful. You’ve never been more relieved to see the familiar sight of your house and the sprawl of farmland it watches over. You’re definitely going to need a while to recover from this adventure…");
                ReadKey();
                WriteLine("\n\n===== THE END =====");

                CreditsForThePlayer();
            }
        }
        public static void WinConditionsMetRight()
        {

        }
    }
}
