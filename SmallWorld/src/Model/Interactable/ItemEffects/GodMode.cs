using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Interactable.ItemEffects
{
    internal class GodMode : IEffectStrategy
    {
        public void Effect(Entity entity)
        {
            entity.AttackPoints = 100;
            entity.CostToAttack = 0;
            entity.CurrentLife = 100;
            entity.CurrentEnergy = 100;
            entity.DefensePoints = 100;
        }
        public override string ToString()
        {
            return "Modo Dios";
        }
    }
}
