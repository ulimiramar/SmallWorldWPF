using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI.FormsGame
{
    public partial class FormGame : Form
    {
        public FormGame(Model.Game.Game gameOptions)
        {
            //TODO: empezar a llenar los datos de los datagrid view y generar el mapa
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }
    }
}
