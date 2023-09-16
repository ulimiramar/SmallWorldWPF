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
        public FormCreateItem()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //EntityController.GetInstance().AddEntity()
                    itemController.AddItem((IEffectStrategy)cbItemEffect.SelectedItem);
                    ClearFormControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void FillComboBoxes()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IEffectStrategy))))
            {
                cbItemEffect.Items.Add(Activator.CreateInstance(type));
            }
        }
        private void ClearFormControls()
        {
            cbItemEffect.SelectedIndex = -1;
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomDietIndex = random.Next(0, cbItemEffect.Items.Count);
            cbItemEffect.SelectedIndex = randomDietIndex;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
