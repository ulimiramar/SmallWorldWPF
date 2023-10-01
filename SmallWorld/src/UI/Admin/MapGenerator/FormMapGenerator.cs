using SmallWorld.src.Controllers;
using SmallWorld.src.Model.Terrain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SmallWorld.src.UI.Admin.MapGenerator
{
    public partial class FormMapGenerator : Form
    {
        MapController mapController = MapController.GetInstance();
        LandController landController = LandController.GetInstance();
        public FormMapGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerateMap_Click(object sender, EventArgs e)
        {
            mapController.GenerateMap();
            RefreshMap();
            btnGenerateMap.Enabled = false;
        }
        private void RefreshMap()
        {
            bsLands.DataSource = landController.getLands();
            bsLands.ResetBindings(false);
            cbLands.DataSource = bsLands;

            bsBorderingLands.DataSource = landController.getBorderingLands((Land)cbLands.SelectedItem);
            bsBorderingLands.ResetBindings(false);
            cbBorderingLands.DataSource = bsBorderingLands;
        }

        private void cbBorderingLands_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbPositionablesInBorderingLand.DataSource = landController.GetPositionablesInLand((Land)cbBorderingLands.SelectedItem);
        }

        private void cbLands_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMap();
            //cbPositionablesInCurrentLand.DataSource = landController.GetPositionablesInLand((Land)cbLands.SelectedItem);
        }
    }
}
