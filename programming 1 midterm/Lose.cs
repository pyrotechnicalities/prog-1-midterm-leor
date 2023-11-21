using programming_1_midterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MidtermLeftOrRight
{
    internal class Lose
    {
        public Friend CurrentFriend;
        private Credits ToCredits;
        public Lose()
        {

        }
        public void LoseRefuseTheCall(bool hasGawain)
        {
            if (hasGawain == true)
            {
                WriteLine("\nYou drop the ring like it burned you, still hearing an echo of that mysterious voice in your head and it is NOT pleasant. Gawain peers at you, clearly concerned.");
                ReadKey();
                WriteLine("Gawain: What’s wrong?");
                ReadKey();
                WriteLine("A. 'That stupid ring- it’s cursed, man.' or B. 'The ring- it SPOKE to me. I want out of here.'");
                string responseLoseRefuseTheCallDialogue = ReadLine().Trim().ToUpper();

                if (responseLoseRefuseTheCallDialogue == "A")
                {
                    WriteLine("\nGawain: Hmmm. I think we should get out of here. It feels like the cave doesn’t want us here.");
                }
                else
                {
                    WriteLine("\nGawain: I could say the same. This place feels… oppressive.");
                }
                WriteLine("You nod vehemently in agreement, and the two of you hurry out of the cave. You can’t help but feel a little bitter that you came all the way out here and will now have nothing to show for it, but you’d rather be empty handed as opposed to dead. And besides, you could have taken the ring if you really wanted to, but… no. Something tells you that too much power would not be good for you.");
                ReadKey();
                WriteLine("You and Gawain part ways at the entrance to your village with little fanfare. You watch him wander off down the road, searching for his next quest, before turning back and heading straight for your house. Tales of your exploits can wait for another day. For now, you need a good long nap.");
                ReadKey();
                WriteLine("\n\n===== THE END =====");

                ToCredits.CreditsForThePlayer();
            }
            else
            {
                WriteLine("\nYou drop the ring like it burned you, still hearing an echo of that mysterious voice in your head and it is NOT pleasant. You don’t waste much time hurrying out of the cave, as the whispers from the voice seem to be leaking out of your head and into the cave itself, which is never a good sign.");
                ReadKey();
                WriteLine("You can’t help but feel a little bitter that you came all the way out here and will now have nothing to show for it, but you’d rather be empty handed as opposed to dead. And besides, you could have taken the ring if you really wanted to, but… no. Something tells you that too much power would not be good for you.");
                ReadKey();
                WriteLine("Your journey home is (mercifully) uneventful, and the whispers get quieter and quieter the further from the cave you get. Upon arriving back in your village, you head straight for your house. Tales of your exploits can wait for another day. For now, you need a good long nap.");
                ReadKey();
                WriteLine("\n\n===== THE END =====");

                ToCredits.CreditsForThePlayer();
            }
        }
        public void LoseNotEnoughPointsLeft(bool hasGawain)
        {
            if (hasGawain == true)
            {
                WriteLine("\nYou feel a sudden pain in your chest that quickly begins to spread throughout your whole body, and you drop to your knees out of reflex. You try to let go of the ring, but you cannot. Dimly, you can hear Gawain calling your name, but nothing exists for you outside of the all consuming pain in your bones. The ring is killing you. Just like the other poor souls you heard about before you even started off.");
                ReadKey();
                WriteLine("What could you have done wrong…?");
                ReadKey();
                WriteLine("That final thought echoes through your brain before you simply cannot take it anymore. Your whole body goes limp and you fall to the ground, but you never feel the impact. You’re dead before you hit the ground.");
                ReadKey();
                WriteLine("\n\n===== THE END =====");

               ToCredits.CreditsForThePlayer();
            }
            else
            {
                WriteLine("\nYou feel a sudden pain in your chest that quickly begins to spread throughout your whole body, and you drop to your knees out of reflex. You try to let go of the ring, but you cannot. Nothing exists for you outside of the all consuming pain in your bones. The ring is killing you. Just like the other poor souls you heard about before you even started off.");
                ReadKey();
                WriteLine("What could you have done wrong…?");
                ReadKey();
                WriteLine("That final thought echoes through your brain before you simply cannot take it anymore. Your whole body goes limp and you fall to the ground, but you never feel the impact. You’re dead before you hit the ground.");
                ReadKey();
                WriteLine("\n\n===== THE END =====");

                ToCredits.CreditsForThePlayer();
            }
        }
        public void LoseNotEnoughPointsRight(bool hasBestFriend)
        {
            if (hasBestFriend == true)
            {
                WriteLine("\nThe voices fade away and the lake itself freezes over, trapping the canteen inside it. Before you can really process what’s happening, your best friend pulls you away from the lake’s edge, eyes wide and focused on the now frozen surface of the lake. You stare at it along with them, certain that if your best friend hadn’t saved you, you too would now be nothing more than a frozen statue along the lake’s edge.");
                ReadKey();
                WriteLine($"{CurrentFriend.BestFriendName}: DUDE. I thought she was kidding about that whole judgment thing. This is insane! Let’s get out of here.");
                ReadKey();
                WriteLine("You nod and the two of you hurry away from the frozen lake, eager to get away from the site of your failure. The walk of shame back to the apothecary’s shop is truly torturous, but you know that deep down you deserve it. After all, you were judged poorly by the lake.");
                ReadKey();
                WriteLine("After enduring the apothecary’s withering stare of disappointment, you and your best friend part ways for the day, feeling like you need several days to recover from the sheer humiliation you just felt. Ah well. You’ll have another day to try again. For now, though, you’ve got to rest.");
                ReadKey();
                WriteLine("\n\n===== THE END =====");

                ToCredits.CreditsForThePlayer();
            }
            else
            {
                WriteLine("\nThe voices fade away and the lake itself freezes over, trapping the canteen inside it. A cold sensation races up your hand, and with icy horror seeping into your throat, you realize you can’t pull your hand off of the canteen. You struggle against it for several long moments as your joints begin to go stiff and it gets harder to fight against the powerful magic freezing you in place. Finally, as your whole body stills, you cry out for help, only for the syllables to be cut off as the freezing curse fully takes effect.");
                ReadKey(); 
                WriteLine("\nYour last thought is that nobody will ever think to come looking for you at the lakeside.");
                ReadKey();
                WriteLine("\n\n===== THE END =====");

                ToCredits.CreditsForThePlayer();
            }
        }
    }
}
