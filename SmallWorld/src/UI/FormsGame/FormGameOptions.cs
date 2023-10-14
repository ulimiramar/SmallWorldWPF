using SmallWorld.src.Controllers;
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
    public partial class FormGameOptions : Form
    {
        private GameController gameController = GameController.GetInstance();
        public FormGameOptions()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gameController.SetGameOptions(Convert.ToInt32(txtPlayer1NumEntities.Text), 
                Convert.ToInt32(txtPlayer2NumEntities.Text), Convert.ToInt32(txtItemsNum.Text), 
                Convert.ToInt32(txtFoodNum.Text));
        }

    }
}
