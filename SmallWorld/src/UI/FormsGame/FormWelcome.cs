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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            new FormGame(gameController.getGameOptions()).Show();
        }
    }
}
