using Newtonsoft.Json.Linq;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Dieta;
using SmallWorld.src.Model.Interactuable;
using SmallWorld.src.Model.Reino;
using SmallWorld.src.Static;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SmallWorld.src.Controllers
{
    internal class EntityController
    {
        private static EntityController instance;
        private readonly List<Entity> Entities = new List<Entity>();
        Random random = new Random();

        private EntityController() { }

        public static EntityController GetInstance()
        {
            if (instance == null)
            {
                instance = new EntityController();
            }
            return instance;
        }

        public void AddEntity(IKingdom kingdom, string name, IDiet diet, List<IHabitat> habitatList, int atkPonints, int defPoints, bool range, int maxLife, int maxEnergy)
        {
            Entity EntityToAdd = new Entity(kingdom, name, diet, habitatList, atkPonints, defPoints, range, maxLife, maxEnergy);
            Entities.Add(EntityToAdd);
        }

        public async Task AddRandomsEntitiesAsync(int num)
        {
            List<string> randomNames = await RandomNames(num);
            for (int i = 0; i < num; i++)
            {
                Entities.Add(new Entity(InterfacesImplementations.GetRandomKingdom(), 
                    randomNames[i], InterfacesImplementations.GetRandomDiet(),
                    InterfacesImplementations.GetRandomHabitatList(), random.Next(1, 100),
                    random.Next(1, 100), random.Next(2) == 0, 100, 100));
            }
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



        public void Delete(Entity entity)
        {
            Entities.Remove(entity);
        }


        /*
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
        }*/

        public void Update(Entity entityToModify, Entity entityModified)
        {

            int index = Entities.FindIndex(e => e == entityToModify);

            if (index != -1)
            {
                Entities[index] = entityModified;

            }
        }
        public void Eat(Entity entity, Food food)
        {
            if (food.Diet.Contains(entity.Diet))
            {
                entity.CurrentEnergy += food.EnergyValue;
            }
            else throw new Exception($"no es compatible con la dieta. {food.Name} {food.DietNames} != {entity.Name} {entity.Diet}");
        }

        public async Task<string> RandomName()
        {
            string apiRandomsNamesUrl = "https://randomuser.me/api/?nat=es";
            string randomName = "";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiRandomsNamesUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        var data = JObject.Parse(content);

                        // Accede al campo "results" y obtén el primer nombre
                        randomName = data["results"][0]["name"]["first"].ToString();
                    }
                    else throw new Exception("Error al realizar la solicitud HTTP. Código de estado: " + response.StatusCode);
                    
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Error al realizar la solicitud HTTP: " + e.Message);
                }
            }
            return randomName;
        }

        public async Task<List<string>> RandomNames(int numberOfNames)
        {
            string apiRandomsNamesUrl = "https://randomuser.me/api/?nat=es&results=" + numberOfNames;
            List<string> randomNames = new List<string>();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiRandomsNamesUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        var data = JObject.Parse(content);

                        var results = data["results"];
                        foreach (var result in results)
                        {
                            string firstName = result["name"]["first"].ToString();
                            randomNames.Add(firstName);
                        }
                    }
                    else throw new Exception("Error al realizar la solicitud HTTP. Código de estado: " + response.StatusCode);

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Error al realizar la solicitud HTTP: " + e.Message);
                }
            }
            return randomNames;
        }

    }
}



