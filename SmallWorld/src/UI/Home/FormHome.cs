using SmallWorld.src.UI.Admin;
using SmallWorld.src.UI.Admin.ItemCrud;
using SmallWorld.src.UI.FormsGame;
using SmallWorld.src.UI.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI.Home
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void CustomizeDesing()
        {
            pAdminSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (pAdminSubMenu.Visible) pAdminSubMenu.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pAdminSubMenu);
        }

        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.Show();
        }

        private void btnEntityCrud_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEntityCrud());
        }

        private void btnItemCrud_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormItemsCrudHome());
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PrincipalFormTest());
            HideSubMenu();
        }

        private void btnFoodCrud_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFoodCrudHome());
        }

        private void btnPlayNewVersion_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormGame(new Game());
        }
    }
}
