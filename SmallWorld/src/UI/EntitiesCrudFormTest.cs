using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Dieta;
using SmallWorld.src.Model.Habitat;
using SmallWorld.src.Model.Reino;
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
    public partial class EntitiesCrudFormTest : Form
    {
        EntityController entityController = EntityController.GetInstance();
        public EntitiesCrudFormTest()
        {
            InitializeComponent();
            dgvEntities.DataSource = entityController.getEntities();

            cbKingdom.Items.Add(new Alien());
            cbKingdom.Items.Add(new Animal());
            cbKingdom.Items.Add(new Machine());
            cbKingdom.Items.Add(new Vegetable());

            cbDiet.Items.Add(new Carnivorous());
            cbDiet.Items.Add(new Herbivorous());
            cbDiet.Items.Add(new Omnivorous());

            cbHabitat.Items.Add(new Aerial());
            cbHabitat.Items.Add(new Aquatic());
            cbHabitat.Items.Add(new Terrestrial());
        }
        private void btnCreateEntity_Click(object sender, EventArgs e)
        {

            entityController.AddEntity((IKingdom)cbKingdom.SelectedItem, txtName.Text, (IDiet)cbDiet.SelectedItem, (IHabitat)cbHabitat.SelectedItem, Convert.ToInt32(txtAttackPoints.Text), 100, chbAttackRange.Checked, Convert.ToInt32(txtMaxLife.Text), Convert.ToInt32(txtMaxEnergy.Text), Convert.ToInt32(txtDefenseShield.Text));
            dgvEntities.DataSource = entityController.getEntities();
        }

        private void btnDeleteEntity_Click(object sender, EventArgs e)
        {
            if (dgvEntities.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEntities.SelectedRows[0];
                Entity entityToDelete = (Entity)selectedRow.DataBoundItem;

                entityController.Delete(entityToDelete);

            }
            else MessageBox.Show("Seleccionar una entidad");
        }
    }
}
