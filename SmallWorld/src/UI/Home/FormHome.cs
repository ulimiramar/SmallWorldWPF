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
        private void OpenChildForm(Form childForm)
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
            OpenChildForm(new EntitiesCrudFormTest());
        }

        private void btnItemCrud_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItemsCrudFormTest());
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PrincipalFormTest());
        }
    }
}
