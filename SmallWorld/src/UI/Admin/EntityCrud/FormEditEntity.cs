using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.UI.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmallWorld.src.UI.Admin.EntityCrud
{
    public partial class FormEditEntity : Form
    {
        EntityController entityController = EntityController.GetInstance();
        FormController formController = FormController.GetInstance();
        Entity entityToModify = new Entity();
        public FormEditEntity(Entity entityToModify)
        {
            InitializeComponent();
            this.entityToModify = entityToModify;
            FillListControls();
            CheckItemsInClb();
            cbKingdom.SelectedItem = entityToModify.Kingdom;
            txtName.Text = entityToModify.Name;
            cbDiet.SelectedItem = entityToModify.Diet;
            //cbHabitat.SelectedItem = entityToModify.Habitat;
            txtAttackPoints.Text = entityToModify.AttackPoints.ToString();
            txtDefensePoints.Text = entityToModify.DefensePoints.ToString();
            chbAttackRange.Checked = entityToModify.AttackRange;
            txtMaxLife.Text = entityToModify.MaxLife.ToString();
            txtMaxEnergy.Text = entityToModify.MaxEnergy.ToString();
        }

        private void FillListControls()
        {
            formController.FillListControlWithImplementations<IKingdom>(cbKingdom);
            formController.FillListControlWithImplementations<IDiet>(cbDiet);
            formController.FillListControlWithImplementations<IHabitat>(clbListHabitat);

            //formController.FillListControlWithImplementations(cbKingdom, typeof(IKingdom));
            //formController.FillListControlWithImplementations(cbDiet, typeof(IDiet));
            //formController.FillListControlWithImplementations(cbHabitat, typeof(IHabitat));
        }
        private void CheckItemsInClb()
        {
            formController.CheckItemsInClbControl<IHabitat>(clbListHabitat, entityToModify.HabitatList);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<IHabitat> selectedHabitats = new List<IHabitat>();
            foreach (IHabitat habitat in clbListHabitat.CheckedItems)
            {
                selectedHabitats.Add(habitat);
            }

            Entity entityModified = entityToModify;
            
            entityModified.Kingdom = (IKingdom)cbKingdom.SelectedItem;
            entityModified.Name = txtName.Text;
            entityModified.Diet = (IDiet)cbDiet.SelectedItem;
            entityModified.HabitatList = selectedHabitats;
            //entityModified.Habitat = (IHabitat)cbHabitat.SelectedItem;
            entityModified.AttackPoints = Convert.ToInt32(txtAttackPoints.Text);
            entityModified.DefensePoints = Convert.ToInt32(txtDefensePoints.Text);
            entityModified.AttackRange = chbAttackRange.Checked;
            entityModified.MaxLife = Convert.ToInt32(txtMaxLife.Text);
            entityModified.MaxEnergy = Convert.ToInt32(txtMaxEnergy.Text);

            entityController.Update(entityToModify, entityModified);
            MessageBox.Show("Actualizado con exito");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
