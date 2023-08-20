using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Controllers
{
    internal class EntityController
    {
        static List<Entity>Entities= new List<Entity>();
        static public void CreateEntity(IKingdom Kingdom, string Name, IDiet Diet, IHabitat Habitat, int AttackPoints, int DefensePoints, int AttackRange)
        {
            Entities.Add(new Entity(Kingdom, Name, Diet, Habitat, AttackPoints, DefensePoints, AttackRange));
            Console.WriteLine("Entity added.");
        }


        static public void ReadEntities()
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
