using SmallWorld.src.Controllers;
using SmallWorld.src.Model;
using SmallWorld.src.Model.MapModel;
using SmallWorld.src.UI.CustomForms;
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
    public partial class FormMove : Form
    {
        MapController mapController = MapController.GetInstance();
        Land OriginLand;
        Land DestinyLand;
        Entity entityToMove;
        public FormMove(Land land, Entity entity)
        {
            InitializeComponent();
            OriginLand = land;
            entityToMove = entity;
            FillDgvLands(OriginLand);
        }
        private void FillDgvLands(Land land)
        {
            foreach(Land borderingLand in land.BorderingLands)
            {
                dgvLands.Rows.Add(borderingLand.LandId, borderingLand.TerrainTypeName);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            DestinyLand = mapController.getLands()[Convert.ToInt32(dgvLands.SelectedRows[0].Cells[0].Value)];
            try
            {
                mapController.MoveMovible(OriginLand, DestinyLand, entityToMove);
            }
            catch (Exception ex)
            {
                new CustomMessageBoxForm(ex.Message). ShowDialog();
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
