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
        public Friend CurrentFriend;
        private Credits ToCredits;
        public Win()
        {
            
        }
        public void WinConditionsMetLeft(bool hasGawain)
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

                ToCredits.CreditsForThePlayer();
            }
            else
            {
                WriteLine("\nYou stand frozen in the dragon’s abandoned lair for a good long moment, beholding the ring that you’ve won and contemplating what on earth you should do next. Eventually, you snap out of your reverie and decide that your first plan of action should be to get out of this dingy cave and start back to your home. With that in mind, you exit the cave, leaving behind the piles and piles of other treasures for other adventurers. You got what you came for, so it wouldn’t be fair to take more.");
                ReadKey();
                WriteLine("Your journey home is relatively uneventful. You’ve never been more relieved to see the familiar sight of your house and the sprawl of farmland it watches over. You’re definitely going to need a while to recover from this adventure…");
                ReadKey();
                WriteLine("\n\n===== THE END =====");

                ToCredits.CreditsForThePlayer();
            }
        }
        public void WinConditionsMetRight(bool hasBestFriend)
        {
            if (hasBestFriend == true)
            {
                WriteLine("\nThe voices fade away and water begins to flow into the canteen. You exhale in relief. The lake has judged you worthy after all. You’re not sure what would happen if it hadn’t, but you don’t really want to find out. Once the canteen is full, you take it out of the water and recap it. Time to return to the village and hand the water to the apothecary!");
                ReadKey();
                WriteLine($"{CurrentFriend.BestFriendName}: Nice work! I was worried for a second there because you just froze up, but everything is fine, right?");
                ReadKey();
                WriteLine("A. 'Oh yeah. Piece of cake.' or B. 'Yeah, I’m all good.'");
                string responseWinConditionRight = ReadLine().Trim().ToUpper();

                if (responseWinConditionRight == "A")
                {
                    WriteLine($"\n{CurrentFriend.BestFriendName}: Good to hear. Well, let’s go back.");
                }
                else
                {
                    WriteLine($"\n{CurrentFriend.BestFriendName}: That's really good to hear. Well, let’s go back.");
                }

                ReadKey();
                WriteLine("\nSo, the two of you return, victory held tight in your grasp. The apothecary thanks you profusely for your hard work, and now you’re totally free to do whatever you desire. Which, after such a day of chores, you’re thinking is sleep for a looooong time. You and your best friend part ways for the day, feeling well and truly accomplished. All is well.");
                ReadKey();
                WriteLine("\n\n===== THE END =====");

                ToCredits.CreditsForThePlayer();
            }
            else
            {
                WriteLine("\nThe voices fade away and water begins to flow into the canteen. You exhale in relief. The lake has judged you worthy after all. You’re not sure what would happen if it hadn’t, but you don’t really want to find out. Once the canteen is full, you take it out of the water and recap it. Time to return to the village and hand the water to the apothecary!");
                ReadKey(); 
                WriteLine("You return to your village, victory held tight in your grasp. The apothecary thanks you profusely for your hard work, and now you’re totally free to do whatever you desire. Which, after such a day of chores, you’re thinking is sleep for a looooong time. All is well. You remain entirely clueless to the danger you just put yourself in, and that’s just fine by you.");
                ReadKey();
                WriteLine("\n\n===== THE END =====");

                ToCredits.CreditsForThePlayer();
            }
        }
    }
}
