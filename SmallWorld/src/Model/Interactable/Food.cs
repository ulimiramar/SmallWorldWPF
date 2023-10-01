using SmallWorld.src.Interfaces;
using SmallWorld.src.Model.Reino;
using SmallWorld.src.Model.Terrain;
using SmallWorld.src.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Interactuable
{
    public class Food : IInteractable, IPositionable
    {
        private static int lastId = 0;
        public int Id { get; private set; }
        private string name;
        private List<IDiet> diet;
        private int energyValue;

        public string Name { get => name; set => name = value; }
        public List<IDiet> Diet { get => diet; set => diet = value; }
        public string DietNames { 
            get 
            {
                string dietListString = "";
                foreach(var d in diet)
                {
                    dietListString = string.Join(", ", diet);
                }
                return dietListString;
            } 
        }
        public int EnergyValue { get => energyValue; set => energyValue = value; }

        public Food(string name, List<IDiet> diet, int energyValue)
        {
            lastId++;
            Id = lastId;
            Name = name;
            Diet = diet;
            EnergyValue = energyValue;
            PositionableObjectRegistry.Register(this);
        }

        public Food()
        {
        }

        //TODO: sacar esto de acá, ya no lo uso
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

        void IPositionable.Position(Land land)
        {
            throw new NotImplementedException();
        }
    }
}
