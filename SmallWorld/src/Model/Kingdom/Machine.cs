using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Reino
{
    internal class Machine : IKingdom
    {
        public string Name => "Maquina";
        public string GetKingdomName()
        {
            return "Maquina";
        }
        public override string ToString()
        {
            return "Máquina";
        }
    }
}
