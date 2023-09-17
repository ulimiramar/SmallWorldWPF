using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
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

namespace SmallWorld.src.UI.Admin.FoodCrud
{
    public partial class FormEditFood : Form
    {
        FoodController foodController = FoodController.GetInstance();
        Food foodToModify = new Food();
        public FormEditFood(Food foodToModify)
        {
            InitializeComponent();
            this.foodToModify = foodToModify;
            FillCheckedListBoxDiets();
            CheckItemsInListBoxDiets();
            txtEnergyValue.Text = foodToModify.EnergyValue.ToString();
            txtFoodName.Text = foodToModify.Name;

        }

        private void FillCheckedListBoxDiets()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IDiet))))
            {
                clbListDiets.Items.Add(Activator.CreateInstance(type));
            }
        }

        private void CheckItemsInListBoxDiets()
        {
            foreach (IDiet diet in foodToModify.Diet)
            {
                int index = clbListDiets.Items.IndexOf(diet);
                if (index >= 0)
                {
                    clbListDiets.SetItemChecked(index, true);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<IDiet> selectedDiets = new List<IDiet>();
            foreach (IDiet diet in clbListDiets.CheckedItems)
            {
                selectedDiets.Add(diet);
            }

            Food foodModified = foodToModify;
            foodModified.Name = txtFoodName.Text;
            foodModified.EnergyValue = Convert.ToInt32(txtEnergyValue.Text);
            foodModified.Diet = selectedDiets;

            foodController.Update(foodToModify, foodModified);

            MessageBox.Show("Actualizado con exito");
            this.Close();
        }
    }
}
