using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Interactable.ItemEffects
{
    internal class FillCurrentLife : IEffectStrategy
    {
        public void Effect(Entity entity)
        {
            entity.CurrentLife += 100;
        }

        public override string ToString()
        {
            return "Llenar vida actual";
        }
    }
}
