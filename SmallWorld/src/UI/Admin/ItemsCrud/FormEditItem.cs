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
    public partial class FormEditItem : Form
    {
        private ItemController itemController = ItemController.GetInstance();
        public FormEditItem(int id, IEffectStrategy effectStrategy)
        {
            InitializeComponent();
            FillComboBoxes();
            lblId.Text = id.ToString();
            cbItemEffect.SelectedItem = effectStrategy;
        }
        private void FillComboBoxes()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IEffectStrategy))))
            {
                cbItemEffect.Items.Add(Activator.CreateInstance(type));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            itemController.Update(Convert.ToInt32(lblId.Text), (IEffectStrategy)cbItemEffect.SelectedItem);
            MessageBox.Show("Actualizado con exito");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
