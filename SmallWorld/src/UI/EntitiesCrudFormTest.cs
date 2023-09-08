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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmallWorld.src.UI
{
    public partial class EntitiesCrudFormTest : Form
    {
        EntityController entityController = EntityController.GetInstance();
        public EntitiesCrudFormTest()
        {
            InitializeComponent();

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

        private void btnDeleteEntity_Click(object sender, EventArgs e)
        {
            if (dgvEntities.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEntities.SelectedRows[0];
                Entity entityToDelete = (Entity)selectedRow.DataBoundItem;

                entityController.Delete(entityToDelete);                
                UpdateDataGridEntities();

            }
            else MessageBox.Show("Seleccionar una entidad");
        }

        private void btnCreateEntity_Click_1(object sender, EventArgs e)
        {
            try
            {
                //EntityController.GetInstance().AddEntity()
                entityController.AddEntity((IKingdom)cbKingdom.SelectedItem, txtName.Text, (IDiet)cbDiet.SelectedItem, (IHabitat)cbHabitat.SelectedItem, Convert.ToInt32(txtAttackPoints.Text), 100, chbAttackRange.Checked, Convert.ToInt32(txtMaxLife.Text), Convert.ToInt32(txtMaxEnergy.Text), Convert.ToInt32(txtDefenseShield.Text));             
                UpdateDataGridEntities();
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// Save in binding-source the list of entities,
        /// then it is established that columns will not be modified, only data.
        /// Then the binding-source is asigned to data-source of the data-grid to update it.
        /// In resume this method update the datagrid data.
        /// </summary>
        private void UpdateDataGridEntities()
        {
            dgvEntitiesBs.DataSource = entityController.getEntities();
            dgvEntitiesBs.ResetBindings(false);
            dgvEntities.DataSource = dgvEntitiesBs;
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            txtName.Text = GetRandomString(8); // Genera una cadena aleatoria de longitud 8
                                              
            // Seleccionar un índice aleatorio para Kingdom
            int randomKingdomIndex = random.Next(0, cbKingdom.Items.Count);
            cbKingdom.SelectedIndex = randomKingdomIndex;

            // Seleccionar un índice aleatorio para Habitat
            int randomHabitatIndex = random.Next(0, cbHabitat.Items.Count);
            cbHabitat.SelectedIndex = randomHabitatIndex;

            // Seleccionar un índice aleatorio para Diet
            int randomDietIndex = random.Next(0, cbDiet.Items.Count);
            cbDiet.SelectedIndex = randomDietIndex;

            txtMaxLife.Text= Convert.ToString(random.Next(10, 100));
            txtMaxEnergy.Text = Convert.ToString(random.Next(10, 100));
            txtAttackPoints.Text = Convert.ToString(random.Next(10, 100));
            txtDefensePoints.Text = Convert.ToString(random.Next(10, 100));
            txtDefenseShield.Text = Convert.ToString(random.Next(10, 100));
        }

        private string GetRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
