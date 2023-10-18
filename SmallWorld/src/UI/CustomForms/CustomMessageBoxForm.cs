using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI.CustomForms
{
    public partial class CustomMessageBoxForm : Form
    {
        public CustomMessageBoxForm(string message)
        {
            InitializeComponent();
            MessageText = message;
        }
        public string MessageText
        {
            get { return labelMessage.Text; }
            set { labelMessage.Text = value; }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
