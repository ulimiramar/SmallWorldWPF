using SmallWorld.src.Controllers;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Interactuable;
using SmallWorld.src.UI.Admin.EntityCrud;
using SmallWorld.src.UI.Admin.FoodCrud;
using SmallWorld.src.UI.Admin.ItemsCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI.Admin.ItemCrud
{
    public partial class FormItemsCrudHome : Form
    {
        private ItemController itemController = ItemController.GetInstance();
        public FormItemsCrudHome()
        {
            InitializeComponent();
            RefreshDataGridItems();
        }
        private void RefreshDataGridItems()
        {
            bsItems.DataSource = itemController.getItems();
            bsItems.ResetBindings(false);
            dgvItems.DataSource = bsItems;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new FormCreateItem().ShowDialog();
            RefreshDataGridItems();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvItems.SelectedRows[0];
            Item item = (Item)selectedRow.DataBoundItem;


            //FormEditItem formEditItem = new FormEditItem(item.Id, item.EffectStrategy);
            FormEditItem formEditItem = new FormEditItem(item);
            formEditItem.ShowDialog();
            RefreshDataGridItems();

            

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
