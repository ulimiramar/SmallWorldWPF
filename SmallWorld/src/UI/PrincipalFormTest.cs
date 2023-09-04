using SmallWorld.src.Controllers;
using SmallWorld.src.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI
{
    public partial class PrincipalFormTest : Form
    {
        EntityController entityController = EntityController.GetInstance();
        public PrincipalFormTest()
        {
            InitializeComponent();
            cbSelectMyEntity.DataSource = entityController.getEntities();
            cbSelectEntityFromOtherUser.DataSource = entityController.getEntities();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminFormTest adminFormTest = new AdminFormTest();
            adminFormTest.Show();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            ((Entity)cbSelectMyEntity.SelectedItem).Attack((Entity)cbSelectEntityFromOtherUser.SelectedItem);
        }

        private void cbSelectMyEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectMyEntity.SelectedItem is Entity selectedEntity)
            {
                pbCurrentLifeMyEntity.Value = selectedEntity.CurrentLife;
                pbCurrentEnergyMyEntity.Value = selectedEntity.CurrentEnergy;
                pbDefenseShieldMyEntity.Value = selectedEntity.DefenseShield;
            }
        }

        private void cbSelectEntityFromOtherUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectEntityFromOtherUser.SelectedItem is Entity selectedEntity)
            {
                pbCurrentLifeOtherUser.Value = selectedEntity.CurrentLife;
                pbCurrentEnergyOtherUser.Value = selectedEntity.CurrentEnergy;
                pbDefenseShieldOtherUser.Value = selectedEntity.DefenseShield;
            }
        }
    }
}
