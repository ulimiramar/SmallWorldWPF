using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Dieta;
using SmallWorld.src.Model.Habitat;
using SmallWorld.src.Model.Map;
using SmallWorld.src.Model.Reino;
using SmallWorld.src.Model.Terreno;
using SmallWorld.src.UI.CustomControls;
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
using static System.Net.Mime.MediaTypeNames;

namespace SmallWorld.src.UI
{
    public partial class TestForm : Form
    {
        private EntityController entityController = EntityController.GetController();
        private MapController mapController = MapController.GetController();
        List<HexagonControl> HexagonsList = new List<HexagonControl>();

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
            entityController.AddEntity((IKingdom)cbKingdom.SelectedItem, txtName.Text, (IDiet)cbDiet.SelectedItem, (IHabitat)cbHabitat.SelectedItem, tbAttack.Value, tbDefense.Value, 1);
            Console.WriteLine($"ataque:{tbAttack.Value} defensa:{tbDefense.Value}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            entityController.ReadEntities();
            dgvEntities.DataSource = entityController.getEntities();

            //TODO: aca pensaba hacer un foreach para que cargue solo los nombres de las entidades en los combobox pero nose como hacer para que no se cargue solo un string y sí la instancia
            cbSelectAttackEntity.DataSource = entityController.getEntitiesCopy1();
            cbSelectDefenseEntity.DataSource = entityController.getEntitiesCopy2();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            //TODO: solucionar como llamar a la función atacar de la propia entidad.
            //entityController.getEntities().

            entityController.Attack((Entity)cbSelectAttackEntity.SelectedItem, (Entity)cbSelectDefenseEntity.SelectedItem);
            dgvWarResults.DataSource = entityController.getEntities();
        }

        private void btnCreateMap_Click(object sender, EventArgs e)
        {
            mapController.GenerateMap();
        }

