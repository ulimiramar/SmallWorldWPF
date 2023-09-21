using SmallWorld.src.Controllers;
using SmallWorld.src.Model;
using SmallWorld.src.UI.Admin.EntityCrud;
using SmallWorld.src.UI.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI.Admin
{
    public partial class FormEntityCrud : Form
    {
        EntityController entityController = EntityController.GetInstance();
        public FormEntityCrud()
        {
            InitializeComponent();
            RefreshDataGridEntities();
        }
        private void RefreshDataGridEntities()
        {
            bsEntities.DataSource = entityController.getEntities();
            bsEntities.ResetBindings(false);
            dgvEntities.DataSource = bsEntities;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new FormCreateEntity().ShowDialog();
            RefreshDataGridEntities();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvEntities.SelectedRows[0];
            Entity entity = (Entity)selectedRow.DataBoundItem;

            FormEditEntity formEditEntity = new FormEditEntity(entity);
            formEditEntity.ShowDialog();
            RefreshDataGridEntities();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEntities.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEntities.SelectedRows[0];
                Entity entityToDelete = (Entity)selectedRow.DataBoundItem;

                entityController.Delete(entityToDelete);
                RefreshDataGridEntities();

            }
            else MessageBox.Show("Seleccionar una entidad");
        }
    }
}
