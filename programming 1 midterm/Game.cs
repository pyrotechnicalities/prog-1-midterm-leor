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
            //store title art + start screen here, then kick over to PlayerCreate
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
                //start gameplay now
            }
            else
            {
                Clear();
                PlayerCreate();
            }
            //might need exception handler?
            
            CurrentPlayer = new Player(playerName, hairColor, eyeColor, weaponType);
        }
    }
}
