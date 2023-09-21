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
        private ViewController viewController = ViewController.GetInstance();
        public FormCreateFood()
        {
            InitializeComponent();
            FillListControls();
        }
        private void FillListControls()
        {
            viewController.FillListControlWithImplementations(clbListDiets, typeof(IDiet));
        }

        private void btnCreate_Click(object sender, EventArgs e)
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
        private void ClearFormControls()
        {
            txtEnergyValue.Text = "";
            txtFoodName.Text = "";
            viewController.ClearCheckedListBox(clbListDiets);
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            txtEnergyValue.Text = Convert.ToString(random.Next(10, 100));
            txtFoodName.Text = viewController.GetRandomString(8);
            viewController.CheckRandomItemsInClbControl(clbListDiets);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
