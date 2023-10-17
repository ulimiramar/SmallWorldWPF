using SmallWorld.src.Controllers;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Interactuable;
using SmallWorld.src.Model.Map;
using SmallWorld.src.Model.Terrain;
using SmallWorld.src.UI.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI.FormsGame
{
    public partial class FormGame : Form
    {
        EntityController entityController = EntityController.GetInstance();
        ItemController itemController = ItemController.GetInstance();
        FoodController foodController = FoodController.GetInstance();
        MapController mapController = MapController.GetInstance();
        FormController formController = FormController.GetInstance();
        List<HexagonControl> hexagons = new List<HexagonControl>();
        List<Land> lands = new List<Land>();
        int indexOfSelectedHexagon;
        public FormGame()
        {
            InitializeComponent();
            lands = mapController.getLands();
            AddHexagonsToList();
            foreach (var hexagon in hexagons)
            {
                hexagon.Click += Hexagon_Click;
            }
            MapNumberLandsView();
            PaintHexagons();
            
        }
        private void AddHexagonsToList()
        {
            hexagons.AddRange(new List<HexagonControl>
            {
                hexagon0, hexagon1, hexagon2, hexagon3, hexagon4, hexagon5,
                hexagon6, hexagon7, hexagon8, hexagon9, hexagon10, hexagon11,
                hexagon12, hexagon13, hexagon14, hexagon15, hexagon16, hexagon17,
                hexagon18
            });
        }
        private void FillDgvs(int selectedHexagon)
        {
            dgvFood.Rows.Clear();
            dgvItems.Rows.Clear();
            dgvP1Entities.Rows.Clear();
            dgvP2Entities.Rows.Clear();

            Land land = mapController.getLands()[selectedHexagon];
            
            foreach (Entity entity in land.Entities.Where(e => e.NumPlayer == 1 && e.DieStatus == false))
            {
                dgvP1Entities.Rows.Add(entity.Id, entity.Name, entity.Kingdom,
                    entity.HabitatName, entity.Diet, $"{entity.CurrentLife}/{entity.MaxLife}",
                    $"{entity.CurrentEnergy}/{entity.MaxEnergy}", entity.AttackPoints,
                    entity.DefensePoints);
            }
            foreach(Entity entity in land.Entities.Where(e => e.NumPlayer == 2 && e.DieStatus == false))
            {
                dgvP2Entities.Rows.Add(entity.Id, entity.Name, entity.Kingdom,
                    entity.HabitatName, entity.Diet, $"{entity.CurrentLife}/{entity.MaxLife}",
                    $"{entity.CurrentEnergy}/{entity.MaxEnergy}", entity.AttackPoints,
                    entity.DefensePoints);
            }

            foreach(Item item in land.Items)
            {
                dgvItems.Rows.Add(item.Id, item.StrategyNames);
            }
            foreach(Food food in land.Foods)
            {
                dgvFood.Rows.Add(food.Id, food.DietNames, food.EnergyValue);
            }
        }
        private void Hexagon_Click(object sender, EventArgs e)
        {
            HexagonControl clickedHexagon = sender as HexagonControl;
            int index = hexagons.IndexOf(clickedHexagon);
            ChangeColorOfSelectedHexagonAndTheirBorderingHexagons(lands[index]); 

            if (!clickedHexagon.IsSelected)
            {
                foreach (var hexagon in hexagons)
                {
                    hexagon.IsSelected = false;
                }

                clickedHexagon.IsSelected = true;
                indexOfSelectedHexagon = hexagons.IndexOf(clickedHexagon);
                FillDgvs(indexOfSelectedHexagon);

            }
        }
        private void ChangeColorOfSelectedHexagonAndTheirBorderingHexagons(Land land)
        {
            ResetHexagonBorderColor();
            hexagons[land.Id].BorderColor = Color.HotPink;
            for (int i = 0; i < land.BorderingLands.Count(); i++)
            {
                hexagons[land.BorderingLands[i].Id].BorderColor = Color.Red;
            }
        }
        private void ResetHexagonBorderColor()
        {
            foreach (var hexagon in hexagons)
            {
                hexagon.BorderColor = SystemColors.ControlText; // O utiliza el color original del borde
            }
        }
        private void PaintHexagons()
        {
            for (int i = 0; i < hexagons.Count(); i++)
            {
                hexagons[i].BackColor = lands[i].TerrainType.getColor();
            }
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void btnFoodMap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hexagons.Count(); i++)
            {
                hexagons[i].HexagonText = $"{lands[i].Foods.Count}";
                hexagons[i].Invalidate();
            }
        }

        private void btnItemsMap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hexagons.Count(); i++)
            {
                hexagons[i].HexagonText = $"{lands[i].Items.Count}";
                hexagons[i].Invalidate();
            }
        }

        private void ChangeLandsInfo<GenericList>(List<GenericList> ObjectsList)
        {
            
            for (int i = 0; i < hexagons.Count(); i++)
            {
                hexagons[i].HexagonText = $"{lands[i].Items}"; //TODO: resolver como mostrar los diferentes modos de mapa en una sola función
            }
        }

        private void btnEntitiesMap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hexagons.Count(); i++)
            {
                hexagons[i].HexagonText = $"{lands[i].Entities.Count(entity => entity.DieStatus == false && entity.NumPlayer == 1)} vs {lands[i].Entities.Count((entity => entity.DieStatus == false && entity.NumPlayer == 2))}";
                hexagons[i].Invalidate();
            }
        }
        private void MapNumberLandsView()
        {
            for (int i = 0; i < hexagons.Count(); i++)
            {
                hexagons[i].HexagonText = $"{i}";
                hexagons[i].Invalidate();
            }
        }

        private void btnNumLandMap_Click(object sender, EventArgs e)
        {
            MapNumberLandsView();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (dgvP1Entities.SelectedRows.Count > 0 && dgvP2Entities.SelectedRows.Count > 0)
            {
                //TODO: aca será entityCurrentPlayer y entityWaitingPlayer
                Entity entity1 = entityController.FindEntity(Convert.ToInt32(dgvP1Entities.SelectedRows[0].Cells["IdEntity"].Value));
                Entity entity2 = entityController.FindEntity(Convert.ToInt32(dgvP2Entities.SelectedRows[0].Cells["IdEntity2"].Value));
                

                try
                {
                    entityController.Attack(entity1, entity2);
                    FillDgvs(indexOfSelectedHexagon);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    FillDgvs(indexOfSelectedHexagon);
                }
            }
            else { MessageBox.Show($"Error, debe seleccionar su Entidad y la entidad a atacar"); }
        }

        private void btnUseItem_Click(object sender, EventArgs e)
        {
            Item item = itemController.FindItem(Convert.ToInt32(dgvItems.SelectedRows[0].Cells[0].Value));
            Entity entity1 = entityController.FindEntity(Convert.ToInt32(dgvP1Entities.SelectedRows[0].Cells["IdEntity"].Value));
            item.ExecuteEffectStrategy(entity1);
            FillDgvs(indexOfSelectedHexagon);
        }
    }
}
