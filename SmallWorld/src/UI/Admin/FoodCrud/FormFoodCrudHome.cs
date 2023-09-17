using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Interactuable;
using SmallWorld.src.UI.Admin.EntityCrud;
using SmallWorld.src.UI.Admin.FoodCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI.Admin
{
    public partial class FormFoodCrudHome : Form
    {
        private FoodController foodController = FoodController.GetInstance();
        public FormFoodCrudHome()
        {
            InitializeComponent();
            RefreshDataGridFood();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new FormCreateFood().ShowDialog();
            RefreshDataGridFood();
        }
        private void RefreshDataGridFood()
        {
            bsFood.DataSource = foodController.getFoods();
            bsFood.ResetBindings(false);
            dgvFood.DataSource = bsFood;
        }


        private void dgvFood_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvFood.SelectedRows[0];
            Food food = (Food)selectedRow.DataBoundItem;


            FormEditFood formEditFood = new FormEditFood(food);
            formEditFood.ShowDialog();
            RefreshDataGridFood();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFood.SelectedRows[0];
                Food foodToDelete = (Food)selectedRow.DataBoundItem;

                foodController.Delete(foodToDelete);
                RefreshDataGridFood();

            }
            else MessageBox.Show("Seleccionar una comida");
        }
    }
}
