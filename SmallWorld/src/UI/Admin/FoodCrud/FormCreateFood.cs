using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
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
        public FormCreateFood()
        {
            InitializeComponent();
            FillCheckedListBoxDiets();
        }

        private void FillCheckedListBoxDiets()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IDiet))))
            {
                clbListDiets.Items.Add(Activator.CreateInstance(type));
            }
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
            for (int i = 0; i < clbListDiets.Items.Count; i++)
            {
                clbListDiets.SetItemChecked(i, false);
            }
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            txtEnergyValue.Text = Convert.ToString(random.Next(10, 100));
            txtFoodName.Text = GetRandomString(8);



            //lógica para marcar al menos un checkbox aleatorios y luego los demás aleatorios

            int randomIndex = random.Next(0, clbListDiets.Items.Count);
            clbListDiets.SetItemChecked(randomIndex, true);

            for (int i = 0; i < clbListDiets.Items.Count; i++)
            {
                if (i == randomIndex)
                {
                    continue; // Salta el elemento que ya marcamos aleatoriamente
                }
                bool isChecked = random.Next(0, 2) == 1; // Genera 0 o 1 aleatoriamente
                clbListDiets.SetItemChecked(i, isChecked);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
