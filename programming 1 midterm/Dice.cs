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
    internal class Dice
    {
        Random random = new Random();
        public int Roll()
        {
            int RollResult = random.Next(1,20);
            return RollResult;
        }
    }
}
