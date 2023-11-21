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
        private Win WinConditions;
        private Lose LoseConditions;
        private Random DiceRoll;
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
            ReadKey();
            WriteLine("A. 'Afternoon. Did I miss anything interesting?' or B. 'Hey. You seem a little distracted- everything okay?'");
            string responseBeginningDialogue1 = ReadLine().Trim().ToUpper();

            if (responseBeginningDialogue1 == "A")
            {
                WriteLine($"\n{CurrentFriend.BestFriendName}: You know, the usual. Apparently there’s a magic ring that grants wishes stashed in the dragon’s hoard nearby.");
                ReadKey();
                WriteLine("You blink blankly at your best friend in shock, unsure that you heard them correctly.");
                ReadKey();
                WriteLine($"{CurrentFriend.BestFriendName}: You heard me right. A magic ring. It’s too late to go after it, though. Someone else has already organized a whole adventuring party to go get it. Really sucks, y’know?");
                ReadKey();
                WriteLine("A. 'Oh man. That DOES suck.' or B. 'Eh, I don’t care about stuff like that anyway. Are there any tasks for us to do?'");
                string responseBeginningDialogue2 = ReadLine().Trim().ToUpper();

                if (responseBeginningDialogue2 == "A")
                {
                    WriteLine($"\n{CurrentFriend.BestFriendName}: I know!!! Ugh. Well, no use dwelling on it, I guess. The old man gave me a list of requests. Look ‘em over and see what you think.");
                    ListOfTasks(true);
                }
                else
                {
                    WriteLine($"\n{CurrentFriend.BestFriendName}: Boy are there ever. Here, take a look.");
                    ListOfTasks(true);
                }
            }
            else
            {
                WriteLine($"\n{CurrentFriend.BestFriendName}: Hmm? Oh, yes, I’m fine. Apparently there’s a magic ring that grants wishes stashed in the dragon’s hoard nearby and I can’t stop thinking about it. Somebody else has already gone after it with a whole adventuring party, though, so it’s a bust.");
                ReadKey();
                WriteLine("A. 'Well, that sucks.' or B. 'Aww man. Would’ve been cool to go do that for a change.'");
                string responseBeginningDialogue3 = ReadLine().Trim().ToUpper();

                if (responseBeginningDialogue3 == "A")
                {
                    WriteLine($"\n{CurrentFriend.BestFriendName}: Sure does. No use dwelling on it, sadly. Got a list of requests from the old man. Take a look.");
                    ListOfTasks(true);
                }
                else
                {
                    WriteLine($"\n{CurrentFriend.BestFriendName}: Yeahhhh. Oh well. For now, I’ve got a list of requests from the old man. Here, take a look.");
                    ListOfTasks(true);
                }
            }
        }
        public void ListOfTasks(bool hasBestFriend)
        {
            WriteLine("\nYour best friend hands over a piece of paper in the village chief’s unmistakeable handwriting. The two of you have been known to handle little requests from the townspeople in exchange for education from the chief, who you affectionately refer to as the 'old man.' The list reads as follows:");
            List<string> tasks = new List<string>();

            tasks.Add("1. Save Elle's cat");
            tasks.Add("2. Clear cobwebs from the rafters of Greg’s house");
            tasks.Add("3. Build a fence for Darcey");
            tasks.Add("4. Apothecary’s task");

            for (int t = 0; t < tasks.Count; t++)
            {
                WriteLine(tasks[t]);
            }

            WriteLine($"\n{CurrentFriend.BestFriendName}: Do you want to do it together or am I off the hook for today?");
            WriteLine("A. 'Let’s do it together.' or B. 'You’re good for today, assuming you take care of stuff tomorrow.'");
            string responseTakeBestFriend = ReadLine().Trim().ToUpper();

            if (responseTakeBestFriend == "A")
            {
                WriteLine($"\n{CurrentFriend.BestFriendName}: Alright, radical! Where should we start?");
                ReadKey();
                WriteLine("(Please choose 1, 2, 3, or 4.)");
                CurrentPlayer.Score++;
                hasBestFriend = true;
                string reponseEncounterChoice1 = ReadLine();

                if (reponseEncounterChoice1 == "1")
                {
                    tasks.Remove("1. Save Elle's cat ");
                    EncounterOne();
                }
                else if (reponseEncounterChoice1 == "2")
                {
                    tasks.Remove("2. Clear cobwebs from the rafters of Greg’s house");
                    EncounterTwo();
                }
                else if (reponseEncounterChoice1 == "3")
                {
                    tasks.Remove("3. Build a fence for Darcey");
                    EncounterThree();
                }
                else
                {
                    tasks.Remove("4. Apothecary’s task");
                    EncounterFour();
                }
            }
            else
            {
                WriteLine($"\n{CurrentFriend.BestFriendName}: Cool, cool. No worries, I got it.");
                ReadKey();
                WriteLine("(Please choose 1, 2, 3, or 4.)");
                hasBestFriend = false;
                string responseEncounterChoice2 = ReadLine();

                if (responseEncounterChoice2 == "1")
                {
                    tasks.Remove("1. Save Elle's cat ");
                    EncounterOne();
                }
                else if (responseEncounterChoice2 == "2")
                {
                    tasks.Remove("2. Clear cobwebs from the rafters of Greg’s house");
                    EncounterTwo();
                }
                else if (responseEncounterChoice2 == "3")
                {
                    tasks.Remove("3. Build a fence for Darcey");
                    EncounterThree();
                }
                else
                {
                    tasks.Remove("4. Apothecary’s task");
                    EncounterFour();
                }
            }
            void EncounterOne()
            {
                if (hasBestFriend == true)
                {
                    WriteLine("\nThe two of you decide to go check out what this first option, 'save Elle’s cat,' could possibly entail. You head over to Elle’s house, which is a little on the far side from the center of the town. A single large tree stands in the yard, and Elle herself stands beneath it, looking rather concerned.");
                    ReadKey();
                    WriteLine("Elle: Oh, Mr. Ted, come down please! I know you can do it!");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: Elle! Heard you’re having trouble with your cat?");
                    ReadKey();
                    WriteLine("Elle: Boy am I ever. Mr. Ted got spooked this morning and ran up into that tree, and he hasn’t come down since. I’m really worried about him…");
                    ReadKey();
                    WriteLine("A. 'That’s not good. We’re here to help with that!' or B, 'Oof, sounds rough. Anyway, we’re just passing through. Hope you get him back soon.'");
                    string responseEllesCat1 = ReadLine().Trim().ToUpper();

                    if (responseEllesCat1 == "A")
                    {
                        WriteLine("Elle: What a relief! I knew I could count on you two.");
                        ReadKey();
                        WriteLine($"{CurrentFriend.BestFriendName}: You’re up first.");
                        EncounterOneCheckWithFriend();
                    }
                    else
                    {
                        WriteLine("\nElle: Oh… I see… I mean, I thought this was what you two do, but okay.");
                        ReadKey();
                        WriteLine($"{CurrentFriend.BestFriendName}: (whispering) DUDE. What’s gotten into you?? I hope that was just a joke.");
                        ReadKey();
                        WriteLine("A. 'Yeah, it was. Sorry.' or B. 'No, I’m dead serious. I don’t want to help her.'");
                        string responseEllesCat2 = ReadLine().Trim().ToUpper();

                        if (responseEllesCat2 == "A")
                        {
                            WriteLine($"\n{CurrentFriend.BestFriendName}: Sorry, Elle, my friend here was just kidding about that. Of course we’ll help you.");
                            ReadKey();
                            WriteLine("Elle: What a relief! I knew I could count on you two.");
                            ReadKey();
                            WriteLine($"{CurrentFriend.BestFriendName}: You’re up first.");
                            EncounterOneCheckWithFriend();
                        }
                        else
                        {
                            WriteLine($"\n{CurrentFriend.BestFriendName}: Ah, sorry Elle, but I guess you’ll have to wait for one of the other teams.");
                            ReadKey();
                            WriteLine("Elle: Oh… well, alright then.");
                            ReadKey();
                            WriteLine("The two of you pivot and start walking back to the town center, leaving a distraught Elle behind. Now you have to decide which task to tackle next…");
                            EncounterOneEnd();
                        }
                    }
                }
                else
                {
                    WriteLine("\nYou decide to go check out what this first option, “save Elle’s cat,” could possibly entail. You head over to Elle’s house, which is a little on the far side from the center of the town. A single large tree stands in the yard, and Elle herself stands beneath it, looking rather concerned.");
                    ReadKey();
                    WriteLine("Elle: Oh, Mr. Ted, come down please! I know you can do it!");
                    ReadKey();
                    WriteLine("A. 'What’s the matter?' or 'Whoa, sounds like you’re in a bind. What’s up?'");
                    string responseSaveCat1 = ReadLine().Trim().ToUpper();

                    if (responseSaveCat1 == "A")
                    {
                        WriteLine("\nElle: Mr. Ted got spooked this morning and ran up into that tree, and he hasn’t come down since. I’m really worried about him…");
                        ReadKey();
                    }
                    else
                    {
                        WriteLine("\nElle: Boy am I ever. Mr. Ted got spooked this morning and ran up into that tree, and he hasn’t come down since. I’m really worried about him…");
                        ReadKey();
                    }
                    WriteLine("A. 'I’m here to help with that!' or B. 'Oof, sounds rough. Anyway, I’m just passing through. Hope you get him back soon.'");
                    string responseSaveCat2 = ReadLine().Trim().ToUpper();

                    if (responseSaveCat2 == "A")
                    {
                        WriteLine("\nElle: What a relief! I knew I could count on you.");
                        EncounterOneCheckWithoutFriend();
                    }
                    else
                    {
                        WriteLine("\nElle: Oh… I see… I mean, I thought this was what you do, but okay.");
                        ReadKey();
                        WriteLine("You pivot and start walking back to the town center, leaving a distraught Elle behind. Now you have to decide which task to tackle next…");
                        EncounterOneEnd();
                    }
                }
            }
            void EncounterOneCheckWithFriend()
            {
                DiceRoll.Roll();

                if (Roll >= 7)
                {
                    WriteLine("\nYou start scaling the tree without a second thought, totally ready to get this cat back and check something off of your to-do list for the day. It’s not long before you see Mr. Ted himself crouched on a branch, claws hooked deep into the wood and eyes wide. With some coaxing, you’re able to get him to crawl into your arms. You descend the tree, going much slower this time on account of the cat in your arms, but you manage to make it down without incident. You hand the cat over to Elle. He practically leaps out of your arms trying to get away from you.");
                    ReadKey();
                    WriteLine("Elle: Mr. Ted!! Thank goodness.");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: Just doing our job. Nice work, {CurrentPlayer.Name}!");
                    ReadKey();
                    WriteLine("Having saved Elle’s cat successfully, the two of you then have to decide what task to tackle next.\n");
                    CurrentPlayer.Score++;
                    EncounterOneEnd();
                }
                else
                {
                    WriteLine("\nYou approach the tree, feeling a little apprehensive about all of this. Those branches don’t really look like they’ll support your weight… but still, you start climbing the tree. Your nerves only get worse as you go higher without any trace of that stupid cat. Finally, you spot him crouched rather far out on a branch that definitely isn’t safe for you to go near. Lo and behold, as if the tree is trying to prove your point, the branch you were standing on snaps under your weight! You fall dramatically to the ground, ego bruised and wind knocked out of you.");
                    ReadKey();
                    WriteLine("Elle: Oh!! Are you alright??");
                    ReadKey();
                    WriteLine("You are unfortunately too dazed to respond.");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: DUDE. Hardcore. Let me try.");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName} scales the tree easily and retrieves Mr. Ted without incident. Which is very good, because otherwise you guys wouldn’t be getting credit for accomplishing this task… in the time it takes your best friend to go up the tree and back down, your head has stopped spinning enough to form semi coherent thoughts.");
                    ReadKey();
                    WriteLine("Elle: Thank goodness! Mr. Ted, you really are so much trouble. I don’t know how I can repay you two. Feel better… that was a hard fall.");
                    ReadKey(); 
                    WriteLine($"You give Elle a weak thumbs up as {CurrentFriend.BestFriendName} helps you off the ground, then the two of you continue on your way. You’ve got a decision to make now- which task to do next?");
                    CurrentPlayer.Score++;
                    EncounterOneEnd();
                }
            }
            void EncounterOneCheckWithoutFriend()
            {
                DiceRoll.Roll();

                if (Roll >= 7)
                {
                    WriteLine("\nYou start scaling the tree without a second thought, totally ready to get this cat back and check something off of your to-do list for the day. It’s not long before you see Mr. Ted himself crouched on a branch, claws hooked deep into the wood and eyes wide. With some coaxing, you’re able to get him to crawl into your arms. You descend the tree, going much slower this time on account of the cat in your arms, but you manage to make it down without incident. You hand the cat over to Elle. He practically leaps out of your arms trying to get away from you.");
                    ReadKey();
                    WriteLine("Elle: Mr. Ted!! Oh, I was so worried. Thank you so much.");
                    ReadKey();
                    WriteLine("You flash her a thumbs up, satisfied with a job well done. Having saved Elle’s cat successfully, you then have to decide what task to tackle next.");
                    CurrentPlayer.Score++;
                    EncounterOneEnd();

                }
                else
                {
                    WriteLine("\nYou approach the tree, feeling a little apprehensive about all of this. Those branches don’t really look like they’ll support your weight… but still, you start climbing the tree. Your nerves only get worse as you go higher without any trace of that stupid cat. Finally, you spot him crouched rather far out on a branch that definitely isn’t safe for you to go near. Lo and behold, as if the tree is trying to prove your point, the branch you were standing on snaps under your weight! You fall dramatically to the ground, ego bruised and wind knocked out of you.");
                    ReadKey();
                    WriteLine("Elle: Oh!! Are you alright??");
                    ReadKey();
                    WriteLine("You are unfortunately too dazed to respond.");
                    ReadKey();
                    WriteLine("Elle: Look, don’t worry about Mr. Ted. I can wait for somebody else. Please take care of yourself.");
                    ReadKey();
                    WriteLine("A. (weak thumbs up) or B. 'Very sorry about that...'");
                    string responseSaveCat3 = ReadLine().Trim().ToUpper();

                    if (responseSaveCat3 == "A")
                    {
                        WriteLine("\nElle: I hope you feel better soon. Go ahead and stay there for as long as you need, I don’t mind.");
                        ReadKey();
                        WriteLine("You lie on the ground for a while to get your bearings, but once you get up, you’re then confronted with the fact that you have a decision to make now- which task to attempt next?");
                        EncounterOneEnd();
                    }
                    else
                    {
                        WriteLine("Elle: Don’t worry about it. That was a hard fall… feel free to stay there as long as you need.");
                        ReadKey();
                        WriteLine("You lie on the ground for a while to get your bearings, but once you get up, you’re then confronted with the fact that you have a decision to make now- which task to attempt next?");
                        EncounterOneEnd();
                    }
                }
            }
            void EncounterOneEnd()
            {
                for (int t = 0; t < tasks.Count; t++)
                {
                    WriteLine(tasks[t]);
                }
                WriteLine("What would you like to do?");
                WriteLine("(Choose 2, 3, or 4.)");
                string responseEncounterChoice3 = ReadLine();

                if (responseEncounterChoice3 == "2")
                {
                    tasks.Remove("2. Clear cobwebs from the rafters of Greg’s house");
                    EncounterTwo();
                }
                else if (responseEncounterChoice3 == "3")
                {
                    tasks.Remove("3. Build a fence for Darcey");
                    EncounterThree();
                }
                else
                {
                    tasks.Remove("4. Apothecary’s task");
                    EncounterFour();
                }
            }
            void EncounterTwo()
            {
                if (hasBestFriend == true)
                {
                    WriteLine("\nThe two of you head over to Greg’s house as instructed by the second task on the list. Greg, a kindly old man who suffered a back injury as a teenager and can’t stand up straight, is waiting on the porch of his house. Upon seeing the two of you approach, he waves enthusiastically at you.");
                    ReadKey(); 
                    WriteLine("Greg: Hey there! Are you here about the request I submitted to the chief?");
                    ReadKey();
                    WriteLine("A. 'Sure are.' or B. 'Nah, just passing through.'");
                    string responseCobwebsChoice1 = ReadLine().Trim().ToUpper();

                    if (responseCobwebsChoice1 == "A")
                    {
                        WriteLine("\nGreg: Oh, wonderful! The cobwebs are gettin’ real out of hand. Could use the help of a couple of youngsters like y’all. There’s a ladder and a broom around back.");
                        ReadKey();
                        WriteLine($"{CurrentFriend.BestFriendName}: We’ll take care of it, no worries. Just sit back and relax. Alright, {CurrentPlayer.Name}, you’re up first.");
                        EncounterTwoCheckWithFriend();
                    }
                    else
                    {
                        WriteLine("\nGreg: Oh, okay. Some other day, then.");
                        ReadKey();
                        WriteLine($"{CurrentFriend.BestFriendName}: Are you kidding, dude?? This is our job, you know.");
                        ReadKey();
                        WriteLine("A. 'Oh, yeah. It was just a joke, sorry.' or B. 'Not kidding. I can tell there’s gonna be a bunch of spiders in there.'");
                        string responseCobwebsChoice2 = ReadLine().Trim().ToUpper();

                        if (responseCobwebsChoice2 == "A")
                        {
                            WriteLine($"\n{CurrentFriend.BestFriendName}: Jeez. You’re gonna kill me with those jokes one of these days. Sorry, Greg, we’re here to help you out after all.");
                            ReadKey();
                            WriteLine("Greg: That sounds more like it.");
                            EncounterTwoCheckWithFriend();
                        }
                        else
                        {
                            WriteLine($"\n{CurrentFriend.BestFriendName}: Ugh, I forgot you’re deathly afraid of spiders. Well, I guess we should just move on. I’ll come back and do it on my own later.");
                            ReadKey();
                            WriteLine("The two of you turn and start walking back towards the town square like nothing happened. Greg watches you go with an unreadable expression on his wizened old face. Now it’s time for the two of you to decide what you’ll do next.");
                            EncounterTwoEnd();
                        }
                    }
                }
                else
                {
                    WriteLine("\nYou head over to Greg’s house as instructed by the second task on the list. Greg, a kindly old man who suffered a back injury as a teenager and can’t stand up straight, is waiting on the porch of his house. Upon seeing you approach, he waves enthusiastically at you.");
                    ReadKey();
                    WriteLine("Greg: Hey there! Are you here about the request I submitted to the chief?");
                    ReadKey();
                    WriteLine("A. 'Sure am.' or B. 'Nah, just passing through.'");
                    string responseCobwebsChoiceWithoutFriend1 = ReadLine().Trim().ToUpper();

                    if (responseCobwebsChoiceWithoutFriend1 == "A")
                    {
                        WriteLine("\nGreg: Oh, wonderful! The cobwebs are gettin’ real out of hand. Could use the help of a youngster like you. There’s a ladder and a broom around back.");
                        EncounterTwoCheckWithoutFriend();
                    }
                    else
                    {
                        WriteLine("\nGreg: Oh, okay. Some other day, then.");
                        ReadKey();
                        WriteLine("You turn and start walking back towards the town square like nothing happened. Greg watches you go with an unreadable expression on his wizened old face. Now it’s time for you to decide what you’ll do next.");
                        EncounterTwoEnd();
                    }
                }
            }
            void EncounterTwoCheckWithFriend()
            {
                DiceRoll.Roll();

                if (Roll >= 10)
                {
                    WriteLine("\nYou give your best friend a thumbs up and go grab the items that Greg pointed out to you. Then, you head inside and are met with what can only be described as spiderweb hell. The thick white webs are EVERYWHERE. Good thing you’re not afraid of spiders. You set up the ladder and get to work, making quick work of everything. By the time you’re done, the broom is utterly coated in webs, but at least you accomplished the task. You return the ladder and the broom to their previous spot and then meet up with your best friend and Greg to inform them that you’ve completed the task.");
                    ReadKey();
                    WriteLine("Greg: Thank you so much! I reckon it’s lookin’ a lot better in there. I appreciate it, kiddo. Have a good day!");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: Eh, it’s just part of the job. Have a good one, Greg.");
                    ReadKey();
                    CurrentPlayer.Score++;
                    WriteLine("With that, the two of you have to decide what task to tackle next.");
                    EncounterTwoEnd();
                }
                else
                {
                    WriteLine("\nYou give your best friend a thumbs up and go grab the items that Greg pointed out to you. You’re a little apprehensive about this, given that you’re not a huge fan of spiders, but you’re here to do a job, not freak out about a stupid little bug. Or five. Who knows how many could be in there? As soon as you enter the house, you regret all of your life choices that have led you to this point. There are cobwebs EVERYWHERE, and you swear that you can see a spider crawling through one of them as you stand there and watch. It’s awful. You set up the ladder and start working, trying to beat back your fear, when you feel the terrible sensation of legs crawling down your spine. Startled, you topple off of the ladder, landing heavily on the ground. That doesn’t keep you down for long, though, as the fear of the spiders all around you is more powerful than anything else. You race out of the house in a panic and yell for your best friend to tackle this job instead.");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: Whoa there, dude. Take it easy. I forgot you’re scared of spiders. I got this.");
                    ReadKey();
                    WriteLine("With that, they enter the house and make quick work of the task. Meanwhile, you’re still trying to calm your racing heart. Greg peers at you in concern but doesn’t say anything, which is for the better.");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: Okay, done. Cobwebs removed.");
                    ReadKey();
                    WriteLine("Greg: Thank you so much, kiddo. Take care of your friend there.");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: I will, don’t worry. Enjoy your day!");
                    ReadKey();
                    WriteLine("Greg: Same to you.");
                    ReadKey();
                    CurrentPlayer.Score++;
                    WriteLine("With that, the two of you have to decide what task to tackle next.");
                    EncounterTwoEnd();
                }
            }
            void EncounterTwoCheckWithoutFriend()
            {
                DiceRoll.Roll();

                if (Roll >= 10)
                {
                    WriteLine("\nYou go grab the items that Greg pointed out to you. Then, you head inside and are met with what can only be described as spiderweb hell. The thick white webs are EVERYWHERE. Good thing you’re not afraid of spiders. You set up the ladder and get to work, making quick work of everything. By the time you’re done, the broom is utterly coated in webs, but at least you accomplished the task. You return the ladder and the broom to their previous spot and then meet up with Greg to inform them that you’ve completed the task.");
                    ReadKey();
                    WriteLine("Greg: Thank you so much! I reckon it’s lookin’ a lot better in there. I appreciate it, kiddo. Have a good day!");
                    ReadKey();
                    WriteLine("With that, you head back to the town square to decide what task to tackle next.");
                    CurrentPlayer.Score++;
                    EncounterTwoEnd();
                }
                else
                {
                    WriteLine("\nYou go grab the items that Greg pointed out to you. You’re a little apprehensive about this, given that you’re not a huge fan of spiders, but you’re here to do a job, not freak out about a stupid little bug. Or five. Who knows how many could be in there? As soon as you enter the house, you regret all of your life choices that have led you to this point. There are cobwebs EVERYWHERE, and you swear that you can see a spider crawling through one of them as you stand there and watch. It’s awful. You set up the ladder and start working, trying to beat back your fear, when you feel the terrible sensation of legs crawling down your spine. Startled, you topple off of the ladder, landing heavily on the ground. That doesn’t keep you down for long, though, as the fear of the spiders all around you is more powerful than anything else. You race out of the house in a panic and basically collapse in front of Greg.");
                    ReadKey();
                    WriteLine("Greg: Ahhh, a case of arachnophobia, I see? Sorry, kiddo, I didn’t realize you were so scared of ‘em. I can wait for somebody else to handle this. You just sit there and rest up, mkay?");
                    ReadKey();
                    WriteLine("You nod breathlessly and lie back against the wood of the porch, desperately hoping your racing heart will calm down soon. Once you recover, you thank Greg for his generosity and head back to the town square to decide what task to tackle next.");
                    EncounterTwoEnd();
                }
            }
            void EncounterTwoEnd()
            {
                for (int t = 0; t < tasks.Count; t++)
                {
                    WriteLine(tasks[t]);
                }
                WriteLine("What would you like to do?");
                WriteLine("(Choose 1, 3, or 4.)");
                string responseEncounterChoice4 = ReadLine();

                if (responseEncounterChoice4 == "1")
                {
                    tasks.Remove("1. Save Elle's cat ");
                    EncounterOne();
                }
                else if (responseEncounterChoice4 == "3")
                {
                    tasks.Remove("3. Build a fence for Darcey");
                    EncounterThree();
                }
                else
                {
                    tasks.Remove("4. Apothecary’s task");
                    EncounterFour();
                }
            }
            void EncounterThree()
            {
                if (hasBestFriend == true)
                {
                    WriteLine("\nThe two of you decide to go check out the request for help building a fence from Darcey, who lives out on the very edge of town and is a farmer. It takes the two of you some time to get out to Darcey’s farm, but by the time that you do, it becomes apparent why they asked for help in the first place. The fence around their neat little farmhouse looks like it got absolutely obliterated by some vengeful god. They are currently standing by it and looking despondent when the two of you walk up.");
                    ReadKey();
                    WriteLine("Darcey: Oh. Hey. Are you here about the request I submitted?");
                    ReadKey();
                    WriteLine("A. 'You know it!' or B. 'Nah. Tough luck with that fence.'");
                    string responseFenceChoice1 = ReadLine().Trim().ToUpper();

                    if (responseFenceChoice1 == "A")
                    {
                        WriteLine("\nDarcey: Thank goodness. I desperately need some help here. There’s just too much work for one person to do.");
                        ReadKey();
                        WriteLine($"{CurrentFriend.BestFriendName}: No worries, we’ve got you. You’re up first.");
                        EncounterThreeCheckWithFriend();
                    }
                    else
                    {
                        WriteLine($"\n{CurrentFriend.BestFriendName}: Are you kidding, dude?? This is our job, you know. AND we walked all the way out here only for you to change your mind??");
                        ReadKey();
                        WriteLine("A. 'Sorry, sorry. Just a joke.' or B. 'It’s not a joke. I don’t think I’ve got energy to help them out now that we’ve walked all this way.'");
                        string responseFenceChoice2 = ReadLine().Trim().ToUpper();

                        if (responseFenceChoice2 == "A")
                        {
                            WriteLine($"\n{CurrentFriend.BestFriendName}: Jeez. About gave me a heart attack with that one. Sorry about that, Darcey, we are in fact here to help.");
                            ReadKey();
                            WriteLine("Darcey: Ah, so you’ve got a jokester on your hands. Very funny. Well, I appreciate the help regardless.");
                            EncounterThreeCheckWithFriend();
                        }
                        else
                        {
                            WriteLine($"\n{CurrentFriend.BestFriendName}: You’re lucky I don’t want to risk the wrath of your parents by killing you. YOU can walk back, I’ll do this by myself and meet you in the town square to finish up everything else.");
                            ReadKey();
                            WriteLine("You shrug and start walking back just like your best friend suggested, more than happy to have some time to kill while they actually do work. By the time they rejoin you a couple of hours later, they’re in a much better mood and ready to help you decide which task you’ll tackle next.");
                            EncounterThreeEnd();
                        }
                    }
                }
                else
                {
                    WriteLine("\nYou decide to go check out the request for help building a fence from Darcey, who lives out on the very edge of town and is a farmer. It takes the two of you some time to get out to Darcey’s farm, but by the time that you do, it becomes apparent why they asked for help in the first place. The fence around their neat little farmhouse looks like it got absolutely obliterated by some vengeful god. They are currently standing by it and looking despondent when you walk up.");
                    ReadKey();
                    WriteLine("Darcey: Oh. Hey. Are you here about the request I submitted?");
                    ReadKey();
                    WriteLine("A. 'You know it!' or 'Nah. Tough luck with that fence.'");
                    string responseFixFence1 = ReadLine().Trim().ToUpper();

                    if (responseFixFence1 == "A")
                    {
                        WriteLine("\nDarcey: Thank goodness. I desperately need some help here. There’s just too much work for one person to do.");
                        EncounterThreeCheckWithoutFriend();
                    }
                    else
                    {
                        WriteLine("\nDarcey: Ah… okay. I see. No worries. Have a good day.");
                        ReadKey();
                        WriteLine("Without further ado, you pivot and start walking back, already thinking about what your next course of action should be. That fence was a lost cause anyway. Once you reach the town square, it’s decision time.");
                        EncounterThreeEnd();
                    }
                }
            }
            void EncounterThreeCheckWithFriend()
            {
                DiceRoll.Roll();

                if (Roll >= 13)
                {
                    WriteLine("\nYou roll up your sleeves and jump right in to helping Darcey fix their fence. The work goes quickly and smoothly with the two of you, while your best friend provides moral support and also gets water and more materials for the two of you when necessary. Before too long, the fence is fixed, and Darcey is looking much happier than before.");
                    ReadKey();
                    WriteLine("Darcey: Thank you so much for all of your help! Seriously. I never would have finished this without you.");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: It’s nothing. Just doing the job we’re here to do.");
                    ReadKey();
                    WriteLine("Darcey: Still. I really appreciate it. You could’ve walked all the way out here and then decided not to help me after all.");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: Haha, now who in the world would do such a thing? ");
                    ReadKey();
                    WriteLine("With that, the two of you decide to trek back to the village and decide what to tackle next.");
                    CurrentPlayer.Score++;
                    EncounterThreeEnd();
                }
                else
                {
                    WriteLine("\nYou roll up your sleeves and jump right in to helping Darcey fix their fence. Unfortunately for you, they assign you to hammer duty, and you’re historically not the greatest with hammers. Any project you undertake that involves the use of a hammer inevitably ends up resulting in a smashed finger or two. And it doesn’t take long for that to happen once again. You swing the hammer and miss the nail, striking yourself square in the hand. Startled, you drop the hammer and cradle your hand.");
                    ReadKey();
                    WriteLine("Darcey: Well that’s not good. Why don’t you sub out with your friend and get some rest?");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: Yeah, I’m more than happy to finish the task.");
                    ReadKey();
                    WriteLine("You do as you’re told and go sit down in the shade, still cradling your bruised hand. Before too long,  your best friend manages to finish the task in your stead. Darcey looks very pleased by the end result.");
                    ReadKey();
                    WriteLine("Darcey: Thank you so much. I mean, I know you’re just doing your job, but still.");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: Like you said, it’s all in a day’s work for us.");
                    ReadKey();
                    WriteLine("Darcey: Yeah yeah. Watch out for that hand of yours, okay?");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: I’ll be sure to keep an eye on them, don’t worry.");
                    ReadKey();
                    WriteLine("Darcey: Of course. Thank you again!");
                    ReadKey();
                    WriteLine("With that, the two of you begin the very long trek back to the village square. It’s time for you to decide what task you want to tackle next.");
                    CurrentPlayer.Score++;
                    EncounterThreeEnd();
                }
            }
            void EncounterThreeCheckWithoutFriend()
            {
                DiceRoll.Roll();

                if (Roll >= 13)
                {
                    WriteLine("\nYou roll up your sleeves and jump right in to helping Darcey fix their fence. The work goes quickly and smoothly with the two of you, and nobody manages to get any splinters, which is the real win there. Before too long, the fence is fixed, and Darcey is looking much happier than before.");
                    ReadKey();
                    WriteLine("Darcey: Thank you so much for all of your help! Seriously. I never would have finished this without you.");
                    ReadKey();
                    WriteLine("A. 'Ah, it’s all good.' or B. 'Just doing my job.'");
                    string responseFixFence2 = ReadLine().Trim().ToUpper();

                    if (responseFixFence2 == "A")
                    {
                        WriteLine("\nDarcey: Still. I really appreciate it. You could’ve walked all the way out here and then decided not to help me after all.");
                        ReadKey();
                    }
                    else
                    {
                        WriteLine("\nDarcey: Take the compliment!! I mean, you could’ve walked all the way out here and then decided not to help me after all.");
                        ReadKey();
                    }
                    WriteLine("You laugh goodnaturedly and shake your head. What a ridiculous notion. With that, you decide to trek back to the village to decide what to tackle next.");
                    CurrentPlayer.Score++;
                    EncounterThreeEnd();
                }
                else
                {
                    WriteLine("\nYou roll up your sleeves and jump right in to helping Darcey fix their fence. Unfortunately for you, they assign you to hammer duty, and you’re historically not the greatest with hammers. Any project you undertake that involves the use of a hammer inevitably ends up resulting in a smashed finger or two. And it doesn’t take long for that to happen once again. You swing the hammer and miss the nail, striking yourself square in the hand. Startled, you drop the hammer and cradle your hand.");
                    ReadKey();
                    WriteLine("Darcey: Well that’s not good. I think I’m at a point where I can do this by myself. Take care of yourself, please.");
                    ReadKey();
                    WriteLine("You start to protest this, but Darcey cuts you off.");
                    ReadKey();
                    WriteLine("Darcey: Seriously, don’t worry about it. That looked like a nasty injury. I’ve got this.");
                    ReadKey();
                    WriteLine("You sigh and decide to do as you’re told. You leave Darcey behind as they start working on their fence again. The very long trek back to the village square feels even longer this time with the shame of defeat hanging over your head. Either way, it’s time for you to decide what task you want to tackle next.");
                    EncounterThreeEnd();
                }
            }
            void EncounterThreeEnd()
            {
                for (int t = 0; t < tasks.Count; t++)
                {
                    WriteLine(tasks[t]);
                }
                WriteLine("What would you like to do?");
                WriteLine("(Choose 1, 2, or 4.)");
                string responseEncounterChoice5 = ReadLine();

                if (responseEncounterChoice5 == "1")
                {
                    tasks.Remove("1. Save Elle's cat ");
                    EncounterOne();
                }
                else if (responseEncounterChoice5 == "2")
                {
                    tasks.Remove("2. Clear cobwebs from the rafters of Greg’s house");
                    EncounterTwo();
                }
                else
                {
                    tasks.Remove("4. Apothecary’s task");
                    EncounterFour();
                }
            }
            void EncounterFour()
            {
                if (hasBestFriend == true)
                {
                    WriteLine("\nYou find yourself drawn to the mysterious fourth task: whatever the apothecary wants you to do. Intrigued, the two of you decide to check it out, so you head over to the apothecary’s shop in the town square. Once you enter the shop, you’re immediately hit by a wave of strongly scented herbal incense. You’re acutely reminded why you don’t spend much time in here. The apothecary, a middle aged woman with closely cropped brown hair, notices you as soon as the two of you enter, and waves you over to the back counter.");
                    ReadKey();
                    WriteLine("Apothecary: Good to see you two. Are you here about the request?");
                    ReadKey();
                    WriteLine($"{CurrentFriend.BestFriendName}: Yeah, we are. What’s up?");
                    ReadKey();
                    WriteLine("Apothecary: Well, my request is very simple. I need some water from the healing lake nearby. It’s very important for the medicines I have to make. Will you help me out?");
                    ReadKey();
                    WriteLine("A. 'Yes, of course.' or B. 'No, sorry. That’s too dangerous.'");
                    string responseApothecaryChoice1 = ReadLine().Trim().ToUpper();

                    if (responseApothecaryChoice1 == "A")
                    {
                        WriteLine("\nApothecary: Oh, fantastic! I’ll be waiting here for you to return. But remember, you can only draw water from the lake if you’re judged to be a truly good person. Oh, and you should use this canteen.");
                        ReadKey();
                        WriteLine($"{CurrentFriend.BestFriendName}: Right, right. We’re on it.");
                        CurrentPlayer.Score++;
                        LakeWaterFinalBossWithFriend();
                    }
                    else
                    {
                        WriteLine("\nApothecary: That’s truly too bad. I mean, it’s not like I’m too busy to go do this very essential thing for my work and put in that request with the hopes of gaining the assistance of some brave young adventurers like the two of you… ");
                        ReadKey();
                        WriteLine($"{CurrentFriend.BestFriendName}: Look-");
                        ReadKey();
                        WriteLine("Apothecary: No, no, it’s fine. I’ll just have to wait for someone else to come along who actually wants to help me.");
                        ReadKey();
                        WriteLine($"{CurrentFriend.BestFriendName}: We’ll do it!! Just relax! My friend here is a little bit of a jokester. We’ll get you the water.");
                        ReadKey();
                        WriteLine("Apothecary: Really? That’s wonderful!! I’ll be waiting here for your return. But remember, you can only draw water from the lake if you’re judged to be a truly good person. Use this canteen.");
                        ReadKey();
                        WriteLine($"{CurrentFriend.BestFriendName}: Riiiight. We’re on it.");
                        ReadKey();
                        WriteLine("Once you make it outside, your best friend elbows you in the side and shoots you a glare.");
                        ReadKey();
                        WriteLine($"{CurrentFriend.BestFriendName}: Dude. Not cool. We have a JOB to do, whether you like it or not.");
                        ReadKey();
                        WriteLine("A. (shrug) or B. 'Sorry! Won’t happen again, I promise.'");
                        string responseApothecaryChoice2 = ReadLine().Trim().ToUpper();

                        if (responseApothecaryChoice2 == "A")
                        {
                            WriteLine($"\n{CurrentFriend.BestFriendName}: Whatever man.");
                            LakeWaterFinalBossWithFriend();
                        }
                        else
                        {
                            WriteLine($"\n{CurrentFriend.BestFriendName}: It better not!!! I’m not always going to be around to bail you out.");
                            LakeWaterFinalBossWithFriend();
                        }
                    }
                }
                else
                {
                    WriteLine("\nYou find yourself drawn to the mysterious fourth task: whatever the apothecary wants you to do. Intrigued, you decide to check it out, so you head over to the apothecary’s shop in the town square. Once you enter the shop, you’re immediately hit by a wave of strongly scented herbal incense. You’re acutely reminded why you don’t spend much time in here. The apothecary, a middle aged woman with closely cropped brown hair, notices you as soon as you enter, and waves you over to the back counter.");
                    ReadKey();
                    WriteLine("Apothecary: Good to see you. Are you here about the request?");
                    ReadKey();
                    WriteLine("A. 'Sure am.' or B. (nod)");
                    string responseApothecarySoloChoice1 = ReadLine().Trim().ToUpper();

                    if (responseApothecarySoloChoice1 == "A")
                    {
                        WriteLine("\nApothecary: Excellent! Well, my request is very simple. I need some water from the healing lake nearby. It’s very important for the medicines I have to make. Will you help me out?");
                        ReadKey();
                    }
                    else
                    {
                        WriteLine("\nApothecary: Well, my request is very simple. I need some water from the healing lake nearby. It’s very important for the medicines I have to make. Will you help me out?");
                        ReadKey();
                    }
                    WriteLine("A. 'Yes, of course.' or B. 'No, sorry. That’s too dangerous.'");
                    string responseApothecarySoloChoice2 = ReadLine().Trim().ToUpper();

                    if (responseApothecarySoloChoice2 == "A")
                    {
                        WriteLine("\nApothecary: Oh, fantastic! I’ll be waiting here for you to return. But remember, you can only draw water from the lake if you’re judged to be a truly good person. Oh, and you should use this canteen.");
                        ReadKey();
                        WriteLine("You give the apothecary a thumbs up and quickly exit the shop before your headache can worsen.");
                        CurrentPlayer.Score++;
                        LakeWaterFinalBossWithoutFriend();
                    }
                    else
                    {
                        WriteLine("\nApothecary: That’s truly too bad. I mean, it’s not like I’m too busy to go do this very essential thing for my work and put in that request with the hopes of gaining the assistance of some brave young adventurers like you…");
                        ReadKey();
                        WriteLine("You start to feel as though maybe you’ve made the wrong choice here. Right as you’re about to open your mouth to protest, the apothecary waves you off.");
                        ReadKey();
                        WriteLine("Apothecary: No, no, it’s fine. I’ll just have to wait for someone else to come along who actually wants to help me.");
                        ReadKey();
                        WriteLine("A. 'Wait wait wait! I’ll help.' or B. 'FINE, I’ll help you! Jeez.'");
                        string responseApothecarySoloChoice3 = ReadLine().Trim().ToUpper();

                        if (responseApothecarySoloChoice3 == "A")
                        {
                            WriteLine("\nApothecary: Really? That’s wonderful!! I’ll be waiting here for your return. But remember, you can only draw water from the lake if you’re judged to be a truly good person. Use this canteen.");
                            ReadKey();
                            WriteLine("You nod along to what she’s saying, only half listening. Being judged by a lake is such a silly idea. She can’t possibly be telling the truth.");
                            ReadKey();
                            WriteLine("Apothecary: Right, well, good luck!");
                            LakeWaterFinalBossWithoutFriend();
                        }
                        else
                        {
                            WriteLine("Apothecary: Watch that mouth of yours. I'm glad you've come around, though! I’ll be waiting here for your return. But remember, you can only draw water from the lake if you’re judged to be a truly good person. Use this canteen.");
                            ReadKey();
                            WriteLine("You nod along to what she’s saying, only half listening. Your ego is smarting a little from being scolded like that, not to mention that being judged by a lake is such a silly idea. She can’t possibly be telling the truth.");
                            ReadKey();
                            WriteLine("Apothecary: Right, well, good luck!");
                            LakeWaterFinalBossWithoutFriend();
                        }
                    }
                }
            }
            void LakeWaterFinalBossWithFriend()
            {
                WriteLine("\nLuckily for you two, the mystical healing lake is in fact nearby. It was one of the main draws for the settlement of this village in the first place. So, your trip over to the lake is fairly short and very uneventful as far as such things go. Upon arriving at the lake, you’re struck by how still the waters are and the brilliant azure hue of the waters. It almost looks too good to be true. Still, the two of you approach the water’s edge, the empty canteen the apothecary gave you held tight in your hands.");
                ReadKey();
                WriteLine($"{CurrentFriend.BestFriendName}: Be careful.");
                ReadKey();
                WriteLine("You nod in acknowledgement and then dip the canteen in the water. Instantly, it feels like time freezes around you for a moment, and a chorus of ghostly voices echoes in your ear as the lake judges whether or not you are worthy to draw water from its shores. After what feels like a lifetime and no time at all, a verdict is reached…");
                if (CurrentPlayer.Score >= 4)
                {
                    WinConditions.WinConditionsMetRight(true);
                }
                else
                {
                    LoseConditions.LoseNotEnoughPointsRight(true);
                }
            }
            void LakeWaterFinalBossWithoutFriend()
            {
                WriteLine("\nLuckily for you, the mystical healing lake is in fact nearby. It was one of the main draws for the settlement of this village in the first place. So, your trip over to the lake is fairly short and very uneventful as far as such things go. Upon arriving at the lake, you’re struck by how still the waters are and the brilliant azure hue of the waters. It almost looks too good to be true. Still, you approach the water’s edge undaunted, the empty canteen the apothecary gave you held tight in your hands.");
                ReadKey();
                WriteLine("After a moment, you dip the canteen in the water. Instantly, it feels like time freezes around you for a moment, and a chorus of ghostly voices echoes in your ear as the lake judges whether or not you are worthy to draw water from its shores. After what feels like a lifetime and no time at all, a verdict is reached…");
                if (CurrentPlayer.Score >= 4)
                {
                    WinConditions.WinConditionsMetRight(false);
                }
                else
                {
                    LoseConditions.LoseNotEnoughPointsRight(false);
                }
            }
        }
    }
}
