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

namespace SmallWorld.src.UI.Admin.EntityCrud
{
    public partial class FormCreateEntity : Form
    {
        EntityController entityController = EntityController.GetInstance();
        ViewController viewController = ViewController.GetInstance();
        public FormCreateEntity()
        {
            InitializeComponent();
            FillListControls();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                entityController.AddEntity((IKingdom)cbKingdom.SelectedItem, txtName.Text, (IDiet)cbDiet.SelectedItem, (IHabitat)cbHabitat.SelectedItem, Convert.ToInt32(txtAttackPoints.Text), Convert.ToInt32(txtDefensePoints.Text), chbAttackRange.Checked, Convert.ToInt32(txtMaxLife.Text), Convert.ToInt32(txtMaxEnergy.Text), Convert.ToInt32(txtDefenseShield.Text));
                ClearFormControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillListControls()
        {
            viewController.FillListControlWithImplementations(cbKingdom, typeof(IKingdom));
            viewController.FillListControlWithImplementations(cbDiet, typeof(IDiet));
            viewController.FillListControlWithImplementations(cbHabitat, typeof(IHabitat));
            viewController.FillListControlWithImplementations(clbListHabitat, typeof(IHabitat));
        }

        private void ClearFormControls()
        {
            txtName.Clear();
            txtAttackPoints.Clear();
            txtDefensePoints.Clear();
            txtDefenseShield.Clear();
            txtMaxEnergy.Clear();
            txtMaxLife.Clear();
            cbDiet.SelectedIndex = -1;
            cbHabitat.SelectedIndex = -1;
            cbKingdom.SelectedIndex = -1;
            viewController.ClearCheckedListBox(clbListHabitat);
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            txtName.Text = viewController.GetRandomString(8);

            viewController.SelectRandomItemInComboBox(cbKingdom);
            viewController.SelectRandomItemInComboBox(cbHabitat);
            viewController.SelectRandomItemInComboBox(cbDiet);

            txtMaxLife.Text = Convert.ToString(100);
            txtMaxEnergy.Text = Convert.ToString(100);
            txtAttackPoints.Text = Convert.ToString(random.Next(10, 100));
            txtDefensePoints.Text = Convert.ToString(random.Next(10, 100));
            txtDefenseShield.Text = Convert.ToString(random.Next(10, 100));

            viewController.CheckRandomItemsInClbControl(clbListHabitat);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
