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
        }

       

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminFormTest adminFormTest = new AdminFormTest();
            adminFormTest.Show();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            ((Entity)cbCurrentPlayerEntities.SelectedItem).Attack((Entity)cbWaitingPlayersEntities.SelectedItem);
            RefreshEntityValues();
        }

        private void cbSelectMyEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEntityValues();
        }

        private void cbSelectEntityFromOtherUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEntityValues();
        }

        
        private void RefreshEntityValues()
        {
            if (cbCurrentPlayerEntities.SelectedItem is Entity selectedCurrentPlayerEntity)
            {
                pbCurrentLifeCurrentPlayerEntity.Value = selectedCurrentPlayerEntity.CurrentLife;
                pbCurrentEnergyCurrentPlayerEntity.Value = selectedCurrentPlayerEntity.CurrentEnergy;
                pbDefenseShieldCurrentPlayerEntity.Value = selectedCurrentPlayerEntity.DefenseShield;
            }

            if (cbWaitingPlayersEntities.SelectedItem is Entity selectedWitingPlayerEntity)
            {
                pbCurrentLifeWaitingPlayerEntity.Value = selectedWitingPlayerEntity.CurrentLife;
                pbCurrentEnergyWaitingPlayerEntity.Value = selectedWitingPlayerEntity.CurrentEnergy;
                pbDefenseShieldWaitingPlayerEntity.Value = selectedWitingPlayerEntity.DefenseShield;
            }
        }
        

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            UpdateEntities();
        }

        private void UpdateEntities()
        {
            bsCurrentPlayerEntities.DataSource = entityController.getEntities();
            bsWaitingPlayersEntities.DataSource = entityController.getEntities();
            bsCurrentPlayerEntities.ResetBindings(false);
            bsWaitingPlayersEntities.ResetBindings(false);
            cbCurrentPlayerEntities.DataSource = bsCurrentPlayerEntities;
            cbWaitingPlayersEntities.DataSource = bsWaitingPlayersEntities;
        }

        private void PrincipalFormTest_Load(object sender, EventArgs e)
        {
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            ((Entity)cbCurrentPlayerEntities.SelectedItem).Rest();
            RefreshEntityValues();
        }

        private void UpdateProgressEntitiesBars()
        {

        }
    }
}
