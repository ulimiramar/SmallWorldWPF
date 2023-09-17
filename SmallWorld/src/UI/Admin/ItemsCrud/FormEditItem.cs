using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Interactuable;
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
        private Item itemToModify = new Item();
        private Item itemModified = new Item();
        public FormEditItem(int id, IEffectStrategy effectStrategy)
        {
            InitializeComponent();
            FillComboBoxes();
            lblId.Text = id.ToString();
            cbItemEffect.SelectedItem = effectStrategy;
        }
        public FormEditItem(Item itemToModify)
        {
            InitializeComponent();
            this.itemToModify = itemToModify;
            itemModified = itemToModify;
            //FillComboBoxes();
            FillCheckedListBoxEffects();
            CheckItemsInListBoxEffects();
            txtName.Text = itemToModify.Name;

            //cbItemEffect.SelectedItem = itemToModify.EffectStrategy;
        }
        private void FillComboBoxes()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IEffectStrategy))))
            {
                cbItemEffect.Items.Add(Activator.CreateInstance(type));
            }
        }
        private void FillCheckedListBoxEffects()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IEffectStrategy))))
            {
                clbListEffects.Items.Add(Activator.CreateInstance(type));
            }
        }

        //TODO: arreglar esto y que en la vista del juego no muestra los nombres
        private void CheckItemsInListBoxEffects()
        {
            foreach (IEffectStrategy effect in itemToModify.EffectStrategies)
            {
                int index = clbListEffects.Items.IndexOf(effect);
                if (index >= 0)
                {
                    clbListEffects.SetItemChecked(index, true);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //itemController.Update(Convert.ToInt32(lblId.Text), (IEffectStrategy)cbItemEffect.SelectedItem);
            List<IEffectStrategy> selectedEffects = new List<IEffectStrategy>();
            foreach (IEffectStrategy effect in clbListEffects.CheckedItems)
            {
                selectedEffects.Add(effect);
            }

            itemModified.EffectStrategies = selectedEffects;
            itemModified.Name = txtName.Text;

            itemController.Update(itemToModify, itemModified);
            
            MessageBox.Show("Actualizado con exito");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
