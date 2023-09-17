using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Interactuable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmallWorld.src.UI
{
    public partial class FoodCrudFormTest : Form
    {
        FoodController foodController = FoodController.GetInstance();
        public FoodCrudFormTest()
        {
            InitializeComponent();
            FillComboBoxes();
            RefreshDataGridItems();
        }
        private void FillComboBoxes()
        {
            // Llena el ComboBox de Diet con las clases que implementan IDiet
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IDiet))))
            {
                cbDiet.Items.Add(Activator.CreateInstance(type));
            }
        }
        private void RefreshDataGridItems()
        {
            bsFoods.DataSource = foodController.getFoods();
            bsFoods.ResetBindings(false);
            dgvFoods.DataSource = bsFoods;
        }

        private void btnCreateFood_Click(object sender, EventArgs e)
        {
            try
            {
                //EntityController.GetInstance().AddEntity()
                //foodController.AddFood(txtFoodName.Text, (IDiet)cbDiet.SelectedItem, Convert.ToInt32(txtEnergyValue.Text) ) ;
                RefreshDataGridItems();
                ClearFormControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearFormControls()
        {
            txtFoodName.Clear();
            cbDiet.SelectedIndex = -1;
            txtEnergyValue.Clear();
            
        }

        private bool UpdateMode = false;
        private void btnModifyUpdateFood_Click(object sender, EventArgs e)
        {
            if (!UpdateMode)
            {
                // Modo "Modificar" a "Actualizar"
                UpdateMode = true;
                btnModifyUpdateFood.Text = "Actualizar";
                btnCreateFood.Enabled = false;
                btnCancelUpdate.Visible = true;
                btnDeleteFood.Enabled = false;
                dgvFoods.Enabled = false;

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvFoods.SelectedRows[0];

                // Obtener la entidad seleccionada
                Food foodToUpdate = (Food)selectedRow.DataBoundItem;

                // Mostrar los datos en los controles del formulario
                txtFoodName.Text = foodToUpdate.Name;
                cbDiet.SelectedItem = foodToUpdate.Diet;
                txtEnergyValue.Text = foodToUpdate.EnergyValue.ToString();
                lblId.Text = foodToUpdate.Id.ToString();

            }
            else
            {
                // Modo "Actualizar" a "Modificar"
                UpdateMode = false;
                btnModifyUpdateFood.Text = "Modificar";
                btnCreateFood.Enabled = true;
                btnDeleteFood.Enabled = true;
                btnCancelUpdate.Visible = false;
                dgvFoods.Enabled = true;

                //foodController.Update(Convert.ToInt32(lblId.Text), txtFoodName.Text, (IDiet)cbDiet.SelectedItem, Convert.ToInt32(txtEnergyValue.Text));
                RefreshDataGridItems();
                ClearFormControls();
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            UpdateMode = false;
            btnModifyUpdateFood.Text = "Modificar";
            btnCancelUpdate.Visible = false;
            btnCreateFood.Enabled = true;
            btnDeleteFood.Enabled = true;
            dgvFoods.Enabled = true;
            ClearFormControls();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoods.SelectedRows[0];
                Food foodToDelete = (Food)selectedRow.DataBoundItem;

                foodController.Delete(foodToDelete);
                RefreshDataGridItems();

            }
            else MessageBox.Show("Seleccionar una comida");
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            txtFoodName.Text = GetRandomString(8); // Genera una cadena aleatoria de longitud 8

            int randomDietIndex = random.Next(0, cbDiet.Items.Count);
            cbDiet.SelectedIndex = randomDietIndex;

            txtEnergyValue.Text = Convert.ToString(random.Next(10, 100));
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
