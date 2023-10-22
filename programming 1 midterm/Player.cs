using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MidtermLeftOrRight
{
    internal class Player
    {
        public string Name;
        public string HairColor;
        public string EyeColor;
        public string WeaponType;
        public int Score;
        public Player(string playerName, string hairColor, string eyeColor, string weaponType)
        {
            Name = playerName;
            Score = 0;
            HairColor = hairColor;
            EyeColor = eyeColor;
            WeaponType = weaponType;
        }
    }
}
