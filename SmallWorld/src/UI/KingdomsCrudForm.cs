using SmallWorld.src.Controllers;
using SmallWorld.src.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI
{
    public partial class KingdomsCrudForm : Form
    {
        KingdomController kingdomController = KingdomController.GetInstance();
        public KingdomsCrudForm()
        {
            InitializeComponent();
            
        }

        private void btnCreateKingdom_Click(object sender, EventArgs e)
        {
            kingdomController.CreateKingdom(txtKingdomName.Text);
        }

        private void btnDeleteKingdom_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada
            if (dgvKingdoms.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada (asumiendo que solo hay una fila seleccionada)
                DataGridViewRow selectedRow = dgvKingdoms.SelectedRows[0];

                // Obtén el objeto Kingdom asociado a la fila seleccionada
                Kingdom selectedKingdom = (Kingdom)selectedRow.DataBoundItem;

                // Llama a tu función de controladora y pasa el objeto Kingdom
                kingdomController.DeleteKingdom(selectedKingdom);
            }
            else
            {
                MessageBox.Show("Selecciona un reino antes de eliminarlo.");
            }
        }

        private void btnGetKingdoms_Click(object sender, EventArgs e)
        {
	    //TODO: todavía no funciona este botón, si lo apreto no trae la lista de kingdoms
            dgvKingdoms.DataSource = kingdomController.GetKingdoms();
            dgvKingdoms.Refresh();
        }
    }
}
