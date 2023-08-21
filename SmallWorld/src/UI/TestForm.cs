using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Dieta;
using SmallWorld.src.Model.Habitat;
using SmallWorld.src.Model.Reino;
using SmallWorld.src.Model.Terreno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI
{
    public partial class TestForm : Form
    {
        private EntityController entityController = EntityController.GetController();
        public TestForm()
        {
            InitializeComponent();

            cbKingdom.Items.Add(new Alien());
            cbKingdom.Items.Add(new Animal());
            cbKingdom.Items.Add(new Machine());
            cbKingdom.Items.Add(new Vegetable());

            cbDiet.Items.Add(new Carnivorous());
            cbDiet.Items.Add(new Herbivorous());
            cbDiet.Items.Add(new Omnivorous());

            cbHabitat.Items.Add(new Aerial());
            cbHabitat.Items.Add(new Aquatic());
            cbHabitat.Items.Add(new Terrestrial());



            /*
             * Código usando reflexión para traer los nombres de las clases que implementan cierta interfaz
             * 
            var KingdomTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(IKingdom).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToList();

            // Agrega los nombres de las clases al ComboBox
            foreach (var tipo in KingdomTypes)
            {
                cbKingdom.Items.Add(tipo.Name);
            }

            var DietTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(IDiet).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToList();

            // Agrega los nombres de las clases al ComboBox
            foreach (var tipo in DietTypes)
            {
                cbDiet.Items.Add(tipo.Name);
            }

            var HabitatTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(IHabitat).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToList();

            // Agrega los nombres de las clases al ComboBox
            foreach (var tipo in HabitatTypes)
            {
                cbHabitat.Items.Add(tipo.Name);
            }

            */


        }

        private void tbAttack_Scroll(object sender, EventArgs e)
        {
            UpdateTrackBarDefense();
            lblAttackPoints.Text = Convert.ToString(tbAttack.Value);
           
        }

        void UpdateTrackBarDefense()
        {
            int AttackPoints = tbAttack.Value;
            int DefensePoints = 100 - AttackPoints;
            tbDefense.Value = DefensePoints;
            lblDefensePoints.Text = Convert.ToString(DefensePoints);

        }



        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
                entityController.AddEntity(new Entity((IKingdom)cbKingdom.SelectedItem, txtName.Text, (IDiet)cbDiet.SelectedItem, (IHabitat)cbHabitat.SelectedItem, tbAttack.Value, tbDefense.Value, 40));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            entityController.ReadEntities();
            //TODO: la línea de abajo no muestra la entidad completa, no muestra el ToString de la clase Entity
            //dgvEntities.AutoGenerateColumns = true;
            dgvEntities.DataSource = entityController.getEntities();
        }
    }
}