        private void btnShowMap_Click(object sender, EventArgs e)
        {
            List<Bitmap> imagesRutes = new List<Bitmap>();
            List<HexagonControl> HexagonsList = new List<HexagonControl>();

            int hexagonSize = 60;
            int horizontalSpacing = (int)(1.5 * hexagonSize);
            int verticalSpacing = (int)(Math.Sqrt(3) * hexagonSize);

            foreach (var terrain in mapController.GetTerrains())
            {
                imagesRutes.Add(terrain.getTerrainImageRute());
                Console.WriteLine(imagesRutes.Count);
            }

            Random random = new Random();
            List<Point> occupiedPositions = new List<Point>(); // Lista para rastrear posiciones ocupadas

            for (int i = 0; i < 20; i++)
            {
                // Genera una nueva posición hasta encontrar una disponible
                Point newPosition;
                bool positionIsOccupied;
                do
                {
                    int x = random.Next(panelMap.Width - hexagonSize); // Asegura que el PictureBox no se desborde horizontalmente
                    int y = random.Next(panelMap.Height - hexagonSize); // Asegura que el PictureBox no se desborde verticalmente
                    newPosition = new Point(x, y);

                    // Verifica si la posición ya está ocupada
                    positionIsOccupied = occupiedPositions.Any(pos =>
                        Math.Abs(pos.X - newPosition.X) < horizontalSpacing / 2 &&
                        Math.Abs(pos.Y - newPosition.Y) < verticalSpacing / 2);

                } while (positionIsOccupied);

                // Crea el hexágono en la nueva posición
                HexagonControl Hexagon = new HexagonControl()
                {
                    BackgroundImage = imagesRutes[random.Next(imagesRutes.Count)],
                    BackColor = System.Drawing.Color.Transparent,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.None,
                    Size = new System.Drawing.Size(hexagonSize, hexagonSize)
                };

                Hexagon.Location = newPosition;

                // Agrega la posición ocupada a la lista
                occupiedPositions.Add(newPosition);

                // Agrega el hexágono al Panel
                panelMap.Controls.Add(Hexagon);
                HexagonsList.Add(Hexagon);
            }
        





        /*
        // Obtener coordenadas X e Y aleatorias dentro del Panel
        int x = random.Next(panelMap.Width - Hexagon.Width); // Asegura que el PictureBox no se desborde horizontalmente
        int y = random.Next(panelMap.Height - Hexagon.Height); // Asegura que el PictureBox no se desborde verticalmente

        // Asignar la ubicación al PictureBox
        Hexagon.Location = new Point(x, y);

        // Agregar el PictureBox al Panel
        panelMap.Controls.Add(Hexagon);

        // Agregar el PictureBox a la lista
        HexagonsList.Add(Hexagon);
        */



        /*
        //Codigo para generar PicturesBox argandoles imagenes de hexagonos
        List<PictureBox> PicturesBoxs = new List<PictureBox>();

        foreach (var terrain in mapController.GetTerrains())
        {
            imagesRutes.Add(terrain.getTerrainImageRute());
            Console.WriteLine(imagesRutes.Count);
        }

        Random random = new Random();

        foreach (var imageRute in imagesRutes)
        {
            // Crear un nuevo PictureBox para cada imagen
            PictureBox pictureBox = new PictureBox
            {
                Image = System.Drawing.Image.FromFile(imageRute),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(60, 60)
            };


            // Obtener coordenadas X e Y aleatorias dentro del Panel
            int x = random.Next(panelMap.Width - pictureBox.Width); // Asegura que el PictureBox no se desborde horizontalmente
            int y = random.Next(panelMap.Height - pictureBox.Height); // Asegura que el PictureBox no se desborde verticalmente

            // Asignar la ubicación al PictureBox
            pictureBox.Location = new Point(x, y);

            // Agregar el PictureBox al Panel
            panelMap.Controls.Add(pictureBox);

            // Agregar el PictureBox a la lista
            PicturesBoxs.Add(pictureBox);
        }
        */







        /*

        List<string> imagesRutes = new List<string>();
        List<System.Drawing.Image> images = new List<System.Drawing.Image>();
        List<Bitmap> bitmaps = new List<Bitmap>();
        List<PictureBox> PicturesBoxs = new List<PictureBox>();

        foreach (var terrain in mapController.GetTerrains())
        {
            imagesRutes.Add(terrain.TerrainType.getTerrainImageRute());
            foreach(var imageRute in imagesRutes)
            {
                images.Add(System.Drawing.Image.FromFile(imageRute));
                foreach(var image in images)
                {
                    bitmaps.Add(new Bitmap(image));
                    foreach(var bitmap in bitmaps)
                    {
                        foreach(var pictureBox in PicturesBoxs)
                        {
                            pictureBox.Image = bitmap;
                        }
                    }
                }
            }

        }

        /*for (int i = 0; i<imagesRutes.Count; i++)
        {
            images.Add(System.Drawing.Image.FromFile(imagesRutes[i]));
            bitmaps.Add(new Bitmap(images[i]));
            bitmaps[i].MakeTransparent();
            PicturesBoxs.Image = bitmaps[i];

        }*/
        /*
        Random random = new Random();

        foreach (PictureBox pictureBox in PicturesBoxs)
        {
            // Obtener coordenadas X e Y aleatorias dentro del Panel
            int x = random.Next(panelMap.Width - pictureBox.Width); // Asegura que el PictureBox no se desborde horizontalmente
            int y = random.Next(panelMap.Height - pictureBox.Height); // Asegura que el PictureBox no se desborde verticalmente

            // Asignar la ubicación al PictureBox
            pictureBox.Location = new Point(x, y);

            // Agregar el PictureBox al Panel
            panelMap.Controls.Add(pictureBox);
        }
        */

        /* acá queria hacer una rellenada de clases con metodos
        foreach (var terrain in mapController.GetTerrains())
        {
            imagesRutes.Add(terrain.TerrainType.getTerrainImageRute());
        }

        foreach (var image in images)
        {
            image = System.Drawing.Image.FromFile();
        }


        foreach (var pictureBox in PicturesBoxs)
        {

        }*/




        //System.Drawing.Image image = System.Drawing.Image.FromFile(mapController.GetTerrainsImageRute());
        //System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);
        //bitmap.MakeTransparent();

        //System.Windows.Forms.PictureBox pictureBox = new System.Windows.Forms.PictureBox();
        //pictureBox1.Image = bitmap;
        //pictureBox1.Width = image.Width;
        //pictureBox1.Height = image.Height;
        //pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    }

    private void hexagonPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
