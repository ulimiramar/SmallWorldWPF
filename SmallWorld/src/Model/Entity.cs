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
        IKingdom kingdom;
        string name;
        IDiet diet;
        IHabitat habitat;

        int maxEnergy = 100;
        int currentEnergy = 100;
        int maxLife = 3;
        int currentLife = 3;

        int attackPoints;
        int defensePoints;
        int attackRange;

        //properties

        internal IKingdom Kingdom { get { return kingdom; } set => kingdom = value; }
        public string KingdomName { get { return kingdom.ToString(); } }
        public string Name { get => name; set => name = value; }
        internal IDiet Diet { get => diet; set => diet = value; }
        public string DietName { get { return diet.ToString(); } }
        internal IHabitat Habitat { get => habitat; set => habitat = value; }
        public string HabitatName { get { return habitat.ToString(); } }
        public int MaxEnergy { get => maxEnergy; set => maxEnergy = value; }
        public int MaxLife { get => maxLife; set => maxLife = value; }
        public int CurrentLife { get => currentLife; set => currentLife = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public int DefensePoints { get => defensePoints; set => defensePoints = value; }
        public int AttackRange { get => attackRange; set => attackRange = value; }
        public int CurrentEnergy { get => currentEnergy; set => currentEnergy = value; }

        //constructor
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

        

        public void Attack(Entity entity)
        {
            entity.CurrentEnergy -= AttackPoints; 
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
