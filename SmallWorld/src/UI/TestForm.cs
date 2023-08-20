using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
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
        public TestForm()
        {
            InitializeComponent();

            /*List<IKingdom> Kingdoms = new List<IKingdom>()
            {
                new Alien(),
                new Animal(),
                new Machine(),
                new Vegetable()
            };

            foreach (var Kingdom in Kingdoms)
            {
                cbKingdom.Items.Add(Kingdom);
            }*/

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

            /*List<IHabitat> Habitats = new List<IHabitat>()
            {
                new Aerial(),
                new Aquatic(),
                new Terrestrial()
            };
            foreach (var Habitat in Habitats)
            {
                cbHabitat.Items.Add(Habitat.getHabitatName());
            }*/

            var HabitatTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(IHabitat).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToList();

            // Agrega los nombres de las clases al ComboBox
            foreach (var tipo in HabitatTypes)
            {
                cbHabitat.Items.Add(tipo.Name);
            }


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
            if (cbKingdom.SelectedItem is IKingdom SelectedKingdom &&
                cbDiet.SelectedItem is IDiet SelectedDiet &&
                cbHabitat.SelectedItem is IHabitat SelectedHabitat)
            {
                EntityController.CreateEntity(SelectedKingdom, txtName.Text, SelectedDiet, SelectedHabitat, tbAttack.Value, tbDefense.Value, 40);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityController.ReadEntities();
        }

        // TODO: Arreglar error de que no se crean las entidades hay un conflicto entre que le paso una interfaz a la controladora pero el combobox tiene clases

    }
}
