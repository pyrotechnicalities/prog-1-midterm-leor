using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace MidtermLeftOrRight
{
    internal class LeftPath
    {
        bool hasGawain;
        public Player CurrentPlayer;
        private Win WinConditions;
        private Lose LoseConditions;
        private Random DiceRoll;
        public LeftPath(Player placeholder)
        {
            CurrentPlayer = placeholder;
        }
        public void LeftPathGameplay(bool hasGawain)
        {
            
            WriteLine("\nGiven that today is such a wonderful day, you decide to take a simple stroll down to the market to see if you can overhear any interesting new gossip. As you reach the center square, you spot the general store shopkeeper and one of the waiters from the inn deep in heated discussion. Intrigued, you decide to move closer. ");
            ReadKey();
            WriteLine("\nSHOPKEEPER: So, anyway, that’s all I’ve heard about the ring.");
            ReadKey();
            WriteLine("WAITER: Ohhh, interesting. I wonder if the boss will give me time off work to go search for it. ");
            ReadKey();
            WriteLine("Upon noticing your approach, the shopkeeper and the waiter turn to you, looking a little bit like you’ve caught them discussing some taboo subject.");
            ReadKey();
            WriteLine("\nWhat would you like to say? A: 'What were you guys talking about?' or B: 'Did I interrupt something?'");
            string responseDialogue1 = ReadLine().Trim().ToUpper();

            if (responseDialogue1 == "A")
            {
                WriteLine("\nSHOPKEEPER: Oh, nothing. ");
                ReadKey();
                WriteLine("WAITER: Yeah, nothing! Haha. ");
                ReadKey();
                WriteLine("(He laughs nervously and shifts his eyes away from you. Something’s clearly up. Do you want to press them for more info? ((yes / no))");
                string responsePressForInfo = ReadLine().Trim().ToLower();

                if (responsePressForInfo == "yes")
                {
                    WriteLine("\n'Come on, tell me. I can keep a secret.'");
                    WriteLine("SHOPKEEPER: (He glances over at the waiter reluctantly, then sighs.) …Alright, I’ll tell you, since you’re a good kid. Rumor has it that there’s a mystical ring that can grant wishes buried in the dragon’s hoard just west of the town. A couple of knights came through the area the other day and chased the dragon off, so now all the loot is free for the taking. If you’re brave enough to try and search for it, of course.");
                    ReadKey();
                    WriteLine("WAITER: It’s supposed to be SUPER powerful! Oh man, if I found it…");
                    ReadKey();
                    WriteLine("SHOPKEEPER: Tell me about it… I wouldn’t have to work another day in my life!");
                    ReadKey();
                    WriteLine("With that, the two of them get lost in their previous discussion, leaving you to make a choice: would you like to A. Pursue the ring or B. Stay in the town to learn more about it?");
                    string responseSearchForRing = ReadLine().Trim().ToUpper();

                    if (responseSearchForRing == "A")
                    {
                        WriteLine($"This whole ring business is still a little mysterious to you, but you never have been able to resist a good challenge. Besides, the power to grant wishes could literally change your life! With this in mind, you briefly stop by the armorer to grab a {CurrentPlayer.WeaponType}. You can never be too careful with this kind of thing. Once that’s sorted out, you head out to the western road to begin your journey to find this mystical ring!");
                        SeekRingPartOne(false);
                    }
                    else
                    {
                        ArmorerDialogue(false);
                    }
                }
                else
                {
                    WriteLine("\n'Sorry for interrupting.'");
                    ReadKey();
                    WriteLine("Both the shopkeeper and the waiter let out a significant sigh of relief when you choose not to press them for information. However, they don’t resume their discussion until after you walk several feet away. How suspicious. Clearly there’s something up with this ring you heard them mention. It might be worth looking into further, and since they won’t tell you… you know exactly where to go: the armorer.");
                    ArmorerDialogue(false);
                }
            }
            else
            {
                WriteLine("WAITER: No, of course not! We weren’t talking about anything!!");
                ReadKey();
                WriteLine("SHOPKEEPER: (He elbows the waiter swiftly in the ribs and shoots him a dirty glare.) Forgive my friend. We weren’t talking about anything of importance.");
                ReadKey();
                WriteLine("Something’s clearly up. Do you want to press them for more info? ((yes/no))");
                string responsePressForInfo = ReadLine().Trim().ToLower();

                if (responsePressForInfo == "yes")
                {
                    WriteLine("'Really? Then it shouldn’t be a problem for you to repeat what you just said before I walked up to you. If it’s a secret, you can tell me.'");
                    ReadKey();
                    WriteLine("WAITER: Ugh, fine! You got me! You know that dragon that the knights chased out a few days ago? Well, apparently there’s some sort of magical ring that can grant wishes hidden in its hoard. Since the dragon is gone, the loot is all free for the taking! It’s located just west of here.");
                    ReadKey();
                    WriteLine("SHOPKEEPER: (He doesn’t say anything. He just sighs in disappointment and pinches the bridge of his nose.)");
                    ReadKey();
                    WriteLine("WAITER: Look, I was going to go try to find it myself, but if you’re going… I might as well not bother. I probably wouldn’t be able to get off work anyway… (He walks off in a huff before you can either confirm or deny this statement.)");
                    ReadKey();
                    WriteLine("SHOPKEEPER: Sorry about that. He’s a little dramatic. (The shopkeeper promptly goes after his friend to console him.)");
                    ReadKey();
                    WriteLine("With that, you are now confronted with a decision. Would you like to A. Pursue the ring or B. Stay in the town to learn more about it?");
                    string responseSearchForRing = ReadLine().Trim().ToUpper();

                    if (responseSearchForRing == "A")
                    {
                        WriteLine($"This whole ring business is still a little mysterious to you, but you never have been able to resist a good challenge. Besides, the power to grant wishes could literally change your life! With this in mind, you briefly stop by the armorer to grab a {CurrentPlayer.WeaponType}. You can never be too careful with this kind of thing. Once that’s sorted out, you head out to the western road to begin your journey to find this mystical ring!");
                        SeekRingPartOne(false);
                    }
                    else
                    {
                        ArmorerDialogue(false);
                    }
                }
                else
                {
                    WriteLine("'Sorry for interrupting.'");
                    ReadKey();
                    WriteLine("Both the shopkeeper and the waiter let out a significant sigh of relief when you choose not to press them for information. However, they don’t resume their discussion until after you walk several feet away. How suspicious. Clearly there’s something up with this ring you heard them mention. It might be worth looking into further, and since they won’t tell you… you know exactly where to go: the armorer.");
                    ArmorerDialogue(false);
                }
            }
        }
        public void ArmorerDialogue(bool hasGawain)
        {
            WriteLine($"Oh, hey {CurrentPlayer.Name}. What can I do for you today?");
            ReadKey();
            WriteLine("'I want to ask about the rumors of a magical ring.'");
            ReadKey();
            WriteLine("ARMORER: Ah, so I see you’ve heard them too. Well, here’s the deal: the dragon that had settled just west of here got chased away a few days ago and left its entire hoard behind. People have already ventured out to go dig through it. That’s where the rumor of a magical ring started- apparently, some explorer went to dig through the dragon’s hoard with some of his friends, picked up a mysterious ring, and then died on the spot.");
            WriteLine("A: 'Wait, died ?' or B: 'That’s really cute.'");
            string responseWittyAnswerToArmorerQ = ReadLine().Trim().ToUpper();

            if (responseWittyAnswerToArmorerQ == "A")
            {
                ArmorerDialogue2(false);
            }
            else
            {
                ArmorerDialogue2(false);
            }
        }
        public void ArmorerDialogue2(bool hasGawain)
        {
            
            WriteLine($"ARMORER: You heard me correctly. That poor soul died, but it’s only made the ring more enticing for other treasure seekers. If you wish to pursue it, you should act quickly. But, don’t forget to take {CurrentPlayer.WeaponType} with you! It’s always good to be prepared.");
            ReadKey();
            WriteLine("'Thank you.'");
            WriteLine($"You take your leave from the armorer’s shop, {CurrentPlayer.WeaponType} in hand, and once again find yourself faced with a decision. You feel like you have enough information to go on now, so it’s time to go after the ring. And yet, something makes you pause- this ring seems to have a mysterious curse that kills people who touch it. Still, the power to grant wishes is something spectacular indeed… it might be worth your while to at least LOOK for it.");
            ReadKey();
            WriteLine("\nWith your mind made up, you head out to the western road, prepared to begin your journey to find this mystical ring!");
            SeekRingPartOne(false);
        }
        public void SeekRingPartOne(bool hasGawain)
        {
            
            WriteLine("\nAs you continue down the road, feeling pretty good about your decisions- after all, today is a gorgeous day, and you haven’t seen any other treasure seekers on the road so far. As far as you’re concerned, you’re the only one who has actually bothered to go out and try to seek the ring. That is, until you stumble upon a fellow with white hair dressed in the armor of a paladin standing in the road and looking awfully lost.");
            ReadKey();
            WriteLine("What would you like to do? A. Ask him if he needs help with something or B. Ignore him. He’s probably a brigand waiting to take advantage of an unsuspecting adventurer such as yourself.");
            string responseGawainEncounter1 = ReadLine().Trim().ToUpper();

            if (responseGawainEncounter1 == "A")
            {
                WriteLine("'Excuse me, can I help you?'");
                ReadKey();
                WriteLine("\nGawain: Ah! Thank goodness. I was beginning to think that nobody ever traveled this road. My name is Gawain Axeflaw. I am a traveling paladin and I have heard tell of a dragon lurking in this area, but I’ve gotten a little turned around on my way to its lair… would you happen to know where it is?");
                ReadKey();
                WriteLine("A. 'The dragon is gone. Some knights already chased it off. I know where the lair is, though.' or B. 'Nope! Sorry!'");
                string responseGawainEncounter2 = ReadLine().Trim().ToUpper();

                if (responseGawainEncounter2 == "A")
                {
                    WriteLine("\nGawain: …I see. Well, that’s disappointing. I may as well go check the area to make sure. Are you heading that way?");
                    ReadKey();
                    WriteLine("A. 'Yes.' or B. 'No, I don't know what you're talking about.'");
                    string responseGawainEncounter3 = ReadLine().Trim().ToUpper();

                    if (responseGawainEncounter3 == "A")
                    {
                        WriteLine("\nGawain: Perfect! Would you mind if I accompanied you? I’m quite capable with a sword, should we run into any trouble, and I’ve been traveling by myself for quite some time. I think the company would do me some good.");
                        ReadKey();
                        WriteLine($"A. 'Sure, why not? The name’s {CurrentPlayer.Name}. Nice to meet you.' or B. 'No thanks. The lair is straight west of here, though.'");
                        string responseGawainComesWithYou = ReadLine().Trim().ToUpper();

                        if (responseGawainComesWithYou == "A")
                        {
                            WriteLine($"\nGawain: Well met, {CurrentPlayer.Name}! I won’t let you down.");
                            ReadKey();
                            WriteLine("Thus, Gawain joins you on your quest, and the two of you continue further down the road.");
                            hasGawain = true;
                            CurrentPlayer.Score++;
                            SeekRingPartTwo(true);
                        }
                        else
                        {
                            WriteLine("\nGawain: Very well. Thank you, friend, and safe travels! Perhaps our paths will cross again.");
                            hasGawain = false;
                            SeekRingPartTwo(false);
                        }
                    }
                    else
                    {
                        WriteLine("\nGawain: That’s a shame. Well, I’ll leave you be. Safe travels, friend.");
                        ReadKey();
                        WriteLine("You continue on your path without incident.");
                        hasGawain = false;
                        SeekRingPartTwo(false);
                    }
                }
                else
                {
                    WriteLine("\nGawain: Ah, no worries! Safe travels, friend.");
                    ReadKey();
                    WriteLine("You continue on your path without incident.");
                    hasGawain = false;
                    SeekRingPartTwo(false);
                }
            }
            else
            {
                WriteLine("\nThe paladin looks like he wants to say something to you, but ultimately thinks better of it. You walk by and continue your quest in silence.");
                hasGawain = false;
                SeekRingPartTwo(false);
            }
        }
        public void SeekRingPartTwo(bool hasGawain)
        {
            if (hasGawain == true)
            {
                WriteLine("\nThe two of you have come quite a ways on the path without any resistance when suddenly an old woman runs up to both of you, clearly in a panic.");
                ReadKey();
                WriteLine("OLD WOMAN: Brave adventurers! Please, you’ve got to help me!");
                ReadKey();
                WriteLine("Gawain: What is it?");
                ReadKey();
                WriteLine("OLD WOMAN: My poor cat Scrunkles has gotten himself stuck in a tree!");
                ReadKey();
                WriteLine($"Gawain: Oh dear… well, {CurrentPlayer.Name}, it’s your choice. What should we do?");
                ReadKey();
                WriteLine("A. 'We’ll help you out. Where is he?' or B. 'Sorry, lady, we’re on a very important quest. Hope you get him back soon.'");
                string responseEncounterOneDialogue1 = ReadLine().Trim().ToUpper();

                if (responseEncounterOneDialogue1 == "A")
                {
                    WriteLine("\nOLD WOMAN: What a relief! He’s just in that tree over there. (As she points to the tree that Scrunkles is stuck in, a sudden long and forlorn sounding yowl echoes from the depths of the tree, almost as if Scrunkles is saying 'I’m right here!!')");
                    ReadKey();
                    WriteLine("Gawain: You go first. I’ll back you up.");
                    EncounterOneCheckWithGawain();
                }
                else
                {
                    WriteLine("\nOLD WOMAN: Oh… I see… well, I’ll just wait for someone else, then…");
                    ReadKey();
                    WriteLine($"Gawain: (whispering) {CurrentPlayer.Name}, are you sure this is the right choice?");
                    ReadKey();
                    WriteLine("A. 'Yes.' or B. 'No.'");
                    string responseEncounterOneDialogue2 = ReadLine().Trim().ToUpper();

                    if (responseEncounterOneDialogue2 == "A")
                    {
                        WriteLine("\nGawain: Alright. Good day to you, friend. I hope you find a solution to your problem soon.");
                        ReadKey();
                        WriteLine("OLD WOMAN: (talking to herself) Oh, Scrunkles…");
                        ReadKey();
                        WriteLine("You and Gawain continue on your adventure, leaving the old woman behind to fret over her cat. Womp womp.");
                        SeekRingPartThree(true);
                    }
                    else
                    {
                        WriteLine("Gawain: We’ll help you after all.");
                        ReadKey();
                        WriteLine("OLD WOMAN: What a relief!");
                        EncounterOneCheckWithGawain();
                    }
                }
            }
            else
            {
                WriteLine("\nYou have come quite a ways on the path without any resistance when suddenly an old woman runs up to you, clearly in a panic.");
                ReadKey();
                WriteLine("\nOLD WOMAN: Brave adventurer! Please, you’ve got to help me! My poor cat Scrunkles has gotten himself stuck in a tree!");
                ReadKey();
                WriteLine("A. 'That doesn’t sound good! I’ll help you out.' or B. 'Sorry, lady, I’m on a very important quest. I hope you get him back soon.'");
                string responseEncounterOneDialogue1Alt = ReadLine().Trim().ToUpper();

                if (responseEncounterOneDialogue1Alt == "A")
                {
                    WriteLine("\nOLD WOMAN: What a relief! He’s just in that tree over there. (As she points to the tree that Scrunkles is stuck in, a sudden long and forlorn sounding yowl echoes from the depths of the tree, almost as if Scrunkles is saying 'I’m right here!!')");
                    EncounterOneCheckWithoutGawain();
                }
                else
                {
                    WriteLine("\nOLD WOMAN: Oh… I see… well, I’ll just wait for someone else, then…");
                    ReadKey();
                    WriteLine("\nYou shrug and continue on your adventure, leaving the old woman behind to fret over her cat. Womp womp.");
                    SeekRingPartThree(false);
                }
            }
        }
        public void EncounterOneCheckWithGawain()
        {
            DiceRoll.Roll();

            if (Roll >= 7)
            {
                WriteLine("\nYou walk up to the base of the tree and crack your knuckles. Time to show this tree who’s boss!! You swiftly, but carefully, make your way up the tree and locate Scrunkles. He is, of course, located at the very top of the tree with his claws dug firmly into the bark and an abject look of terror on his face. At least, if such a look could be said to be present on the face of a cat. Carefully, you hold your hand out to him and make soft 'pspspspsps' noises at him until he detaches from the bark long enough to crawl over to you. He then proceeds to dig his nails into the thin fabric of your shirt. If you were a weaker person, you might have let go of the tree in shock. Thankfully, you retain your grip and manage to make it back down the tree with no issues. You hand Scrunkles over to the old woman. He’s all too happy to get away from you. Typical cats.");
                ReadKey();
                WriteLine("OLD WOMAN: Scrunkles!! My baby!! Oh, thank you so much. I don’t know however I can repay you.");
                ReadKey();
                WriteLine($"Gawain: Don’t worry about it. Nice work,{CurrentPlayer.Name}!");
                ReadKey();
                WriteLine("OLD WOMAN: Thank you again!!");
                ReadKey();
                WriteLine("Thus, Gawain and you continue on your little adventure, though you’re significantly more scratched up than before.");
                CurrentPlayer.Score++;
                SeekRingPartThree(true);
            }
            else
            {
                WriteLine("\nYou approach the tree, feeling a little apprehensive about all of this. You’ve never really been the best with heights. Regardless, you said you’d do it, so it’s time to give it your best shot! You start climbing the tree, feeling your nerves grow as you get higher up. Where is that stupid cat?? Unfortunately, just as you spot the cat, you place your foot on a weak branch, and it snaps under your weight! You fall dramatically to the ground, ego bruised and wind knocked out of you.");
                ReadKey();
                WriteLine("OLD WOMAN: Are you okay, dearie??");
                ReadKey();
                WriteLine("You are unfortunately too dazed to respond.");
                ReadKey();
                WriteLine("Gawain: Here, let me try.");
                ReadKey();
                WriteLine("Gawain scales the tree easily and retrieves Scrunkles without incident. You’re a little jealous of his ease from your space on the ground. Thankfully, some of your wits have returned to you in the time it took him to climb the tree and come back down again.");
                ReadKey();
                WriteLine("OLD WOMAN: Scrunkles!! My baby!! Oh, thank you so much. I don’t know however I can repay you. I hope you feel better, brave hero.");
                ReadKey();
                WriteLine("You give the old woman a weak thumbs up as Gawain helps you off the ground. Then, the two of you continue on your way. You’re still a little dazed, but you can walk. Onward, to adventure!");
                CurrentPlayer.Score++;
                SeekRingPartThree(true);
            }
        }
        public void EncounterOneCheckWithoutGawain()
        {
            DiceRoll.Roll();

            if (Roll >= 7)
            {
                WriteLine("\nYou walk up to the base of the tree and crack your knuckles. Time to show this tree who’s boss!! You swiftly, but carefully, make your way up the tree and locate Scrunkles. He is, of course, located at the very top of the tree with his claws dug firmly into the bark and an abject look of terror on his face. At least, if such a look could be said to be present on the face of a cat. Carefully, you hold your hand out to him and make soft 'pspspspsps' noises at him until he detaches from the bark long enough to crawl over to you. He then proceeds to dig his nails into the thin fabric of your shirt. If you were a weaker person, you might have let go of the tree in shock. Thankfully, you retain your grip and manage to make it back down the tree with no issues. You hand Scrunkles over to the old woman. He’s all too happy to get away from you. Typical cats.");
                ReadKey();
                WriteLine("OLD WOMAN: Scrunkles!! My baby!! Oh, thank you so much. I don’t know however I can repay you.");
                ReadKey();
                WriteLine("You give the old woman a thumbs up and then continue on your way, though you’re significantly more scratched up than before.");
                CurrentPlayer.Score++;
                SeekRingPartThree(false);
            }
            else
            {
                WriteLine("\nYou approach the tree, feeling a little apprehensive about all of this. You’ve never really been the best with heights. Regardless, you said you’d do it, so it’s time to give it your best shot! You start climbing the tree, feeling your nerves grow as you get higher up. Where is that stupid cat?? Unfortunately, just as you spot the cat, you place your foot on a weak branch, and it snaps under your weight! You fall dramatically to the ground, ego bruised and wind knocked out of you.");
                ReadKey();
                WriteLine("OLD WOMAN: Are you okay, dearie??");
                ReadKey();
                WriteLine("You are unfortunately too dazed to respond.");
                ReadKey();
                WriteLine("OLD WOMAN: Goodness. Well, I’ll let you recover, but you don’t have to worry about saving Scrunkles. I’ll wait for somebody else. I don’t want you getting too hurt.");
                ReadKey(); 
                WriteLine("You give her a nod, and then close your eyes and wait for the world to stop spinning. Eventually, you’re able to gather your wits about you enough to stand up and start moving again, but not without a significant amount of embarrassment. Adventure?");
                SeekRingPartThree(false);
            }
        }
        public void SeekRingPartThree(bool hasGawain)
        {
            if (hasGawain == true)
            {
                WriteLine("\nYou and Gawain have been traveling for quite some time now. Your village is now mostly a smudge on the horizon. Not that you look back at it frequently enough to tell. That being said, your journey doesn’t seem like it will be over very quickly. Still, things are going well, and you feel optimistic. Gawain has been sharing tales of his travels as you walk, and it’s quite enlightening. However, as you’re walking, you spot a fox caught in a trap on the side of the road. It looks as though it is in a great deal of pain.");
                ReadKey();
                WriteLine("Gawain: Oh dear. That poor fox…");
                ReadKey();
                WriteLine("A. 'We should do something about it.' or B. 'Who cares? That trap was left there for a reason.'");
                string responseEncounterTwoDialogue1 = ReadLine().Trim().ToUpper();

                if (responseEncounterTwoDialogue1 == "A")
                {
                    WriteLine("Gawain: I agree. Up to you.");
                    EncounterTwoCheckWithGawain();
                }
                else
                {
                    WriteLine("\nGawain: Well, if that’s what you think is best.");
                    ReadKey();
                    WriteLine("A. 'Yeah, it is.' or B. 'Wait, maybe not…");
                    string responseEncounterTwoDialogue2 = ReadLine().Trim().ToUpper();

                    if (responseEncounterTwoDialogue2 == "A")
                    {
                        WriteLine("\nGawain: Alright. Let us be off, then.");
                        ReadKey();
                        WriteLine("The two of you continue on your journey. The fox watches you go, struggling weakly against the trap. But you don’t notice, because you’re already focused on the path ahead.");
                        SeekRingPartFour(true);
                    }
                    else
                    {
                        WriteLine("\nGawain: Changed your mind? Very well, you go first.");
                        EncounterTwoCheckWithGawain();
                    }
                }
            }
            else
            {
                WriteLine("\nYou have been traveling for quite some time now. Your village is now mostly a smudge on the horizon. Not that you look back at it frequently enough to tell. That being said, your journey doesn’t seem like it will be over very quickly. Still, things are going well, and you feel optimistic. You’ve always been one to enjoy your own company the most over anybody else. However, as you’re walking, you spot a fox caught in a trap on the side of the road. It looks as though it is in a great deal of pain. You can’t help but stop and wonder if you should do something.");
                ReadKey();
                WriteLine("What will you do? A. Free the fox or B. Ignore it and move on");
                string responseEncounterTwoDialogue1Alt = ReadLine().Trim().ToUpper();

                if (responseEncounterTwoDialogue1Alt == "A")
                {
                    WriteLine("\nAfter a moment of deliberation, you decide that it’s for the best if you free the fox.");
                    EncounterTwoCheckWithoutGawain();
                }
                else
                {
                    WriteLine("\nWith a shrug, you decide that it’s best to just leave it be. You start down the path again, already thinking about the dragon’s lair that still lies ahead. The fox watches you go, struggling weakly against the trap. But you don’t notice, because you’re already focused on the path ahead.");
                    SeekRingPartFour(false);
                }
            }
        }
        public void EncounterTwoCheckWithGawain()
        {
            DiceRoll.Roll();

            if (Roll >= 10)
            {
                WriteLine("\nYou carefully kneel down by the fox, moving slowly so as not to startle it, and take a look at the trap. The mechanisms of the trap are familiar enough to you, as you’ve set many traps like this around your family’s farm. So, with that in mind, you set about disabling it. The fox peers nervously up at you as you work. Finally, after some trial and error, you manage to disable it, freeing the fox! It doesn’t waste time limping away, but you’ve at least ensured that it is free to live as it pleases. What happens next is up to nature.");
                ReadKey();
                WriteLine("Gawain: Nice work! I sure hope that fox stays out of trouble from now on.");
                ReadKey();
                WriteLine("You nod in agreement as you watch the spot where it disappears for a moment, then you stand up and brush the encounter out of your mind. Time to continue on your merry way. Adventure!");
                CurrentPlayer.Score++;
                SeekRingPartFour(true);
            }
            else
            {
                WriteLine("\nYou carefully kneel down by the fox, moving slowly so as not to startle it, and take a look at the trap. You’re somewhat familiar with the mechanisms of a trap like this, given that you’ve set them before on your family’s farm. Unfortunately, as you go about trying to disable it, you accidentally cut your hand on a sharp part of the trap. You recoil in shock, cradling your injured hand, and the fox twitches in alarm. Or possibly with hunger from the scent of blood. Either way, you back away from it, holding your bleeding hand and feeling a little bit foolish.");
                ReadKey(); 
                WriteLine("Gawain: That looks painful. Here, I’ll take care of the fox. You wrap your hand with this. (he tosses a bandage at you).");
                ReadKey();
                WriteLine("You oblige without another word. Your pride is more injured than your hand is, but you’ll live. Gawain quickly- and safely- disables the trap, leaving the fox to run off. ");
                ReadKey();
                WriteLine("Gawain: Be free, little one. (He stands up and looks at you.) Are you alright?");
                ReadKey();
                WriteLine("A. 'Yeah. It’s just a scratch.' or B. 'No, I’m dying. This is it for me.'");
                string responseEncounterTwoDialogue3 = ReadLine().Trim().ToUpper();

                if (responseEncounterTwoDialogue3 == "A")
                {
                    WriteLine("\nGawain: I’m glad. Let’s continue, shall we?");
                    ReadKey(); 
                    WriteLine("And so the two of you continue on your journey! The ache in your hand gradually starts to subside as you focus on the path ahead rather than your little mistake.");
                    CurrentPlayer.Score++;
                    SeekRingPartFour(true);
                }
                else
                {
                    WriteLine("\nGawain: Sounds most grievous indeed. I will ensure to carry on your legacy, my friend. (after a moment, he breaks character and laughs.) Ah, that was a good one. Are you sure you’re alright, though?");
                    ReadKey();
                    WriteLine("You nod and give him a thumbs up. Reassured, Gawain nods in acknowledgement and then the two of you continue on your journey.");
                    CurrentPlayer.Score++;
                    SeekRingPartFour(true);
                }
            }
        }
        public void EncounterTwoCheckWithoutGawain()
        {
            DiceRoll.Roll();

            if (Roll >= 10)
            {
                WriteLine("\nYou carefully kneel down by the fox, moving slowly so as not to startle it, and take a look at the trap. The mechanisms of the trap are familiar enough to you, as you’ve set many traps like this around your family’s farm. So, with that in mind, you set about disabling it. The fox peers nervously up at you as you work. Finally, after some trial and error, you manage to disable it, freeing the fox! It doesn’t waste time limping away, but you’ve at least ensured that it is free to live as it pleases. What happens next is up to nature.");
                ReadKey();
                WriteLine("With that done, you continue on your merry way. Adventure!");
                CurrentPlayer.Score++;
                SeekRingPartFour(false);
            }
            else
            {
                WriteLine("\nYou carefully kneel down by the fox, moving slowly so as not to startle it, and take a look at the trap. You’re somewhat familiar with the mechanisms of a trap like this, given that you’ve set them before on your family’s farm. Unfortunately, as you go about trying to disable it, you accidentally cut your hand on a sharp part of the trap. You recoil in shock, cradling your injured hand, and the fox twitches in alarm. Or possibly with hunger from the scent of blood. This sudden movement also triggered the trap to get even tighter. The fox squeaks and thrashes around, clearly choking now. Horrified, you back away, holding your bloodied hand to your chest. You flee the scene, waiting until you’re much farther down the road before you stop to bandage your hand.");
                ReadKey();
                WriteLine("The memory of what happened weighs heavily on you as you continue down the path. You’re starting to wonder if you should be doing any of this in the first place.");
                SeekRingPartFour(false);
            }
        }
        public void SeekRingPartFour(bool hasGawain)
        {
            if (hasGawain == true)
            {
                WriteLine("\nYour enthusiasm for this journey is starting to wane a little bit. It’s been a solid half a day of traveling by now, with nothing but the occasional farm to break up the monotony of this dusty path. Making matters worse, it hardly ever curves to make things interesting. But you’ve come too far to give up now! Gawain’s company makes this much easier on you, to be entirely honest. Just as you’re starting to think about how bored you are, a young farmer and her wife who had previously been standing by the edge of the road call out to you and Gawain.");
                ReadKey();
                WriteLine("FARMER: Hey there! Could we bother you two adventurers for a moment of your time?");
                ReadKey();
                WriteLine("A. 'Yeah, sure. What’s wrong?' or B. 'No, we’re busy. Sorry.'");
                string responseEncounterThreeDialogue1 = ReadLine().Trim().ToUpper();

                if (responseEncounterThreeDialogue1 == "A")
                {
                    WriteLine("\nFARMER: Thank goodness. Well, you see, my wife and I are in a bit of a predicament. Somebody unlatched the gate of our cow pasture, and now our herd is all over the place! We don’t have a herding dog to help us get them back in line, and with just the two of us this is an awfully difficult task.");
                    ReadKey();
                    WriteLine("Gawain: Ah, I see. Sounds like a difficult situation. We’d be happy to help.");
                    EncounterThreeCheckWithGawain();
                }
                else
                {
                    WriteLine("FARMER’S WIFE: Ah, we understand. No worries!");
                    ReadKey(); 
                    WriteLine("Gawain: (whispering) Are you sure this is the right choice?");
                    ReadKey();
                    WriteLine("A. 'Yes. I want to get this quest over with.' or 'Wait, maybe not…'");
                    string responseEncounterThreeDialogue2 = ReadLine().Trim().ToUpper();

                    if (responseEncounterThreeDialogue2 == "A")
                    {
                        WriteLine("\nGawain: Alright then. Farewell, you two. I hope you’re able to resolve your problem.");
                        ReadKey();
                        WriteLine("FARMER: Yes, thank you. Good luck on your journey!");
                        ReadKey();
                        WriteLine("So, you and Gawain continue on your way. Your impatience with this whole quest has only increased.");
                        SeekRingPartFive(true);
                    }
                    else
                    {
                        WriteLine("\nGawain: Actually, we’ll help you out. What’s the matter?");
                        ReadKey();
                        WriteLine("FARMER: Oh, thank you so much! Somebody unlatched the gate of our cow pasture, and now our herd is all over the place! We don’t have a herding dog to help us get them back in line, and with just the two of us this is an awfully difficult task.");
                        ReadKey();
                        WriteLine("Gawain: Ah, I see. Not to worry, we’ve got your backs.");
                        EncounterThreeCheckWithGawain();
                    }
                }
            }
            else
            {
                WriteLine("\nYour enthusiasm for this journey is starting to wane a little bit. It’s been a solid half a day of traveling by now, with nothing but the occasional farm to break up the monotony of this dusty path. Making matters worse, it hardly ever curves to make things interesting. But you’ve come too far to give up now! Just as you’re starting to think about how bored you are, a young farmer and her wife who had previously been standing by the edge of the road call out to you.");
                ReadKey();
                WriteLine("FARMER: Hey there! Could we bother you for a moment of your time?");
                ReadKey();
                WriteLine("A. 'Yeah, sure. What’s wrong?' or B. 'No, I’m busy. Sorry.'");
                string responseEncounterThreeDialogue1Alt = ReadLine().Trim().ToUpper();

                if (responseEncounterThreeDialogue1Alt == "A")
                {
                    WriteLine("\nFARMER: Thank goodness. Well, you see, my wife and I are in a bit of a predicament. Somebody unlatched the gate of our cow pasture, and now our herd is all over the place! We don’t have a herding dog to help us get them back in line, and with just the two of us this is an awfully difficult task.");
                    ReadKey();
                    WriteLine("You nod along with the explanation. Having heard what the problem is, now you’ve got to decide if you’ll help or not. What will you do? A. Help out or B. Move on");
                    string responseEncounterThreeDialogue2Alt = ReadLine().Trim().ToUpper();

                    if (responseEncounterThreeDialogue2Alt == "A")
                    {
                        WriteLine("\n'I'll help you!'");
                        ReadKey();
                        WriteLine("FARMER’S WIFE: Thank you so much!");
                        EncounterThreeCheckWithoutGawain();
                    }
                    else
                    {
                        WriteLine("\n'I would, but I’m busy. Sorry.'");
                        ReadKey();
                        WriteLine("FARMER’S WIFE: Ah, no worries. Safe travels!");
                        WriteLine("Thus, you continue on your way. Your impatience with this whole quest has only increased. Seriously, is it that hard to just let you go in peace??");
                        SeekRingPartFive(false);
                    }
                }
                else
                {
                    WriteLine("\nFARMER’S WIFE: Ah, we understand. No worries!");
                    ReadKey();
                    WriteLine("Thus, you continue on your way. Your impatience with this whole quest has only increased. Seriously, is it that hard to just let you go in peace??");
                    SeekRingPartFive(false);
                }
            }
        }
        public void EncounterThreeCheckWithGawain()
        {
            DiceRoll.Roll();

            if (Roll >= 13)
            {
                WriteLine("\nYou and Gawain head out into the field with the couple, where the cows are scattered all about and munching happily on some grass. It takes you a little bit to work out a rhythm between the four of you, but once you manage it, everything goes very smoothly. In no time at all you’ve got all the cows moving back towards their pasture! As soon as the farmer’s wife closes the gate behind the last cow, all four of you breathe a tremendous sigh of relief.");
                ReadKey();
                WriteLine("FARMER: Thank you so much for all of your help. I fear we would’ve been out here all day otherwise!");
                ReadKey();
                WriteLine("Gawain: It’s no problem.");
                ReadKey(); 
                WriteLine("A. 'You may want to invest in a herding dog, just in case.' or B. 'I’m just glad we were able to help!");
                string responseEncounterThreeDialogue3 = ReadLine().Trim().ToUpper();

                if (responseEncounterThreeDialogue3 == "A")
                {
                    WriteLine("\nFARMER: Haha, yes, that may be smart. Good luck on the rest of your journey!");
                    ReadKey();
                    WriteLine("FARMER’S WIFE: Yes, best of luck to the both of you! We can’t repay you enough.");
                    ReadKey();
                    WriteLine("With that, you and Gawain set off once more. You feel distinctly more energized to complete your quest now. Boredom begone, for the adventure continues!");
                    CurrentPlayer.Score++;
                    SeekRingPartFive(true);
                }
                else
                {
                    WriteLine("\nFARMER’S WIFE: Once again, thank you so much. We can’t repay you enough!");
                    ReadKey();
                    WriteLine("FARMER: Yes, indeed. We wish you luck!");
                    ReadKey();
                    WriteLine("With that, you and Gawain set off once more. You feel distinctly more energized to complete your quest now. Boredom begone, for the adventure continues!");
                    CurrentPlayer.Score++;
                    SeekRingPartFive(true);
                }
            }
            else
            {
                WriteLine("\nYou and Gawain head out into the field with the couple, where the cows are scattered all about and munching happily on some grass. Unfortunately, you just can’t seem to work out a rhythm to get all of the cows to head back to the pasture! Somebody always keeps getting off, or a single cow wanders away for some reason and all of the others follow suit. All four of you are starting to get quite frustrated. Finally, though, Gawain has the idea to use his cape as a flag to make things easier on all of you. Once this breakthrough happens, everything goes much smoother, and you’re able to herd all of the cows back to the pasture.");
                ReadKey();
                WriteLine("FARMER: I’m sorry for all of the hassle! That took much longer than I was expecting.");
                ReadKey();
                WriteLine("Gawain: Ah, it’s no trouble. Sometimes that happens.");
                ReadKey();
                WriteLine("FARMER’S WIFE: Still, we can’t repay you enough. Thank you so much for all of your help, truly.");
                ReadKey();
                WriteLine("FARMER: We wish you best of luck on your journey!");
                ReadKey();
                WriteLine("A. 'Thank you!!' or B. 'Thank you, and don’t forget to invest in a herding dog!'");
                string responseEncounterThreeDialogue4 = ReadLine().Trim().ToUpper();

                if (responseEncounterThreeDialogue4 == "A")
                {
                    WriteLine("\nWithout further ado, you and Gawain head back to the path to continue your adventure, feeling exhausted but very pleased with the work you’ve done. Your enthusiasm for the journey has returned in full force!");
                    CurrentPlayer.Score++;
                    SeekRingPartFive(true);
                }
                else
                {
                    WriteLine("\nFARMER: Haha, yes, that may be smart.");
                    ReadKey(); 
                    WriteLine("Without further ado, you and Gawain head back to the path to continue your adventure, feeling exhausted but very pleased with the work you’ve done. Your enthusiasm for the journey has returned in full force!");
                    CurrentPlayer.Score++;
                    SeekRingPartFive(true);
                }
            }
        }
        public void EncounterThreeCheckWithoutGawain()
        {
            DiceRoll.Roll();

            if (Roll >= 13)
            {
                WriteLine("\nYou head out into the field with the couple, where the cows are scattered all about and munching happily on some grass. It takes you a little bit to work out a rhythm between the three of you, but once you manage it, everything goes very smoothly. In no time at all you’ve got all the cows moving back towards their pasture! As soon as the farmer’s wife closes the gate behind the last cow, all three of you breathe a tremendous sigh of relief.");
                ReadKey();
                WriteLine("FARMER: Thank you so much for all of your help. I fear we would’ve been out here all day otherwise!");
                ReadKey();
                WriteLine("A. 'No problem. Although… you may want to invest in a herding dog, just in case.' or B. 'I’m just glad I was able to help!'");
                string responseEncounterThreeDialogue3Alt = ReadLine().Trim().ToUpper();

                if (responseEncounterThreeDialogue3Alt == "A")
                {
                    WriteLine("\nFARMER: Haha, yes, that may be smart. Good luck on the rest of your journey!");
                    ReadKey();
                    WriteLine("FARMER’S WIFE: Yes, best of luck to you! We can’t repay you enough.");
                }
                else
                {
                    WriteLine("\nFARMER’S WIFE: Once again, thank you so much. We can’t repay you enough!");
                    ReadKey();
                    WriteLine("FARMER: Yes, indeed. We wish you luck!");
                }
                WriteLine("\nWith that, you set off once more. You feel distinctly more energized to complete your quest now. Boredom begone, for the adventure continues!");
                CurrentPlayer.Score++;
                SeekRingPartFive(false);
            }
            else
            {
                WriteLine("\nYou head out into the field with the couple, where the cows are scattered all about and munching happily on some grass. Unfortunately, you just can’t seem to work out a rhythm to get all of the cows to head back to the pasture! Somebody always keeps getting off, or a single cow wanders away for some reason and all of the others follow suit. The final straw turns out to be you stepping in an unseen divot in the field and twisting your ankle.");
                ReadKey();
                WriteLine("FARMER: Oh dear. I think we should call it quits for today. I’m so sorry! Are you alright?");
                ReadKey();
                WriteLine("A. 'I’ll be okay.' or B. 'Sorry that I wasn’t very helpful… but yes, I’m fine.'");
                string responseEncounterThreeDialogue4Alt = ReadLine().Trim().ToUpper();

                if (responseEncounterThreeDialogue4Alt  == "A")
                {
                    WriteLine("\nFARMER’S WIFE: I hope this doesn’t impede your adventure too much…");
                }
                else
                {
                    WriteLine("\nFARMER’S WIFE: Don’t even worry about it! The most important thing is that you’re okay. We asked for your help, after all.");
                }
                WriteLine("\nThe two of them let you rest in their farmhouse for a little while to let you recover, and then it’s back to the road for you. This is seeming like more and more of a bad idea by the minute, but you persevere. Adventure!");
                SeekRingPartFive(false);
            }
        }
        public void SeekRingPartFive(bool hasGawain)
        {
            if (hasGawain == true)
            {
                WriteLine("\nAt long last, the dragon’s lair is in view. You are filled with a deep sense of relief upon seeing the ominous mouth of the cave where you know the treasure lies, which is something that you can’t say you’ve ever expected to feel upon seeing a cave like that. Gawain nods his head resolutely, seemingly making up his mind about something.");
                ReadKey();
                WriteLine("Gawain: Well, this is it. Are you ready?");
                ReadKey();
                WriteLine("A. 'I was born ready.' or B. 'No… but I’ll do it anyway.'");
                string responseFinalEncounterDialogue1 = ReadLine().Trim().ToUpper();

                if (responseFinalEncounterDialogue1 == "A")
                {
                    WriteLine("\nGawain: That’s what I like to hear! In we go.");
                }
                else
                {
                    WriteLine("\nGawain: Ah, you’ll do great. I’ve got your back!");
                }
                WriteLine("\nThe two of you enter the dragon’s lair. Piles and piles of gold and trinkets are stacked around a massive hollow where the dragon must have slept. At this rate it’ll take you forever to find the ring… but there’s nothing to do but get searching. That is, until you notice a skeleton in the center of the room with something gripped tightly in its bony hands. The sight of the skeleton makes you pause, but you and Gawain approach it all the same. Gawain breaks the skeleton’s grip and a plain golden ring clatters to the ground. Before you can let your fears get the better of you, you pick it up. Immediately, a ghostly voice echoes in your ear.");
                ReadKey();
                FinalEncounterCheckWithGawain();
            }
            else
            {
                WriteLine("\nAt long last, the dragon’s lair is in view. You are filled with a deep sense of relief upon seeing the ominous mouth of the cave where you know the treasure lies, which is something that you can’t say you’ve ever expected to feel upon seeing a cave like that. This is it! Your journey is at an end! What a relief.");
                ReadKey();
                WriteLine("You enter the dragon’s lair. Piles and piles of gold and trinkets are stacked around a massive hollow where the dragon must have slept. At this rate it’ll take you forever to find the ring… but there’s nothing to do but get searching. That is, until you notice a skeleton in the center of the room with something gripped tightly in its bony hands. The sight of the skeleton makes you pause, but you approach it all the same. You break the skeleton’s grip and a plain golden ring clatters to the ground. Before you can let your fears get the better of you, you pick it up. Immediately, a ghostly voice echoes in your ear.");
                FinalEncounterCheckWithoutGawain();
            }
        }
        public void FinalEncounterCheckWithGawain()
        {
            WriteLine("MYSTERIOUS VOICE: So… you think you’re worthy of the ring? Tell me, if I asked what you intend to do with the ring, will you be honest or will you lie?");
            ReadKey();
            WriteLine("What will you do? A. Be honest or B. Lie about your intentions");
            string responseFinalEncounterDialogue2 = ReadLine().Trim().ToUpper();

            if (responseFinalEncounterDialogue2 == "A")
            {
                WriteLine("\nMYSTERIOUS VOICE: Very well.");
                CurrentPlayer.Score++;
            }
            else
            {
                WriteLine("MYSTERIOUS VOICE: I see.");
            }
            WriteLine("MYSTERIOUS VOICE: Will you take the ring? (yes/no)");
            string responseFinalEncounterChoice = ReadLine().Trim().ToLower();

            if (responseFinalEncounterChoice == "yes")
            {
                if (CurrentPlayer.Score >= 4)
                {
                    WriteLine("\nMYSTERIOUS VOICE: You are pure of heart enough to handle the ring. May you use its power for good, always, and never stray from your just path.");
                    WinConditions.WinConditionsMetLeft(true);
                }
                else
                {
                    WriteLine("\nMYSTERIOUS VOICE: You are not pure of heart enough to handle the ring. Begone, foul beast.");
                    LoseConditions.LoseNotEnoughPointsLeft(true);
                }
            }
            else
            {
                WriteLine("\nMYSTERIOUS VOICE: Then put the ring down and walk away, never to handle it again upon pain of death.");
                LoseConditions.LoseRefuseTheCall(true);
            }
        }
        public void FinalEncounterCheckWithoutGawain()
        {
            WriteLine("MYSTERIOUS VOICE: So… you think you’re worthy of the ring? Tell me, if I asked what you intend to do with the ring, will you be honest or will you lie?");
            ReadKey();
            WriteLine("What will you do? A. Be honest or B. Lie about your intentions");
            string responseFinalEncounterDialogue2 = ReadLine().Trim().ToUpper();

            if (responseFinalEncounterDialogue2 == "A")
            {
                WriteLine("\nMYSTERIOUS VOICE: Very well.");
                CurrentPlayer.Score++;
            }
            else
            {
                WriteLine("MYSTERIOUS VOICE: I see.");
            }
            WriteLine("MYSTERIOUS VOICE: Will you take the ring? (yes/no)");
            string responseFinalEncounterChoice = ReadLine().Trim().ToLower();

            if (responseFinalEncounterChoice == "yes")
            {
                if (CurrentPlayer.Score >= 4)
                {
                    WriteLine("\nMYSTERIOUS VOICE: You are pure of heart enough to handle the ring. May you use its power for good, always, and never stray from your just path.");
                    WinConditions.WinConditionsMetLeft(false);
                }
                else
                {
                    WriteLine("\nMYSTERIOUS VOICE: You are not pure of heart enough to handle the ring. Begone, foul beast.");
                    LoseConditions.LoseNotEnoughPointsLeft(false);
                }
            }
            else
            {
                WriteLine("\nMYSTERIOUS VOICE: Then put the ring down and walk away, never to handle it again upon pain of death.");
                LoseConditions.LoseRefuseTheCall(false);
            }
        }
    }
}
