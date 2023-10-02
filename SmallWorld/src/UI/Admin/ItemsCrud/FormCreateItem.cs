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

namespace SmallWorld.src.UI.Admin.ItemsCrud
{
    public partial class FormCreateItem : Form
    {
        private ItemController itemController = ItemController.GetInstance();
        private FormController formController = FormController.GetInstance();
        public FormCreateItem()
        {
            InitializeComponent();
            FillListControls();
        }

        private void FillListControls()
        {
            formController.FillListControlWithImplementations<IEffectStrategy>(clbListEffects);
            //formController.FillListControlWithImplementations(clbListEffects, typeof(IEffectStrategy));
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateItem();
        }
        private void ClearFormControls()
        {
            txtName.Clear();
            formController.ClearCheckedListBox(clbListEffects);
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
                    CreateItem();
                }
                MessageBox.Show("Creados con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese número de aleatorios a crear");
            }
        }
        private void RandomData()
        {
            int i = itemController.getItems().Count() + 1;

            txtName.Text = $"{i} item {formController.GetRandomString(4)}";
            formController.CheckRandomItemsInClbControl(clbListEffects);
        }
        private void CreateItem()
        {
            List<IEffectStrategy> selectedEffects = new List<IEffectStrategy>();

            foreach (IEffectStrategy diet in clbListEffects.CheckedItems)
            {
                selectedEffects.Add(diet);
            }
            try
            {
                itemController.AddItem(selectedEffects, txtName.Text);
                ClearFormControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
