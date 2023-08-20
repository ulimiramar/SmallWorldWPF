using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Dieta
{
    internal class Carnivorous : IDiet
    {
        public string getDietName()
        {
            return "Carnívoro";
        }
        public override string ToString()
        {
            return "Carnívoro";
        }
    }
}
