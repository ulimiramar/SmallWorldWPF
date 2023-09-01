using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.Controllers
{
    internal class KingdomController
    {
        
        private static KingdomController instance;

        private readonly List<IKingdom> Kingdoms = new List<IKingdom>();

        private KingdomController() { }

        public static KingdomController GetController()
        {
            if (instance == null)
            {
                instance = new KingdomController();
            }
            return instance;
        }

        public void CreateKingdom(IKingdom kingdom)
        {
            Kingdoms.Add(kingdom);
        }
        public IKingdom ReadKingdom(int id)
        {
            return Kingdoms.Find(kingdom => kingdom.Id == id);
        }
        public void UpdateDiet(IKingdom kingdomUpdated)
        {
            IKingdom KingdomFound = Kingdoms.FirstOrDefault(k => k.Id == kingdomUpdated.Id);
            if (KingdomFound != null)
            {
                KingdomFound.Name = kingdomUpdated.Name;
            }
            else MessageBox.Show("Reino no encontrado");
        }
        public void DeleteDiet(IKingdom kingdom)
        {
            kingdom.Deleted = true;
        }
    }
}
