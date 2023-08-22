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
        private MapController mapController = MapController.GetController();
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
            lblDefensePoints.Text = Convert.ToString(tbDefense.Value);

        }



        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            entityController.AddEntity(new Entity((IKingdom)cbKingdom.SelectedItem, txtName.Text, (IDiet)cbDiet.SelectedItem, (IHabitat)cbHabitat.SelectedItem, tbAttack.Value, tbDefense.Value, 1));
            Console.WriteLine($"ataque:{tbAttack.Value} defensa:{tbDefense.Value}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            entityController.ReadEntities();
            dgvEntities.DataSource = entityController.getEntities();
            cbSelectAttackEntity.DataSource = entityController.getEntitiesCopy1();
            cbSelectDefenseEntity.DataSource = entityController.getEntitiesCopy2();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            entityController.Attack((Entity)cbSelectAttackEntity.SelectedItem, (Entity)cbSelectDefenseEntity.SelectedItem);
            dgvWarResults.DataSource = entityController.getEntities();
        }

        private void btnCreateMap_Click(object sender, EventArgs e)
        {
            mapController.GenerateMap();
        }

        private void btnShowMap_Click(object sender, EventArgs e)
        {
            //TODO:Como rellenar aleatoriamente todos los pictureBox, como si todos estuvieran en una lista, o talvez generar los picturebox yo 
            System.Drawing.Image image = System.Drawing.Image.FromFile(mapController.GetTerrainsImageRute());
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);
            bitmap.MakeTransparent();

            System.Windows.Forms.PictureBox pictureBox = new System.Windows.Forms.PictureBox();
            pictureBox1.Image = bitmap;
            //pictureBox1.Width = image.Width;
            //pictureBox1.Height = image.Height;
            //pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        }
    }
}
