using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
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

namespace SmallWorld.src.UI.Admin.FoodCrud
{
    public partial class FormCreateFood : Form
    {
        private FoodController foodController = FoodController.GetInstance();
        private FormController formController = FormController.GetInstance();
        public FormCreateFood()
        {
            InitializeComponent();
            FillListControls();
        }
        private void FillListControls()
        {
            formController.FillListControlWithImplementations(clbListDiets, typeof(IDiet));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateFood();
        }
        private void ClearFormControls()
        {
            txtEnergyValue.Text = "";
            txtFoodName.Text = "";
            formController.ClearCheckedListBox(clbListDiets);
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            RandomData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateRandoms_Click(object sender, EventArgs e)
        {
            if (txtRandomsNumber.Text != "")
            {
                for (int i = 0; i <= Convert.ToInt32(txtRandomsNumber.Text); i++)
                {
                    RandomData();
                    CreateFood();
                }
                MessageBox.Show("Creados con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese número de aleatorios a crear");
            }
        }
        public void RandomData()
        {
            int i = foodController.getFoods().Count() + 1;
            Random random = new Random();

            txtFoodName.Text = $"{i} comida {formController.GetRandomString(4)}";

            txtEnergyValue.Text = Convert.ToString(random.Next(10, 100));
            formController.CheckRandomItemsInClbControl(clbListDiets);
        }
        public void CreateFood()
        {
            List<IDiet> selectedDiets = new List<IDiet>();

            foreach (IDiet diet in clbListDiets.CheckedItems)
            {
                selectedDiets.Add(diet);
            }
            try
            {
                foodController.AddFood(txtFoodName.Text, selectedDiets, Convert.ToInt32(txtEnergyValue.Text));
                ClearFormControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
