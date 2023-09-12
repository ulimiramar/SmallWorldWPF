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
using System.Xml.Linq;

namespace SmallWorld.src.UI
{
    public partial class ItemsCrudFormTest : Form
    {
        ItemController itemController = ItemController.GetInstance();
        public ItemsCrudFormTest()
        {
            InitializeComponent();
            FillComboBoxes();
            RefreshDataGridItems();
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
                .Where(t => t.GetInterfaces().Contains(typeof(IEffectStrategy))))
            {
                cbItemEffect.Items.Add(Activator.CreateInstance(type));
            }
        }

        private void RefreshDataGridItems()
        {
            bsItems.DataSource = itemController.getItems();
            bsItems.ResetBindings(false);
            dgvItems.DataSource = bsItems;
        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            try
            {
                //EntityController.GetInstance().AddEntity()
                itemController.AddItem((IEffectStrategy)cbItemEffect.SelectedItem);
                RefreshDataGridItems();
                ClearFormControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearFormControls()
        {
            cbItemEffect.SelectedIndex = -1;
            cbKingdom.SelectedIndex = -1;
        }

        private bool UpdateMode = false;
        private void btnModifyUpdate_Click(object sender, EventArgs e)
        {
            if (!UpdateMode)
            {
                // Modo "Modificar" a "Actualizar"
                UpdateMode = true;
                btnModifyUpdate.Text = "Actualizar";
                btnCreateItem.Enabled = false;
                btnCancelUpdate.Visible = true;
                btnDelete.Enabled = false;
                dgvItems.Enabled = false;

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvItems.SelectedRows[0];

                // Obtener la entidad seleccionada
                Item itemToUpdate = (Item)selectedRow.DataBoundItem;

                // Mostrar los datos en los controles del formulario
                cbItemEffect.SelectedItem = itemToUpdate.EffectStrategy;
                lblId.Text = itemToUpdate.Id.ToString();

            }
            else
            {
                // Modo "Actualizar" a "Modificar"
                UpdateMode = false;
                btnModifyUpdate.Text = "Modificar";
                btnCreateItem.Enabled = true;
                btnDelete.Enabled = true;
                btnCancelUpdate.Visible = false;
                dgvItems.Enabled = true;

                itemController.Update(Convert.ToInt32(lblId.Text), (IEffectStrategy)cbItemEffect.SelectedItem);
                RefreshDataGridItems();
                ClearFormControls();
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            UpdateMode = false;
            btnModifyUpdate.Text = "Modificar";
            btnCancelUpdate.Visible = false;
            btnCreateItem.Enabled = true;
            btnDelete.Enabled = true;
            dgvItems.Enabled = true;
            ClearFormControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvItems.SelectedRows[0];
                Item itemToDelete = (Item)selectedRow.DataBoundItem;

                itemController.Delete(itemToDelete);
                RefreshDataGridItems();

            }
            else MessageBox.Show("Seleccionar un item");
        }
    }
}