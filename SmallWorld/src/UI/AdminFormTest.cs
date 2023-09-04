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
    public partial class AdminFormTest : Form
    {
        public AdminFormTest()
        {
            InitializeComponent();
        }

        private void btnEntitiesCrud_Click(object sender, EventArgs e)
        {
            EntitiesCrudFormTest entitiesCrudFormTest = new EntitiesCrudFormTest();
            entitiesCrudFormTest.Show();
        }

        private void btnItemsCrud_Click(object sender, EventArgs e)
        {
            ItemsCrudFormTest itemsCrudFormTest = new ItemsCrudFormTest();
            itemsCrudFormTest.Show();
        }

        private void btnFoodCrud_Click(object sender, EventArgs e)
        {
            FoodCrudFormTest foodCrudFormTest = new FoodCrudFormTest();
            foodCrudFormTest.Show();
        }
    }
}
