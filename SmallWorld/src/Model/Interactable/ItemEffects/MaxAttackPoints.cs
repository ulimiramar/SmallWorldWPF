using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Interactable.ItemEffects
{
    internal class MaxAttackPoints : IEffectStrategy
    {
        public void Effect(Entity entity)
        {
            entity.AttackPoints = 100;
        }
        public override string ToString()
        {
            return "Ataque al máximo";
        }
    }
}
