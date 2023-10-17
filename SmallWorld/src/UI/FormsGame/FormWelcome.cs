using SmallWorld.src.Controllers;
using SmallWorld.src.UI.FormsGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmallWorld.src.UI.Game
{
    public partial class FormWelcome : Form
    {
        GameController gameController = GameController.GetInstance();
        EntityController entityController = EntityController.GetInstance();
        ItemController itemController = ItemController.GetInstance();
        FoodController foodController = FoodController.GetInstance();
        MapController mapController = MapController.GetInstance();
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            new FormGameOptions().ShowDialog();
        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> numPlayersAndNumEntities = new Dictionary<int, int>();
            numPlayersAndNumEntities[1] = gameController.getGameOptions().P1EntitiesNum;
            numPlayersAndNumEntities[2] = gameController.getGameOptions().P2EntitiesNum;

            await entityController.AddRandomsEntitiesAsync(numPlayersAndNumEntities); 
            itemController.AddRandomItems(gameController.getGameOptions().ItemsNum);
            foodController.AddRandomFoods(gameController.getGameOptions().FoodNum);
            mapController.GenerateUniqueMap();
            new FormsGame.FormGame().Show();
        }
    }
}
