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
    internal class ItemController
    {
        private static ItemController instance;
        private readonly List<Item> Items = new List<Item>();
        private ItemController() { }

        public static ItemController GetInstance()
        {
            if (instance == null)
            {
                instance = new ItemController();
            }
            return instance;
        }


        public void AddItem(IEffectStrategy effectStrategy)
        {
            Item ItemToAdd = new Item(effectStrategy);
            Items.Add(ItemToAdd);
        }


        public List<Item> getItems()
        {
            return Items;
        }
        



        public void Delete(Item item)
        {
            Items.Remove(item);
        }



        public void Update(int id, IEffectStrategy effecStrategy)
        {
            foreach (Item ItemToUpdate in Items)
            {
                if (ItemToUpdate.Id == id)
                {
                    ItemToUpdate.EffectStrategy = effecStrategy;
                    break;
                }
            }
        }
    }
}
