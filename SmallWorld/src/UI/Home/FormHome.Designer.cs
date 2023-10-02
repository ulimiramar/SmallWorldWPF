namespace SmallWorld.src.UI.Home
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pSideMenu = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pAdminSubMenu = new System.Windows.Forms.Panel();
            this.btnFoodCrud = new System.Windows.Forms.Button();
            this.btnItemCrud = new System.Windows.Forms.Button();
            this.btnEntityCrud = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pSideMenu.SuspendLayout();
            this.pAdminSubMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSideMenu
            // 
            this.pSideMenu.AutoScroll = true;
            this.pSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(247)))), ((int)(((byte)(129)))));
            this.pSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSideMenu.Controls.Add(this.btnPlay);
            this.pSideMenu.Controls.Add(this.pAdminSubMenu);
            this.pSideMenu.Controls.Add(this.btnAdmin);
            this.pSideMenu.Controls.Add(this.panel1);
            this.pSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pSideMenu.Name = "pSideMenu";
            this.pSideMenu.Size = new System.Drawing.Size(200, 561);
            this.pSideMenu.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(192)))), ((int)(((byte)(129)))));
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(0, 269);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlay.Size = new System.Drawing.Size(198, 45);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Jugar";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pAdminSubMenu
            // 
            this.pAdminSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(222)))), ((int)(((byte)(144)))));
            this.pAdminSubMenu.Controls.Add(this.btnFoodCrud);
            this.pAdminSubMenu.Controls.Add(this.btnItemCrud);
            this.pAdminSubMenu.Controls.Add(this.btnEntityCrud);
            this.pAdminSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAdminSubMenu.Location = new System.Drawing.Point(0, 145);
            this.pAdminSubMenu.Name = "pAdminSubMenu";
            this.pAdminSubMenu.Size = new System.Drawing.Size(198, 124);
            this.pAdminSubMenu.TabIndex = 2;
            // 
            // btnFoodCrud
            // 
            this.btnFoodCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(222)))), ((int)(((byte)(144)))));
            this.btnFoodCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoodCrud.FlatAppearance.BorderSize = 0;
            this.btnFoodCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodCrud.ForeColor = System.Drawing.Color.Black;
            this.btnFoodCrud.Location = new System.Drawing.Point(0, 80);
            this.btnFoodCrud.Name = "btnFoodCrud";
            this.btnFoodCrud.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFoodCrud.Size = new System.Drawing.Size(198, 40);
            this.btnFoodCrud.TabIndex = 2;
            this.btnFoodCrud.Text = "CRUD Alimentos";
            this.btnFoodCrud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodCrud.UseVisualStyleBackColor = false;
            this.btnFoodCrud.Click += new System.EventHandler(this.btnFoodCrud_Click);
            // 
            // btnItemCrud
            // 
            this.btnItemCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(222)))), ((int)(((byte)(144)))));
            this.btnItemCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemCrud.FlatAppearance.BorderSize = 0;
            this.btnItemCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCrud.ForeColor = System.Drawing.Color.Black;
            this.btnItemCrud.Location = new System.Drawing.Point(0, 40);
            this.btnItemCrud.Name = "btnItemCrud";
            this.btnItemCrud.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnItemCrud.Size = new System.Drawing.Size(198, 40);
            this.btnItemCrud.TabIndex = 1;
            this.btnItemCrud.Text = "CRUD Items";
            this.btnItemCrud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemCrud.UseVisualStyleBackColor = false;
            this.btnItemCrud.Click += new System.EventHandler(this.btnItemCrud_Click);
            // 
            // btnEntityCrud
            // 
            this.btnEntityCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(222)))), ((int)(((byte)(144)))));
            this.btnEntityCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntityCrud.FlatAppearance.BorderSize = 0;
            this.btnEntityCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntityCrud.ForeColor = System.Drawing.Color.Black;
            this.btnEntityCrud.Location = new System.Drawing.Point(0, 0);
            this.btnEntityCrud.Name = "btnEntityCrud";
            this.btnEntityCrud.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEntityCrud.Size = new System.Drawing.Size(198, 40);
            this.btnEntityCrud.TabIndex = 0;
            this.btnEntityCrud.Text = "CRUD Entidades";
            this.btnEntityCrud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntityCrud.UseVisualStyleBackColor = false;
            this.btnEntityCrud.Click += new System.EventHandler(this.btnEntityCrud_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(192)))), ((int)(((byte)(129)))));
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Location = new System.Drawing.Point(0, 100);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(198, 45);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(247)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SmallWorld";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(247)))), ((int)(((byte)(129)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(734, 561);
            this.panelChildForm.TabIndex = 1;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.pSideMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.pSideMenu.ResumeLayout(false);
            this.pAdminSubMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSideMenu;
        private System.Windows.Forms.Panel pAdminSubMenu;
        private System.Windows.Forms.Button btnFoodCrud;
        private System.Windows.Forms.Button btnItemCrud;
        private System.Windows.Forms.Button btnEntityCrud;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnPlay;
    }
}