using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Interactable.ItemEffects;
using SmallWorld.src.Model.Interactuable;
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
        ItemController itemController = ItemController.GetInstance();
        FoodController foodController = FoodController.GetInstance();
        public PrincipalFormTest()
        {
            InitializeComponent();
            RefreshAllData();
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
            RefreshAllData();
        }

        private void RefreshAllData() 
        {
            RefreshEntitiesComboBoxes();
            RefreshEntityValues();
            RefreshItems();
            RefreshFoods();
        }

        private void RefreshFoods()
        {
            bsFoods.DataSource = foodController.getFoods();
            bsFoods.ResetBindings(false);
            cbFood.DataSource = bsFoods;
        }
        private void RefreshItems()
        {
            bsItems.DataSource = itemController.getItems();
            bsItems.ResetBindings(false);
            cbItems.DataSource = bsItems;
        }
        private void RefreshEntitiesComboBoxes()
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

        private void btnInteract_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCurrentPlayerEntities.SelectedItem is Entity selectedCurrentPlayerEntity) { 
                    if (cbItems.SelectedItem is Item item)
                        item.ExecuteEffectStrategy(selectedCurrentPlayerEntity);
                    if (cbFood.SelectedItem is Food food)
                        //selectedCurrentPlayerEntity.Eat(food);
                        entityController.Eat(selectedCurrentPlayerEntity, food);
                }
                RefreshEntityValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                RefreshEntityValues();
            }

        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFood.SelectedIndex = -1;
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbItems.SelectedIndex = -1;
        }
    }
}
