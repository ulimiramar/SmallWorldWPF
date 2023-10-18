using SmallWorld.src.Controllers;
using SmallWorld.src.UI.CustomForms;
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
            if (txtPlayer1NumEntities.Text != "" && txtPlayer2NumEntities.Text != "" && txtItemsNum.Text != "" && txtFoodNum.Text != "")
            {
                int P1Entities = Convert.ToInt32(txtPlayer1NumEntities.Text);
                int p2Entities = Convert.ToInt32(txtPlayer2NumEntities.Text);
                int items = Convert.ToInt32(txtItemsNum.Text);
                int food = Convert.ToInt32(txtFoodNum.Text);
                if (P1Entities <= 200 && p2Entities <= 200 && items <= 200 && food <= 200)
                {
                    gameController.SetGameOptions(P1Entities, p2Entities, items, food);
                    new CustomMessageBoxForm("Guardado con éxito").ShowDialog();
                    this.Close();
                }
            }
            else new CustomMessageBoxForm("las cantidades deben ser\n menores o iguales a 200\n y mayores a 0").ShowDialog();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
