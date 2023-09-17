using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmallWorld.src.Model.Interactable.ItemEffects
{
    internal class GodMode : IEffectStrategy
    {
        private string name = "Modo Dios";
        public void Effect(Entity entity)
        {
            entity.AttackPoints = 100;
            entity.CostToAttack = 0;
            entity.CurrentLife = 100;
            entity.CurrentEnergy = 100;
            entity.DefensePoints = 100;
        }
        public override bool Equals(object obj)
        {
            if (obj is GodMode other)
            {
                return name == other.name;
            }
            return false;
        }
        public override string ToString()
        {
            return name;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}
