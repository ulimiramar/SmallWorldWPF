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
        private ViewController viewController = ViewController.GetInstance();
        public FormCreateItem()
        {
            InitializeComponent();
            FillListControls();
        }

        private void FillListControls()
        {
            viewController.FillListControlWithImplementations(clbListEffects, typeof(IEffectStrategy));
        }
        private void btnCreate_Click(object sender, EventArgs e)
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
        private void ClearFormControls()
        {
            viewController.ClearCheckedListBox(clbListEffects);
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            txtName.Text = viewController.GetRandomString(4);
            viewController.CheckRandomItemsInClbControl(clbListEffects);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
