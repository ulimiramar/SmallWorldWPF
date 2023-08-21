using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Reino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.Controllers
{
    internal class EntityController
    {
        private readonly static EntityController EntitiesController = new EntityController();

        private readonly List<Entity>Entities = new List<Entity>();

        private EntityController () { }
        public static EntityController GetController()
        {
            return EntitiesController;
        }

        public void AddEntity(Entity entity)
        {
            Entities.Add(entity);
        }
        /*static public void CreateEntity(IKingdom Kingdom, string Name, IDiet Diet, IHabitat Habitat, int AttackPoints, int DefensePoints, int AttackRange)
        {
            Entities.Add(new Entity(Kingdom, Name, Diet, Habitat, AttackPoints, DefensePoints, AttackRange));
            Console.WriteLine("Entity added.");
        }*/

        public List<Entity> getEntities()
        {
            return Entities;
        }
        public List<Entity> getEntitiesCopy1()
        {
            List<Entity> ListForComboBox1 = new List<Entity>(Entities);
            return ListForComboBox1;
        }
        public List<Entity> getEntitiesCopy2()
        {
            List<Entity> ListForComboBox2 = new List<Entity>(Entities);
            return ListForComboBox2;
        }

        public void ReadEntities()
        {
            if (Entities.Count == 0)
            {
                Console.WriteLine("No entities to display.");
                return;
            }

            foreach (var Entity in Entities)
            {
                Console.WriteLine(Entity.ToString());
            }
            
        }

        public void Attack(Entity AttackingEntity, Entity DefendingEntity)
        {
            if (DefendingEntity.DefensePoints > 0)
            {
                DefendingEntity.DefensePoints -= AttackingEntity.AttackPoints;
                VerifyDefenseStatus(DefendingEntity);
            }
            else if (DefendingEntity.DefensePoints <= 0 && DefendingEntity.CurrentEnergy > 0)
            {
                DefendingEntity.CurrentEnergy -= AttackingEntity.AttackPoints;
                VerifyEnergyStatus(DefendingEntity);
            }
            
        }

        public void VerifyDefenseStatus(Entity DefendingEntity)
        {
            if (DefendingEntity.DefensePoints <= 0)
            {
                DefendingEntity.CurrentEnergy += DefendingEntity.DefensePoints;
                DefendingEntity.DefensePoints = 0;
                MessageBox.Show($"El escudo de {DefendingEntity.Name} ha sido destruido");
            }
        }

        public void VerifyEnergyStatus(Entity DefendingEntity)
        {
            if (DefendingEntity.CurrentEnergy <= 0)
            {
                if (VerifyAmountOfLivesAvailable(DefendingEntity))
                {
                    DefendingEntity.CurrentLife--;
                    DefendingEntity.CurrentEnergy = 100 + DefendingEntity.CurrentEnergy;
                    MessageBox.Show($"{DefendingEntity.Name} Ha perdido una vida");
                }
                else
                {
                    DefendingEntity.CurrentEnergy = 0;
                    MessageBox.Show($"{DefendingEntity.Name} Ha sido exterminado");
                }
            }
        }

        public bool VerifyAmountOfLivesAvailable(Entity DefendingEntity)
        {
            if (DefendingEntity.CurrentLife < 1)
            {
                return false;
            }
            else { return true; }
        }

        public string VerifyIfTheDefenseIsDestroy(Entity DefendingEntity)
        {
            if (DefendingEntity.DefensePoints <=0)
            { 
            return $"El escudo de {DefendingEntity.Name} ha sido destrudo";
            }
            return null;
        }

        /*static public List<string> ReadEntity()
        {
            List<string> EntitiesData = new List<string>();
            foreach (var Entity in Entities)
            {
                EntitiesData.Add(Entity.ToString());
            }
            return EntitiesData;
        }*/
    }
}
