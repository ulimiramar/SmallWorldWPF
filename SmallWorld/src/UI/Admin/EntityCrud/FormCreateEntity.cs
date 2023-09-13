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
        public FormCreateEntity()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //EntityController.GetInstance().AddEntity()
                entityController.AddEntity((IKingdom)cbKingdom.SelectedItem, txtName.Text, (IDiet)cbDiet.SelectedItem, (IHabitat)cbHabitat.SelectedItem, Convert.ToInt32(txtAttackPoints.Text), Convert.ToInt32(txtDefensePoints.Text), chbAttackRange.Checked, Convert.ToInt32(txtMaxLife.Text), Convert.ToInt32(txtMaxEnergy.Text), Convert.ToInt32(txtDefenseShield.Text));
                ClearFormControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillComboBoxes()
        {
            // Llena el ComboBox de Kingdom con las clases que implementan IKingsom
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IKingdom))))
            {
                cbKingdom.Items.Add(Activator.CreateInstance(type));
            }

            // Llena el ComboBox de Diet con las clases que implementan IDiet
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IDiet))))
            {
                cbDiet.Items.Add(Activator.CreateInstance(type));
            }

            // Llena el ComboBox de Habitat con las clases que implementan IHabitat
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IHabitat))))
            {
                cbHabitat.Items.Add(Activator.CreateInstance(type));
            }
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
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            txtName.Text = GetRandomString(8); // Genera una cadena aleatoria de longitud 8

            // Seleccionar un índice aleatorio para Kingdom
            int randomKingdomIndex = random.Next(0, cbKingdom.Items.Count);
            cbKingdom.SelectedIndex = randomKingdomIndex;

            // Seleccionar un índice aleatorio para Habitat
            int randomHabitatIndex = random.Next(0, cbHabitat.Items.Count);
            cbHabitat.SelectedIndex = randomHabitatIndex;

            // Seleccionar un índice aleatorio para Diet
            int randomDietIndex = random.Next(0, cbDiet.Items.Count);
            cbDiet.SelectedIndex = randomDietIndex;

            //txtMaxLife.Text= Convert.ToString(random.Next(10, 100));
            //txtMaxEnergy.Text = Convert.ToString(random.Next(10, 100));
            txtMaxLife.Text = Convert.ToString(100);
            txtMaxEnergy.Text = Convert.ToString(100);


            txtAttackPoints.Text = Convert.ToString(random.Next(10, 100));
            txtDefensePoints.Text = Convert.ToString(random.Next(10, 100));
            txtDefenseShield.Text = Convert.ToString(random.Next(10, 100));
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
