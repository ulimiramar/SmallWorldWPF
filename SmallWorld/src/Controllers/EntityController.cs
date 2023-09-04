using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Reino;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public void AddEntity(IKingdom kingdom, string name,IDiet diet, IHabitat habitat, int atkPonints, int defPoints, bool range, int maxLife, int maxEnergy, int defenseShield)
        {            
            Entities.Add(new Entity(kingdom, name, diet, habitat, atkPonints, defPoints, range, maxLife, maxEnergy, defenseShield));
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

        


        /* Otra idea de lógica de ataque

        /// <summary>
        /// Logica del ataque: primero se lanzarían los dados (que eso todavía no lo hice)
        /// el que gane será el atacante.La lógica es que la entidad atacante
        /// le resta la misma cantidad que tiene de su fuerza de ataque a la entidad que se defiende
        /// la entidad que se defiende tiene 3 capas de defensa.Primero tiene su escudo de defensa.
        /// una vez destruido el escudo de defensa, se empieza a disminuir su energía actual
        /// cuando su energía actual llega a 0, pierde una vida de las vidas actuales y se reestablece
        /// a 100 su energia actual.
        /// cuando pierde todas las vidas la entidad muere.
        /// </summary>


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
        }*/

        
    }
}
