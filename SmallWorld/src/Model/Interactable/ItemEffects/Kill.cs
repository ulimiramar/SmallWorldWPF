using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Interactable.ItemEffects
{
    internal class Kill : IEffectStrategy
    {
        public void Effect(Entity entity)
        {
            entity.AttackPoints = 0;
            entity.CurrentLife = 0;
            entity.CurrentEnergy = 0;
            entity.DefensePoints = 0;
        }
        public override string ToString()
        {
            return "Matar";
        }
    }
}
