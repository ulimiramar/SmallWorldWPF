using SmallWorld.src.Controllers;
using SmallWorld.src.UI.CustomForms;
using SmallWorld.src.UI.FormsGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            this.Enabled = false;
            new FormsGame.FormGame().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCodeView_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/ulisesbasualdo/SmallWorldGame";

            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el navegador: " + ex.Message);
            }
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            new CustomMessageBoxForm($"Cada jugador tiene {gameController.getGameOptions().TimeTurn} \n" +
                $"segundos para hacer lo que quiera, \n" +
                $"gana el jugador que más entidades tenga al \n" +
                $"finalizar el tiempo del juego o en caso de \n" +
                $"eliminar todas las entidades enemigas").ShowDialog();
        }
    }
}
