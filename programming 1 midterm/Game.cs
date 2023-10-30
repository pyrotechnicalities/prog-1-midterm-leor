using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MidtermLeftOrRight
{
    internal class Game
    {
        private Player CurrentPlayer;
        public void Start()
        {
            //store title art + start screen here
            //title art = ascii, says "left or right," also says "press any key to begin"
            Title = "Left or Right";
            Clear();
            WriteLine("Let us begin the game.\n");
            PlayerCreate();
        }
        public void PlayerCreate()
        {
            WriteLine("What is your name, brave adventurer?");
            string playerName = ReadLine();
            WriteLine("Enter your hair color.");
            string hairColor = ReadLine();
            WriteLine("Enter your eye color.");
            string eyeColor = ReadLine();
            WriteLine("Finally, enter your preferred weapon.");
            string weaponType = ReadLine();
            WriteLine($"Your name is {playerName}, your hair color is {hairColor}, your eye color is {eyeColor} and your preferred weapon is {weaponType}.");
            WriteLine("Is this correct? (yes/no)");
            string creatorResponse = ReadLine().Trim().ToLower();
            if (creatorResponse == "yes")
            {
                Clear();
                GameStart();
            }
            else
            {
                Clear();
                PlayerCreate();
            }
            //might need exception handler?
            
            CurrentPlayer = new Player(playerName, hairColor, eyeColor, weaponType);
        }
        public void GameStart()
        {
            WriteLine("As our story begins, you live in a small, but reasonably prosperous, village– at least, as far as small villages go, anyway. The sun is shining down on you, the breeze is blowing, and overall you feel content with your life. Unbeknownst to you, many changes are heading your way… ");
            WriteLine("\nWill you choose LEFT or RIGHT?");
            string gameStartResponse = ReadLine().Trim().ToUpper();
            if (gameStartResponse == "LEFT")
            {
                //LeftPathGameplay();
                //ask tutor about this later- need to call LeftPathGameplay from LeftPath.cs and I can't figure out how to get that to work
            }
            else
            {
                //RightPathGameplay();
                WriteLine("tba");
            }
        }
    }
}
