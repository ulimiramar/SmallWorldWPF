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
        ViewController viewController = ViewController.GetInstance();
        Entity entityToModify = new Entity();
        public FormEditEntity(Entity entityToModify)
        {
            InitializeComponent();
            FillListControls();
            this.entityToModify = entityToModify;
            cbKingdom.SelectedItem = entityToModify.Kingdom;
            txtName.Text = entityToModify.Name;
            cbDiet.SelectedItem = entityToModify.Diet;
            cbHabitat.SelectedItem = entityToModify.HabitatList;
            txtAttackPoints.Text = entityToModify.AttackPoints.ToString();
            txtDefensePoints.Text = entityToModify.DefensePoints.ToString();
            chbAttackRange.Checked = entityToModify.AttackRange;
            txtMaxLife.Text = entityToModify.MaxLife.ToString();
            txtMaxEnergy.Text = entityToModify.MaxEnergy.ToString();
            txtDefenseShield.Text = entityToModify.DefenseShield.ToString();
        }

        private void FillListControls()
        {
            viewController.FillListControlWithImplementations(cbKingdom, typeof(IKingdom));
            viewController.FillListControlWithImplementations(cbDiet, typeof(IDiet));
            viewController.FillListControlWithImplementations(cbHabitat, typeof(IHabitat));
            //viewController.FillListControlWithImplementations(c, typeof(IKingdom));
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            Entity entityModified = entityToModify;
            
            entityModified.Kingdom = (IKingdom)cbKingdom.SelectedItem;
            entityModified.Name = txtName.Text;
            entityModified.Diet = (IDiet)cbDiet.SelectedItem;
            entityModified.HabitatList = (IHabitat)cbHabitat.SelectedItem;
            entityModified.AttackPoints = Convert.ToInt32(txtAttackPoints.Text);
            entityModified.DefensePoints = Convert.ToInt32(txtDefensePoints.Text);
            entityModified.AttackRange = chbAttackRange.Checked;
            entityModified.MaxLife = Convert.ToInt32(txtMaxLife.Text);
            entityModified.MaxEnergy = Convert.ToInt32(txtMaxEnergy.Text);
            entityModified.DefenseShield = Convert.ToInt32(txtDefenseShield.Text);

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
