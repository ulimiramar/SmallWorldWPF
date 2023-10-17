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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmallWorld.src.UI.Admin.EntityCrud
{
    public partial class FormCreateEntity : Form
    {
        EntityController entityController = EntityController.GetInstance();
        FormController formController = FormController.GetInstance();
        public FormCreateEntity()
        {
            InitializeComponent();
            FillListControls();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateEntity();
        }

        private void FillListControls()
        {
            formController.FillListControlWithImplementations<IKingdom>(cbKingdom);
            formController.FillListControlWithImplementations<IDiet>(cbDiet);
            formController.FillListControlWithImplementations<IHabitat>(clbListHabitat);


            //formController.FillListControlWithImplementations(cbKingdom, typeof(IKingdom));
            //formController.FillListControlWithImplementations(cbDiet, typeof(IDiet));
            //formController.FillListControlWithImplementations(cbHabitat, typeof(IHabitat));
            //formController.FillListControlWithImplementations(clbListHabitat, typeof(IHabitat));
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
            cbKingdom.SelectedIndex = -1;
            formController.ClearCheckedListBox(clbListHabitat);
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            RandomData();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCreateRandoms_Click(object sender, EventArgs e)
        {
            
            if (txtRandomsNumber.Text != "")
            {
                try
                {
                    int totalEntitiesToCreate = Convert.ToInt32(txtRandomsNumber.Text);
                    await entityController.AddRandomsEntitiesAsync(totalEntitiesToCreate, 50);
                    MessageBox.Show("Creados con éxito");
                    this.Close();
                    /*for (int i = 0; i <= Convert.ToInt32(txtRandomsNumber.Text); i++)
                    {
                        RandomData();
                        CreateEntity();
                    }*/
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese número de aleatorios a crear");
            }
        }


        public void RandomData()
        {
            int i = entityController.getEntities().Count() + 1;
            Random random = new Random();

            txtName.Text = $"{i} entidad {formController.GetRandomString(4)}";

            formController.SelectRandomItemInComboBox(cbKingdom);
            formController.SelectRandomItemInComboBox(cbDiet);

            txtMaxLife.Text = Convert.ToString(100);
            txtMaxEnergy.Text = Convert.ToString(100);
            txtAttackPoints.Text = Convert.ToString(random.Next(10, 100));
            txtDefensePoints.Text = Convert.ToString(random.Next(10, 100));
            txtDefenseShield.Text = Convert.ToString(random.Next(10, 100));

            formController.CheckRandomItemsInClbControl(clbListHabitat);
        }
        public void CreateEntity()
        {
            List<IHabitat> selectedHabitats = new List<IHabitat>();
            foreach (IHabitat habitat in clbListHabitat.CheckedItems)
            {
                selectedHabitats.Add(habitat);
            }
            try
            {
                entityController.AddEntity((IKingdom)cbKingdom.SelectedItem, txtName.Text, 
                    (IDiet)cbDiet.SelectedItem, selectedHabitats, Convert.ToInt32(txtAttackPoints.Text), 
                    Convert.ToInt32(txtDefensePoints.Text), chbAttackRange.Checked, 
                    Convert.ToInt32(txtMaxLife.Text), Convert.ToInt32(txtMaxEnergy.Text));
                ClearFormControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
