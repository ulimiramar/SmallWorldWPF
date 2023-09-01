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

        private readonly List<Kingdom> Kingdoms = new List<Kingdom>();

        private KingdomController() { }

        public static KingdomController GetInstance()
        {
            if (instance == null)
            {
                instance = new KingdomController();
            }
            return instance;
        }

        public List<Kingdom> GetKingdoms()
        {
            return Kingdoms;
        }
        public void CreateKingdom(string kingdomName)
        {
            Kingdoms.Add(new Kingdom(kingdomName));
        }
        public Kingdom ReadKingdom(int id)
        {
            return Kingdoms.Find(kingdom => kingdom.Id == id);
        }
        public void UpdateKingdom(Kingdom kingdomUpdated)
        {
            Kingdom KingdomFound = Kingdoms.FirstOrDefault(k => k.Id == kingdomUpdated.Id);
            if (KingdomFound != null)
            {
                KingdomFound.Name = kingdomUpdated.Name;
            }
            else MessageBox.Show("Reino no encontrado");
        }
        public void DeleteKingdom(Kingdom kingdom)
        {
            kingdom.Deleted = true;
        }
    }
}
