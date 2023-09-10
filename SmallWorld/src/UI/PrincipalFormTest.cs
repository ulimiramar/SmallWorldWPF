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
            try 
            { 
                ((Entity)cbCurrentPlayerEntities.SelectedItem).Attack((Entity)cbWaitingPlayersEntities.SelectedItem);
                RefreshEntityValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                RefreshEntityValues();
            }
        }

        private void cbSelectMyEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEntityValues();
        }

        private void cbSelectEntityFromOtherUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEntityValues();
        }

        //TODO: Talves sería bueno unir esto al updateEntities, o al revés. pero que quede el refresqueo en una sola función
        private void RefreshEntityValues()
        {
            if (cbCurrentPlayerEntities.SelectedItem is Entity selectedCurrentPlayerEntity)
            {
                pbCurrentLifeCurrentPlayerEntity.Value = selectedCurrentPlayerEntity.CurrentLife;
                pbCurrentEnergyCurrentPlayerEntity.Value = selectedCurrentPlayerEntity.CurrentEnergy;
                pbDefensePointsCurrentPlayerEntity.Value = selectedCurrentPlayerEntity.DefensePoints;
                pbAttackPointsCurrentPlayerEntity.Value = selectedCurrentPlayerEntity.AttackPoints;

                lblCurrentLifeCurrentPlayerEntity.Text = Convert.ToString(selectedCurrentPlayerEntity.CurrentLife);
                lblCurrentEnergyCurrentPlayerEntity.Text = Convert.ToString(selectedCurrentPlayerEntity.CurrentEnergy);
                lblDefensePointsCurrentPlayerEntity.Text = Convert.ToString(selectedCurrentPlayerEntity.DefensePoints);
                lblAttackPointsCurrentPlayerEntity.Text = Convert.ToString(selectedCurrentPlayerEntity.AttackPoints);

                CurrentPlayerEntityIsDied(selectedCurrentPlayerEntity);
            }

            if (cbWaitingPlayersEntities.SelectedItem is Entity selectedWaitingPlayerEntity)
            {
                pbCurrentLifeWaitingPlayerEntity.Value = selectedWaitingPlayerEntity.CurrentLife;
                pbCurrentEnergyWaitingPlayerEntity.Value = selectedWaitingPlayerEntity.CurrentEnergy;
                pbDefensePointsWaitingPlayerEntity.Value = selectedWaitingPlayerEntity.DefensePoints;
                pbAttackPointsWaitingPlayerEntity.Value = selectedWaitingPlayerEntity.AttackPoints;

                lblCurrentLifeWaitingPlayerEntity.Text = Convert.ToString(selectedWaitingPlayerEntity.CurrentLife);
                lblCurrentEnergyWaitingPlayerEntity.Text = Convert.ToString(selectedWaitingPlayerEntity.CurrentEnergy);
                lblDefensePointsWaitingPlayerEntity.Text = Convert.ToString(selectedWaitingPlayerEntity.DefensePoints);
                lblAttackPointsWaitingPlayerEntity.Text = Convert.ToString(selectedWaitingPlayerEntity.AttackPoints);

                WaitingPlayerEntityIsDead(selectedWaitingPlayerEntity);
            }
            
            
        }
        
        
        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            UpdateEntities();
            RefreshEntityValues();
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

        //TODO: problema con el botón ataque, cuando el witingPlayer esta en una entidad muerta y cambia a una entidad viva, pero el currentPlayer cambia a una entidad muerta, el botón atacar sigue enabled.
        private void CurrentPlayerEntityIsDied(Entity selectedCurrentPlayerEntity)
        {
            
                if (selectedCurrentPlayerEntity.DieStatus)
                {
                    btnAttack.Enabled = false;
                    btnInteract.Enabled = false;
                    btnRest.Enabled = false;
                    lblCurrentLifeCurrentPlayerEntity.ForeColor = Color.Red;
                    lblCurrentLifeCurrentPlayerEntity.Text = "Muerto";
                    
                }
                else
                {
                    // Si la entidad está viva, restablece los controles
                    btnAttack.Enabled = true;
                    
                    btnInteract.Enabled = true;
                    btnRest.Enabled = true;
                    lblCurrentLifeCurrentPlayerEntity.ForeColor = Color.Black;
                    lblCurrentLifeCurrentPlayerEntity.Text = selectedCurrentPlayerEntity.CurrentLife.ToString(); // Actualiza el valor de la vida
                    
                }
            
        }

        private void WaitingPlayerEntityIsDead(Entity selectedWaitingPlayerEntity)
        {
            
                if (selectedWaitingPlayerEntity.DieStatus)
                {
                    //TODO: acá se podría pensar en habilitar un botón "comer" para comerse esa entidad muerta.
                    btnAttack.Enabled = false;
                    lblCurrentLifeWaitingPlayerEntity.ForeColor = Color.Red;
                    lblCurrentLifeWaitingPlayerEntity.Text = "Muerto";
                    
                }
                else
                {
                    // Si la entidad está viva, restablece los controles

                    lblCurrentLifeWaitingPlayerEntity.ForeColor = Color.Black;
                    lblCurrentLifeWaitingPlayerEntity.Text = selectedWaitingPlayerEntity.CurrentLife.ToString(); // Actualiza el valor de la vida
                    
                }
            
           
        }

        
        
    }
}
