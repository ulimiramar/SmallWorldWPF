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
            //FillComboBoxes();
            FillCheckedListBoxEffects();
        }

        private void FillCheckedListBoxEffects()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IEffectStrategy))))
            {
                clbListEffects.Items.Add(Activator.CreateInstance(type));
            }
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
                    //EntityController.GetInstance().AddEntity()
                    itemController.AddItem(selectedEffects, txtName.Text);
                    ClearFormControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            txtName.Clear();
            for (int i = 0; i < clbListEffects.Items.Count; i++)
            {
                clbListEffects.SetItemChecked(i, false);
            }
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //int randomDietIndex = random.Next(0, cbItemEffect.Items.Count);
            //cbItemEffect.SelectedIndex = randomDietIndex;



            //lógica para marcar al menos un checkbox aleatorios y luego los demás aleatorios

            int randomIndex = random.Next(0, clbListEffects.Items.Count);
            clbListEffects.SetItemChecked(randomIndex, true);

            for (int i = 0; i < clbListEffects.Items.Count; i++)
            {
                if (i == randomIndex)
                {
                    continue; // Salta el elemento que ya marcamos aleatoriamente
                }
                bool isChecked = random.Next(0, 2) == 1; // Genera 0 o 1 aleatoriamente
                clbListEffects.SetItemChecked(i, isChecked);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
