using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.Model.Interactable
{
    internal static class Dice
    {
        //TODO: se tendria que modificar un dado para agregarse mas lados y utilizarlo como item. No hace falta instanciar dados.
        static Random RandomSide = new Random();
        public static int TrowDice(int cantidadCaras)
        {           
            return RandomSide.Next(1, cantidadCaras);
        }
    }
}
