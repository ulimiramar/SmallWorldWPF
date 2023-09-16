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
        Entity entityToModify = new Entity();
        public FormEditEntity(int id, IKingdom kingdom, string name, IDiet diet, IHabitat habitat, int atkPoints, int defPoints, bool rangeAttack, int maxLife, int maxEnergy, int defenseShield)
        {
            InitializeComponent();
            FillComboBoxes();
            //lblId.Text = id.ToString();
            cbKingdom.SelectedItem = kingdom;
            txtName.Text = name;
            cbDiet.SelectedItem = diet;
            cbHabitat.SelectedItem = habitat;
            txtAttackPoints.Text = atkPoints.ToString();
            txtDefensePoints.Text = defPoints.ToString();
            chbAttackRange.Checked = rangeAttack;
            txtMaxLife.Text = maxLife.ToString();
            txtMaxEnergy.Text = maxEnergy.ToString();
            txtDefenseShield.Text = defenseShield.ToString();
        }
        public FormEditEntity(Entity entityToModify)
        {
            InitializeComponent();
            FillComboBoxes();
            this.entityToModify = entityToModify;
            cbKingdom.SelectedItem = entityToModify.Kingdom;
            txtName.Text = entityToModify.Name;
            cbDiet.SelectedItem = entityToModify.Diet;
            cbHabitat.SelectedItem = entityToModify.Habitat;
            txtAttackPoints.Text = entityToModify.AttackPoints.ToString();
            txtDefensePoints.Text = entityToModify.DefensePoints.ToString();
            chbAttackRange.Checked = entityToModify.AttackRange;
            txtMaxLife.Text = entityToModify.MaxLife.ToString();
            txtMaxEnergy.Text = entityToModify.MaxEnergy.ToString();
            txtDefenseShield.Text = entityToModify.DefenseShield.ToString();
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            Entity entityModified = entityToModify;
            
            entityModified.Kingdom = (IKingdom)cbKingdom.SelectedItem;
            entityModified.Name = txtName.Text;
            entityModified.Diet = (IDiet)cbDiet.SelectedItem;
            entityModified.Habitat = (IHabitat)cbHabitat.SelectedItem;
            entityModified.AttackPoints = Convert.ToInt32(txtAttackPoints.Text);
            entityModified.DefensePoints = Convert.ToInt32(txtDefensePoints.Text);
            entityModified.AttackRange = chbAttackRange.Checked;
            entityModified.MaxLife = Convert.ToInt32(txtMaxLife.Text);
            entityModified.MaxEnergy = Convert.ToInt32(txtMaxEnergy.Text);
            entityModified.DefenseShield = Convert.ToInt32(txtDefenseShield.Text);

            entityController.Update(entityToModify, entityModified);


            //entityController.Update(Convert.ToInt32(lblId.Text), (IKingdom)cbKingdom.SelectedItem, txtName.Text, (IDiet)cbDiet.SelectedItem, (IHabitat)cbHabitat.SelectedItem, Convert.ToInt32(txtAttackPoints.Text), Convert.ToInt32(txtDefensePoints.Text), chbAttackRange.Checked, Convert.ToInt32(txtMaxLife.Text), Convert.ToInt32(txtMaxEnergy.Text), Convert.ToInt32(txtDefenseShield.Text));
            MessageBox.Show("Actualizado con exito");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
