using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MidtermLeftOrRight
{
    internal class LeftPath
    {
        public static void LeftPathGameplay()
        {
            WriteLine("Given that today is such a wonderful day, you decide to take a simple stroll down to the market to see if you can overhear any interesting new gossip. As you reach the center square, you spot the general store shopkeeper and one of the waiters from the inn deep in heated discussion. Intrigued, you decide to move closer. ");
            ReadKey();
            WriteLine("\nSHOPKEEPER: So, anyway, that’s all I’ve heard about the ring.");
            ReadKey();
            WriteLine("\nWAITER: Ohhh, interesting. I wonder if the boss will give me time off work to go search for it. ");
            ReadKey();
            WriteLine("\nUpon noticing your approach, the shopkeeper and the waiter turn to you, looking a little bit like you’ve caught them discussing some taboo subject.");
            ReadKey();
            WriteLine("What would you like to say? A: 'What were you guys talking about?' or B: 'Did I interrupt something?'");
            string responseDialogue1 = ReadLine().Trim().ToUpper();

            if (responseDialogue1 == "A")
            {
                WriteLine("\nSHOPKEEPER: Oh, nothing. ");
                ReadKey();
                WriteLine("\nWAITER: Yeah, nothing! Haha. ");
                ReadKey();
                WriteLine("\n(He laughs nervously and shifts his eyes away from you. Something’s clearly up. Do you want to press them for more info? ((yes / no))");
                string responsePressForInfo = ReadLine().Trim().ToLower();

                if (responsePressForInfo == "yes")
                {
                    WriteLine("\n'Come on, tell me. I can keep a secret.'");
                    WriteLine("\nSHOPKEEPER: (He glances over at the waiter reluctantly, then sighs.) …Alright, I’ll tell you, since you’re a good kid. Rumor has it that there’s a mystical ring that can grant wishes buried in the dragon’s hoard just west of the town. A couple of knights came through the area the other day and chased the dragon off, so now all the loot is free for the taking. If you’re brave enough to try and search for it, of course.");
                    ReadKey();
                    WriteLine("\n WAITER: It’s supposed to be SUPER powerful! Oh man, if I found it…");
                    ReadKey();
                    WriteLine("\nSHOPKEEPER: Tell me about it… I wouldn’t have to work another day in my life!");
                    ReadKey();
                    WriteLine("With that, the two of them get lost in their previous discussion, leaving you to make a choice: would you like to A. Pursue the ring or B. Stay in the town to learn more about it?");
                    string responseSearchForRing = ReadLine().Trim().ToUpper();

                    if (responseSearchForRing == "A")
                    {
                        WriteLine($"This whole ring business is still a little mysterious to you, but you never have been able to resist a good challenge. Besides, the power to grant wishes could literally change your life! With this in mind, you briefly stop by the armorer to grab a {weaponType}. You can never be too careful with this kind of thing. Once that’s sorted out, you head out to the western road to begin your journey to find this mystical ring!");
                        SeekRing();
                    }
                    else
                    {
                        ArmorerDialogue();
                    }
                }
                else
                {
                    WriteLine("'Sorry for interrupting.'");
                    ReadKey();
                    WriteLine("\nBoth the shopkeeper and the waiter let out a significant sigh of relief when you choose not to press them for information. However, they don’t resume their discussion until after you walk several feet away. How suspicious. Clearly there’s something up with this ring you heard them mention. It might be worth looking into further, and since they won’t tell you… you know exactly where to go: the armorer.");
                    ArmorerDialogue();
                }
            }
            else
            {
                WriteLine("\nWAITER: No, of course not! We weren’t talking about anything!!");
                ReadKey();
                WriteLine("\nSHOPKEEPER: (He elbows the waiter swiftly in the ribs and shoots him a dirty glare.) Forgive my friend. We weren’t talking about anything of importance.");
                ReadKey();
                WriteLine("\nSomething’s clearly up. Do you want to press them for more info? ((yes/no))");
                string responsePressForInfo = ReadLine().Trim().ToLower();

                if (responsePressForInfo == "yes")
                {
                    WriteLine("'Really? Then it shouldn’t be a problem for you to repeat what you just said before I walked up to you. If it’s a secret, you can tell me.'");
                    ReadKey();
                    WriteLine("\nWAITER: Ugh, fine! You got me! You know that dragon that the knights chased out a few days ago? Well, apparently there’s some sort of magical ring that can grant wishes hidden in its hoard. Since the dragon is gone, the loot is all free for the taking! It’s located just west of here.");
                    ReadKey();
                    WriteLine("\nSHOPKEEPER: (He doesn’t say anything. He just sighs in disappointment and pinches the bridge of his nose.)");
                    ReadKey();
                    WriteLine("\nWAITER: Look, I was going to go try to find it myself, but if you’re going… I might as well not bother. I probably wouldn’t be able to get off work anyway… (He walks off in a huff before you can either confirm or deny this statement.)");
                    ReadKey();
                    WriteLine("\nSHOPKEEPER: Sorry about that. He’s a little dramatic. (The shopkeeper promptly goes after his friend to console him.)");
                    ReadKey();
                    WriteLine("With that, you are now confronted with a decision. Would you like to A. Pursue the ring or B. Stay in the town to learn more about it?");
                    string responseSearchForRing = ReadLine().Trim().ToUpper();

                    if (responseSearchForRing == "A")
                    {
                        WriteLine($"This whole ring business is still a little mysterious to you, but you never have been able to resist a good challenge. Besides, the power to grant wishes could literally change your life! With this in mind, you briefly stop by the armorer to grab a {weaponType}. You can never be too careful with this kind of thing. Once that’s sorted out, you head out to the western road to begin your journey to find this mystical ring!");
                        SeekRing();
                    }
                    else
                    {
                        ArmorerDialogue();
                    }
                }
                else
                {
                    WriteLine("'Sorry for interrupting.'");
                    ReadKey();
                    WriteLine("\nBoth the shopkeeper and the waiter let out a significant sigh of relief when you choose not to press them for information. However, they don’t resume their discussion until after you walk several feet away. How suspicious. Clearly there’s something up with this ring you heard them mention. It might be worth looking into further, and since they won’t tell you… you know exactly where to go: the armorer.");
                    ArmorerDialogue();
                }
            }
        }
        public static void ArmorerDialogue()
        {
            WriteLine($"Oh, hey {playerName}. What can I do for you today?");
            //ask about the playerName error
            ReadKey();
            WriteLine("\n'I want to ask about the rumors of a magical ring.'");
            ReadKey();
            WriteLine("ARMORER: Ah, so I see you’ve heard them too. Well, here’s the deal: the dragon that had settled just west of here got chased away a few days ago and left its entire hoard behind. People have already ventured out to go dig through it. That’s where the rumor of a magical ring started- apparently, some explorer went to dig through the dragon’s hoard with some of his friends, picked up a mysterious ring, and then died on the spot.");
            WriteLine("A: 'Wait, died ?' or B: 'That’s really cute.'");
            string responseWittyAnswerToArmorerQ = ReadLine().Trim().ToUpper();

            if (responseWittyAnswerToArmorerQ == "A")
            {
                ArmorerDialogue2();
            }
            else
            {
                ArmorerDialogue2();
            }
        }
        public static void ArmorerDialogue2()
        {
            WriteLine($"ARMORER: You heard me correctly. That poor soul died, but it’s only made the ring more enticing for other treasure seekers. If you wish to pursue it, you should act quickly. But, don’t forget to take {weaponType} with you! It’s always good to be prepared.");
            ReadKey();
            WriteLine("'Thank you.'");
            WriteLine($"You take your leave from the armorer’s shop, {weaponType} in hand, and once again find yourself faced with a decision. You feel like you have enough information to go on now, so it’s time to go after the ring. And yet, something makes you pause- this ring seems to have a mysterious curse that kills people who touch it. Still, the power to grant wishes is something spectacular indeed… it might be worth your while to at least LOOK for it.");
            ReadKey();
            WriteLine("\nWith your mind made up, you head out to the western road, prepared to begin your journey to find this mystical ring!");
            SeekRing();
        }
        public static void SeekRing()
        {

        }
    }
}
