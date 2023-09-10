using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Reino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SmallWorld.src.Controllers
{
    internal class EntityController
    {
        private static EntityController instance;
        private readonly List<Entity> Entities = new List<Entity>();
        private EntityController() { }

        //private readonly static EntityController EntitiesController = new EntityController();

        public static EntityController GetInstance()
        {
            if (instance == null)
            {
                instance = new EntityController();
            }
            return instance;
        }

        /*public static EntityController GetController()
        {
            return EntitiesController;
        }*/


        public void AddEntity(IKingdom kingdom, string name, IDiet diet, IHabitat habitat, int atkPonints, int defPoints, bool range, int maxLife, int maxEnergy, int defenseShield)
        {
            Entity EntityToAdd = new Entity(kingdom, name, diet, habitat, atkPonints, defPoints, range, maxLife, maxEnergy, defenseShield);
            Entities.Add(EntityToAdd);
        }
        

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


        //TODO: hacer funcion que obtenga solo la información de los puntos
        /*
        public List<Entity> getNameAndPointsInformation()
        {
            List<Entity> EntityList = new List<Entity>(Entities);
            
        }*/

        /// <summary>
        /// Solo para mostrar por consola la lista de entidades creadas
        /// </summary>
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

        public void Delete(Entity entity)
        {
            Entities.Remove(entity);
        }


        
        public void Update(int id, IKingdom kingdom, string name, IDiet diet, IHabitat habitat, int atkPoints, int defPoints, bool rangeAttack, int maxLife, int maxEnergy, int defenseShield)
        {
            foreach (Entity EntityToUpdate in Entities)
            {
                if (EntityToUpdate.Id == id)
                {
                    EntityToUpdate.Kingdom = kingdom;
                    EntityToUpdate.Name = name;
                    EntityToUpdate.Diet = diet;
                    EntityToUpdate.Habitat = habitat;
                    EntityToUpdate.AttackPoints = atkPoints;
                    EntityToUpdate.DefensePoints = defPoints;
                    EntityToUpdate.AttackRange = rangeAttack;
                    EntityToUpdate.MaxLife = maxLife;
                    EntityToUpdate.MaxEnergy = maxEnergy;
                    EntityToUpdate.DefenseShield = defenseShield;
                    break;
                }
            }
        }

        
    }
}
