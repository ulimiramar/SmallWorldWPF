using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Interactuable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Controllers
{
    internal class FoodController
    {
        private static FoodController instance;
        private readonly List<Food> Foods = new List<Food>();
        private FoodController() { }

        public static FoodController GetInstance()
        {
            if (instance == null)
            {
                instance = new FoodController();
            }
            return instance;
        }


        public void AddFood(string name, List<IDiet> diet, int energyValue)
        {
            Food FoodToAdd = new Food(name,diet,energyValue);
            Foods.Add(FoodToAdd);
        }


        public List<Food> getFoods()
        {
            return Foods;
        }




        public void Delete(Food food)
        {
            Foods.Remove(food);
        }



        public void Update(int id, string name, List<IDiet> diet, int energyValue)
        {
            foreach (Food FoodToUpdate in Foods)
            {
                if (FoodToUpdate.Id == id)
                {
                    FoodToUpdate.Name = name;
                    FoodToUpdate.Diet = diet;
                    FoodToUpdate.EnergyValue = energyValue;
                    break;
                }
            }
        }
        public void Update(Food foodToModify, Food foodModified)
        {

            int index = Foods.FindIndex(e => e == foodToModify);

            if (index != -1)
            {
                Foods[index] = foodModified;

            }
        }

    }
}
