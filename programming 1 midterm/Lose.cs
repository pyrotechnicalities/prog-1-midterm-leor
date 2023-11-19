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
        public static void LoseRefuseTheCall(bool hasGawain)
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

                CreditsForThePlayer();
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

                CreditsForThePlayer();
            }
        }
        public static void LoseNotEnoughPointsLeft(bool hasGawain)
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

                CreditsForThePlayer();
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

                CreditsForThePlayer();
            }
        }
        public static void LoseNotEnoughPointsRight()
        {

        }
    }
}
