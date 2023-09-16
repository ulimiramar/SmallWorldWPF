using SmallWorld.src.Interfaces;
using SmallWorld.src.Model.Reino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Interactuable
{
    public class Food : IInteractable
    {
        private static int lastId = 0;
        public int Id { get; private set; }
        private string name;
        private IDiet diet;
        private int energyValue;

        public string Name { get => name; set => name = value; }

        //TODO: hacer que este Diet muestre su nombre en el data grid de alimentos, y modificar la función de canEat para que ande
        public IDiet Diet { get => diet; set => diet = value; }
        public int EnergyValue { get => energyValue; set => energyValue = value; }

        public Food(string name, IDiet diet, int energyValue)
        {
            lastId++;
            Id = lastId;
            Name = name;
            Diet = diet;
            EnergyValue = energyValue;
        }

        //TODO: resolver esto no funciona si saco el ToString(), en realidad en el diagrama de clases está distinto
        public bool CanEat(Entity entity)
        {
            bool canEat = false;
            if (entity.Diet == Diet)
            {
                canEat = true;
            }
            return canEat;
        }

        public override string ToString()
        {
            return Name;
        }
        
    }
}
