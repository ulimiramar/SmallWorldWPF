using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI.Admin.EntityCrud
{
    public partial class FormEditEntity : Form
    {
        EntityController entityController = EntityController.GetInstance();
        public FormEditEntity(int id, IKingdom kingdom, string name, IDiet diet, IHabitat habitat, int atkPoints, int defPoints, bool rangeAttack, int maxLife, int maxEnergy, int defenseShield)
        {
            InitializeComponent();
            lblId.Text = id.ToString();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            entityController.Update(Convert.ToInt32(lblId.Text), (IKingdom)cbKingdom.SelectedItem, txtName.Text, (IDiet)cbDiet.SelectedItem, (IHabitat)cbHabitat.SelectedItem, Convert.ToInt32(txtAttackPoints.Text), Convert.ToInt32(txtDefensePoints.Text), chbAttackRange.Checked, Convert.ToInt32(txtMaxLife.Text), Convert.ToInt32(txtMaxEnergy.Text), Convert.ToInt32(txtDefenseShield.Text));
        }
    }
}
