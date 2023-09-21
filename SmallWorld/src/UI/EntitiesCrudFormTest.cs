using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Dieta;
using SmallWorld.src.Model.Habitat;
using SmallWorld.src.Model.Reino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmallWorld.src.UI
{
    public partial class EntitiesCrudFormTest : Form
    {
        EntityController entityController = EntityController.GetInstance();
        public EntitiesCrudFormTest()
        {
            InitializeComponent();

            //FillComboBoxKingdoms();
            FillComboBoxes();
            RefreshDataGridEntities();

            /*cbKingdom.Items.Add(new Alien());
            cbKingdom.Items.Add(new Animal());
            cbKingdom.Items.Add(new Machine());
            cbKingdom.Items.Add(new Vegetable());



            cbDiet.Items.Add(new Carnivorous());
            cbDiet.Items.Add(new Herbivorous());
            cbDiet.Items.Add(new Omnivorous());

            cbHabitat.Items.Add(new Aerial());
            cbHabitat.Items.Add(new Aquatic());
            cbHabitat.Items.Add(new Terrestrial());*/
        }

        /*Para llenar combobox automáticamente, me falta hacer que traiga el new clase()
        private void FillComboBoxKingdoms()
        {
            var interfaceType = typeof(IKingdom);

            var classList = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => interfaceType.IsAssignableFrom(type) && !type.IsInterface)
                //.Select(type => type.Name)
                .ToList();

            cbKingdom.DataSource = classList;
        }*/


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

        private void btnDeleteEntity_Click(object sender, EventArgs e)
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

        private void btnCreateEntity_Click_1(object sender, EventArgs e)
        {
            try
            {
                //EntityController.GetInstance().AddEntity()
                entityController.AddEntity((IKingdom)cbKingdom.SelectedItem, txtName.Text, (IDiet)cbDiet.SelectedItem, (IHabitat)cbHabitat.SelectedItem, Convert.ToInt32(txtAttackPoints.Text), Convert.ToInt32(txtDefensePoints.Text), chbAttackRange.Checked, Convert.ToInt32(txtMaxLife.Text), Convert.ToInt32(txtMaxEnergy.Text), Convert.ToInt32(txtDefenseShield.Text));             
                RefreshDataGridEntities();
                ClearFormControls();
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// Save in binding-source the list of entities,
        /// then it is established that columns will not be modified, only data.
        /// Then the binding-source is asigned to data-source of the data-grid to update it.
        /// In resume this method update the datagrid data.
        /// </summary>
        private void RefreshDataGridEntities()
        {
            dgvEntitiesBs.DataSource = entityController.getEntities();
            dgvEntitiesBs.ResetBindings(false);
            dgvEntities.DataSource = dgvEntitiesBs;
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            txtName.Text = GetRandomString(8); // Genera una cadena aleatoria de longitud 8
                                              
            // Seleccionar un índice aleatorio para Kingdom
            int randomKingdomIndex = random.Next(0, cbKingdom.Items.Count);
            cbKingdom.SelectedIndex = randomKingdomIndex;

            // Seleccionar un índice aleatorio para Habitat
            int randomHabitatIndex = random.Next(0, cbHabitat.Items.Count);
            cbHabitat.SelectedIndex = randomHabitatIndex;

            // Seleccionar un índice aleatorio para Diet
            int randomDietIndex = random.Next(0, cbDiet.Items.Count);
            cbDiet.SelectedIndex = randomDietIndex;

            //txtMaxLife.Text= Convert.ToString(random.Next(10, 100));
            //txtMaxEnergy.Text = Convert.ToString(random.Next(10, 100));
            txtMaxLife.Text = Convert.ToString(100);
            txtMaxEnergy.Text = Convert.ToString(100);


            txtAttackPoints.Text = Convert.ToString(random.Next(10, 100));
            txtDefensePoints.Text = Convert.ToString(random.Next(10, 100));
            txtDefenseShield.Text = Convert.ToString(random.Next(10, 100));
        }

        private string GetRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        
        private bool UpdateMode = false; // Variable para controlar si estamos en modo actualizar o modificar

        //TODO: cuando se vuelve a abrir el formulario después de atacar, al presionar el botón modificar, no se traen los datos a los comboboxes, talves hay que agregar el (IDiet)adelante, no, talvez no porque ya lo probé. no se porqué.
        private void btnUpdateEntity_Click(object sender, EventArgs e)
        {
            if (!UpdateMode)
            {
                // Modo "Modificar" a "Actualizar"
                UpdateMode = true;
                btnUpdateEntity.Text = "Actualizar";
                btnCreateEntity.Enabled = false;
                btnCancelUpdate.Visible = true;
                btnDeleteEntity.Enabled = false;
                dgvEntities.Enabled = false;

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvEntities.SelectedRows[0];

                // Obtener la entidad seleccionada
                Entity entityToUpdate = (Entity)selectedRow.DataBoundItem;

                // Mostrar los datos en los controles del formulario
                txtName.Text = entityToUpdate.Name;
                cbKingdom.SelectedItem = entityToUpdate.Kingdom;
                cbDiet.SelectedItem = entityToUpdate.Diet;
                cbHabitat.SelectedItem = entityToUpdate.HabitatList;
                txtMaxEnergy.Text = entityToUpdate.MaxEnergy.ToString();
                txtMaxLife.Text = entityToUpdate.MaxLife.ToString();
                txtAttackPoints.Text = entityToUpdate.AttackPoints.ToString();
                txtDefensePoints.Text = entityToUpdate.DefensePoints.ToString();
                chbAttackRange.Checked = entityToUpdate.AttackRange;
                txtDefenseShield.Text = entityToUpdate.DefenseShield.ToString();
                lblId.Text = entityToUpdate.Id.ToString();
            }
            else
            {
                // Modo "Actualizar" a "Modificar"
                UpdateMode = false;
                btnUpdateEntity.Text = "Modificar";
                btnCreateEntity.Enabled = true;
                btnDeleteEntity.Enabled = true;
                btnCancelUpdate.Visible = false;
                dgvEntities.Enabled = true;

                entityController.Update(Convert.ToInt32(lblId.Text),(IKingdom)cbKingdom.SelectedItem, txtName.Text, (IDiet)cbDiet.SelectedItem, (IHabitat)cbHabitat.SelectedItem, Convert.ToInt32(txtAttackPoints.Text), Convert.ToInt32(txtDefensePoints.Text), chbAttackRange.Checked, Convert.ToInt32(txtMaxLife.Text), Convert.ToInt32(txtMaxEnergy.Text), Convert.ToInt32(txtDefenseShield.Text));
                RefreshDataGridEntities();
                ClearFormControls();

                
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            UpdateMode = false;
            btnUpdateEntity.Text = "Modificar";
            btnCancelUpdate.Visible = false;
            btnCreateEntity.Enabled = true;
            btnDeleteEntity.Enabled = true;
            dgvEntities.Enabled = true;
            ClearFormControls();
        }

        private void ClearFormControls()
        {
            txtName.Clear();
            txtAttackPoints.Clear();
            txtDefensePoints.Clear();
            txtDefenseShield.Clear();
            txtMaxEnergy.Clear();
            txtMaxLife.Clear();
            cbDiet.SelectedIndex = -1;
            cbHabitat.SelectedIndex = -1;
            cbKingdom.SelectedIndex = -1;
        }
    }
}
