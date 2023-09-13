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
        private FormHome formHome;
        public FormEntityCrud(FormHome formHome)
        {
            InitializeComponent();
            RefreshDataGridEntities();
            this.formHome = formHome;
        }
        private void RefreshDataGridEntities()
        {
            bsEntities.DataSource = entityController.getEntities();
            bsEntities.ResetBindings(false);
            dgvEntities.DataSource = bsEntities;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreateEntity formCreateEntity = new FormCreateEntity();
            formHome.OpenChildForm(formCreateEntity);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvEntities.SelectedRows[0];
            Entity entity = (Entity)selectedRow.DataBoundItem;


            FormEditEntity formEditEntity = new FormEditEntity
                (
                    entity.Id, entity.Kingdom, entity.Name, 
                    entity.Diet, entity.Habitat, entity.AttackPoints, 
                    entity.DefensePoints, entity.AttackRange, entity.MaxLife,
                    entity.MaxEnergy, entity.DefenseShield
                ) ;
            formHome.OpenChildForm(formEditEntity);
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
