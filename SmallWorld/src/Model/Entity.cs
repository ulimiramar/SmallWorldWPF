﻿using SmallWorld.src.Interfaces;
using SmallWorld.src.Model.Interactable;
using SmallWorld.src.Model.Interactuable;
using SmallWorld.src.Model.Map;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.Model
{
    internal class Entity
    {
        private static int lastId = 0;
        public int Id { get; private set; }
        IKingdom kingdom;
        string name;
        IDiet diet;
        IHabitat habitat;

        int maxEnergy;
        int currentEnergy;
        int maxLife;
        int currentLife;

        int attackPoints;
        int defensePoints;
        bool attackRange;
        int costToAttack;

        Terrain currentTerrain;
        bool dieStatus;
        int defenseShield;
        //Point position;



        //properties
        //TODO: hacer validaciones en propiedades, informar de alguna manera si esta muerto y no puede recibir mas ataques, talvez borrandolo de la lista, o que la lista traiga solo los vivos. y los interacts se traigan los muertos para abono.
       
       
        
        internal IKingdom Kingdom
        {
            get => kingdom;
            set
            {
                if (value != null) kingdom = value;
                else throw new InvalidOperationException("Debe seleccionar un Reino");
            }
        }
        public string KingdomName { get { return kingdom.ToString(); } }
        public string Name
        {
            get => name;
            set
            {
                if (value != null) name = value;
                else throw new InvalidOperationException("Debe especificar un Nombre");
            }
        }

        internal IDiet Diet
        {
            get => diet;
            set
            {
                if (value != null) diet = value;
                else throw new InvalidOperationException("Debe especificar una Dieta");
            }
        }
        public string DietName { get { return diet.ToString(); } }
        internal IHabitat Habitat
        {
            get => habitat;
            set
            {
                if (value != null) habitat = value;
                else throw new InvalidOperationException("Debe seleccionar un Habitat");
            }
        }
        public string HabitatName { get { return habitat.ToString(); } }
        public int MaxEnergy
        {
            get => maxEnergy;
            set
            {
                if (value > 0) maxEnergy = value;
                else throw new InvalidOperationException("La energía máxima debe ser mayor a 0");
            }
        }
        public int MaxLife {
            get => maxLife;
            //get { return maxLife; }
            set
            {
                if (value > 0) maxLife = value;
                else throw new InvalidOperationException("La vida máxima debe ser mayor a 0");
            }
        }
        public int CurrentLife
        {
            get => currentLife;
            set
            {
                if (value <= 0)
                {
                    currentLife = 0;
                    DieStatus = true;
                    throw new Exception("Está muerto");
                }
                else if (value > MaxLife)
                {
                    currentLife = MaxLife;
                }
                else
                {
                    currentLife = value;
                }
            }
        }

        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public int DefensePoints { get => defensePoints; set => defensePoints = value; }
        public bool AttackRange { get => attackRange; set => attackRange = value; }
        public int CurrentEnergy
        {
            get => currentEnergy;
            set
            {
                if (value < 0)
                {
                    currentEnergy = 0;
                }
                else if (value > MaxEnergy)
                {
                    currentEnergy = MaxEnergy;
                }
                else
                {
                    currentEnergy = value;
                }
            }
        }
        public bool DieStatus { get => dieStatus; set => dieStatus = value; }
        public int CostToAttack { get => costToAttack; set => costToAttack = value; }
        public int DefenseShield { get => defenseShield; set => defenseShield = value; }

        //public Terrain CurrentTerrain { get => currentTerrain; set => currentTerrain = value; }

        //public Point Position { get => position; set => position = value; }

        //constructor
        public Entity(IKingdom kingdom, string name, IDiet diet, IHabitat habitat, int attackPoints, int defensePoints, bool attackRange, int maxLife, int maxEnergy, int defenseShield)
        {
            lastId++;
            Id = lastId;
            Kingdom = kingdom;
            Name = name;
            Diet = diet;
            Habitat = habitat;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
            AttackRange = attackRange;
            MaxLife = maxLife;
            CurrentLife = maxLife;
            MaxEnergy = maxEnergy;
            CurrentEnergy = maxEnergy;
            CostToAttack = 30;
            DefenseShield = defenseShield;
            //CurrentTerrain = currentTerrain;
            //Position = position;
        }
        public Entity() { }

        

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

        public void Rest()
        {
            CurrentEnergy += 50;
            CurrentLife += 100;
        }


        


        /// <summary>
        /// This method does that the attacking entity throw a dice and attack to the
        /// victim entity with his attack points and the random value of the trowing dice.
        /// Attack had a cost of energy
        /// </summary>
        /// <param name="EntityToAttack"></param>
        public void Attack(Entity EntityToAttack)
        {
            if (!NeedEnergyToDoAnAction(CostToAttack))
            {
                CurrentEnergy -= CostToAttack;
                int DicePoints = Dice.TrowDice(6);
                
                int AttackResult = EntityToAttack.TakeDamage(AttackPoints, DicePoints);
                if (AttackResult > 0)
                {
                    CurrentLife -= AttackResult;
                    throw new Exception("Ganó la defensa, se te quitarán puntos de vida.");
                }

            }
        }

        /*función para dañar un escudo de defensa
        public void TakeDamage(int AttackPointsOfTheAttackingEntity, int AttackDicePoints)
        {
            if (ShieldIsDestroyed())
            {
                CurrentLife -= (AttackPointsOfTheAttackingEntity + AttackDicePoints);
                VerifyMinCurrentLife();
            }
            else 
            { 
                DefenseShield -= (AttackPointsOfTheAttackingEntity + AttackDicePoints);
                VerifyStatusOfDefenseShield();
            }
        }*/

        //TODO: arreglar esto
        public int TakeDamage(int AttackPointsOfTheAttackingEntity, int AttackDicePoints)
        {
            int DicePoints2 = Dice.TrowDice(6);
            Console.WriteLine($"Dado atacante: {AttackDicePoints} Dado Victima: {DicePoints2}");
            MessageBox.Show($"Dado atacante: {AttackDicePoints} Dado Victima: {DicePoints2}");
            
            int AttackResult = CurrentLife + ((DefensePoints + DicePoints2) - (AttackPointsOfTheAttackingEntity + AttackDicePoints));

            if (AttackResult < CurrentLife)
            {
                CurrentLife = AttackResult;
                AttackResult = 0;
                throw new Exception("Ataque exitoso");
            }
            else if (AttackResult > CurrentLife)
            {
                AttackResult -= CurrentLife;
            }
            else if (AttackResult == CurrentLife)
            {
                AttackResult = 0;
                throw new Exception("Hay un empate");
            }
            return AttackResult;
        }

        //TODO: pensar en entidad ataque, si el valor es negativo pierde la entidad atacante. se puede devolver en takeDamage con un return un valor.


        /*Problema con la formula propuesta para el ataque:
        VidaActualDelAtacado = VidaActualDelAtacado - ((PuntosDefensaDelAtacado + DicePoints2) - (PuntosAtaqueDelAtacante + AttackDicePoints));
        Suponiendo que la vida actual del atacado es igual a 100
        //Caso 1 donde los puntos de ataque del atacante son menores a los puntos de defensa del defendiente     
        //            VidaActualDelAtacado = 100 - (100 - 50) 
        //            VidaActualDelAtacado = 100 - 50
        //            VidaActualDelAtacado  = 50
        //            
        //Caso 2 donde los puntos de ataque del atacante son mayores a los puntos de defensa del defendiente 
        //            VidaActualDelAtacado = 100 - (50 - 100) 
        //            VidaActualDelAtacado = 100 - - 50
        //            VidaActualDelAtacado  = 150
        //El problema que veo es que si el atacante es mas fuerte, si se usa esa fórmula el defendiente no pierde puntos.
        //
        //Solución que propongo: 
        cambiar la formula: VidaActualDelAtacado = VidaActualDelAtacado - ((PuntosDefensaDelAtacado + DicePoints2) - (PuntosAtaqueDelAtacante + AttackDicePoints));
        por esta formula:   VidaActualDelAtacado = VidaActualDelAtacado + ((PuntosDefensaDelAtacado + DicePoints2) - (PuntosAtaqueDelAtacante + AttackDicePoints));
        entonces si se da que el defendiente sale ganando en cantidad de puntos,
        hacer un condicional que si el resultado de la formula es mayor a la vida actualdelatacado
        la vida actual del atacado no se toca.
        Habría que ver cómo se hace si quieren que haya una especie de efecto rebote y la entidad atacante reciba el daño por perder.
        */


        public bool ShieldIsDestroyed()
        {
            bool shieldIsDestroyed = false;
            if (DefenseShield <= 0)
            {
                shieldIsDestroyed = true;
            }
            return shieldIsDestroyed;
        }


        /// <summary>
        /// If after of attack the defense shield had a negative value, 
        /// this points substract CurrentLife
        /// </summary>
        public void VerifyStatusOfDefenseShield()
        {
            if (DefenseShield < 0)
            {
                CurrentLife += DefenseShield;
                DefenseShield = 0;
                VerifyMinCurrentLife();
            }
        }

        public void Interact (Item objectInteractable)
        {
            //CurrentLife = CurrentLife + objectInteractable.Points;
        }


        /*public void Move(Terrain DestinyTerrain)
        {
            //TODO: validacion de si el habitat coincide con el terreno
            CurrentTerrain = DestinyTerrain;
        }*/

        /*
        public void VerifyMaxLife()
        {
            if(CurrentLife > MaxLife)
            {
                CurrentLife = MaxLife;
            }
        }*/

        public void VerifyMinCurrentLife()
        {
            if (CurrentLife <= 0)
            {
                CurrentLife = 0;
                Die();
            }
        }

        public void VerifyMaxEnergy()
        {
            if (CurrentEnergy > MaxEnergy)
            {
                CurrentEnergy = MaxEnergy;
            }
        }

        /*esto lo hacía antes de validar en las propiedades, se puede borrar
        public void VerifyMinCurrentEnergy() 
        {
            if (CurrentEnergy <= 0)
            {
                CurrentEnergy = 0;
                MessageBox.Show($"{name} tiene energía 0, debe dormir para recuperar energía");
            }
        }*/
        public void Die()
        {
            DieStatus = true;
        }

        public bool NeedEnergyToDoAnAction(int Action)
        {
            bool needEnergy = false;
            if (Action > CurrentEnergy)
            {
                needEnergy = true;
                throw new Exception($"{Name}necesita descansar y así recuperar energía antes de hacer esta acción");
            }
            return needEnergy;
        }

        


        public override string ToString()
        {
            return name;
            //return $"Reino:{Kingdom}, Nombre:{Name}, Dieta:{Diet}, Habitat:{Habitat}, Energía actual:{CurrentEnergy}, Energía Máxima:{MaxEnergy}, Vida Actual:{CurrentLife}, Vida Máxima:{MaxLife}, Puntos de Ataque:{AttackPoints}, Escudo de Defensa:{DefensePoints}, Fuerza del ataque a distancia:{AttackRange}";
        }
    }
}
