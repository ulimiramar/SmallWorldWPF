using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmallWorld.src.Model.Interactable.ItemEffects
{
    internal class Kill : IEffectStrategy
    {
        private string name = "Auto-Matarse";
        public void Effect(Entity entity)
        {
            entity.AttackPoints = 0;
            entity.CurrentLife = 0;
            entity.CurrentEnergy = 0;
            entity.DefensePoints = 0;
        }
        public override bool Equals(object obj)
        {
            if (obj is Kill other)
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
