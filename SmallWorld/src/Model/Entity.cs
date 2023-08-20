using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model
{
    internal class Entity
    {
        private IKingdom Kingdom { get; set; }
        private string Name { get; set; }
        private IDiet Diet { get; set; }
        private IHabitat Habitat { get; set; }

        private int MaxEnergy = 100;
        private int CurrentEnergy = 100;

        private int MaxLife = 3;
        private int CurrentLife = 3;

        private int AvailablePoints = 100;
        private int AttackPoints { get; set; }
        private int DefensePoints { get; set; }
        private int AttackRange { get; set; }

        public Entity(IKingdom kingdom, string name, IDiet diet, IHabitat habitat, int attackPoints, int defensePoints, int attackRange)
        {
            Kingdom = kingdom;
            Name = name;
            Diet = diet;
            Habitat = habitat;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
            AttackRange = attackRange;
        }
        public Entity() { }
        public int currentEnergy
        {
            get { return CurrentEnergy; }
            set { CurrentEnergy = value; }
        }
        public void Attack(Entity entity)
        {
            entity.currentEnergy -= AttackPoints; 
        }

        public void Feed()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void RangeAttack()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            return $"Reino:{Kingdom}, Nombre:{Name}, Dieta:{Diet}, Habitat:{Habitat}, Energía actual:{CurrentEnergy}, Energía Máxima:{MaxEnergy}, Vida Actual:{CurrentLife}, Vida Máxima:{MaxLife}, Puntos de Ataque:{AttackPoints}, Escudo de Defensa:{DefensePoints}, Fuerza del ataque a distancia:{AttackRange}";
        }
    }
}
