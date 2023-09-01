using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.Model.Interactable
{
    internal class Dice
    {
        private int Side;
        private static Random RandomSide = new Random();

        public Dice(int side)
        {
            Side = side;
        }

        public static int TrowDice() 
        {
            return RandomSide.Next(1, 6);
        }
    }
}
