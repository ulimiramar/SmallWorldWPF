namespace SmallWorld.src.UI
{
    partial class PrincipalFormTest
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSelectMyEntity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbDefenseShieldMyEntity = new System.Windows.Forms.ProgressBar();
            this.pbCurrentEnergyMyEntity = new System.Windows.Forms.ProgressBar();
            this.pbCurrentLifeMyEntity = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSelectEntityFromOtherUser = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbCurrentEnergyOtherUser = new System.Windows.Forms.ProgressBar();
            this.pbDefenseShieldOtherUser = new System.Windows.Forms.ProgressBar();
            this.pbCurrentLifeOtherUser = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnInteract = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(87, 24);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(91, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entidades";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbSelectMyEntity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pbDefenseShieldMyEntity);
            this.panel1.Controls.Add(this.pbCurrentEnergyMyEntity);
            this.panel1.Controls.Add(this.pbCurrentLifeMyEntity);
            this.panel1.Location = new System.Drawing.Point(87, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 197);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tus entidades";
            // 
            // cbSelectMyEntity
            // 
            this.cbSelectMyEntity.FormattingEnabled = true;
            this.cbSelectMyEntity.Location = new System.Drawing.Point(22, 23);
            this.cbSelectMyEntity.Name = "cbSelectMyEntity";
            this.cbSelectMyEntity.Size = new System.Drawing.Size(121, 21);
            this.cbSelectMyEntity.TabIndex = 6;
            this.cbSelectMyEntity.SelectedIndexChanged += new System.EventHandler(this.cbSelectMyEntity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Escudo de Defensa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Energía Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vida Actual";
            // 
            // pbDefenseShieldMyEntity
            // 
            this.pbDefenseShieldMyEntity.Location = new System.Drawing.Point(22, 156);
            this.pbDefenseShieldMyEntity.Name = "pbDefenseShieldMyEntity";
            this.pbDefenseShieldMyEntity.Size = new System.Drawing.Size(100, 23);
            this.pbDefenseShieldMyEntity.TabIndex = 3;
            // 
            // pbCurrentEnergyMyEntity
            // 
            this.pbCurrentEnergyMyEntity.Location = new System.Drawing.Point(22, 114);
            this.pbCurrentEnergyMyEntity.Name = "pbCurrentEnergyMyEntity";
            this.pbCurrentEnergyMyEntity.Size = new System.Drawing.Size(100, 23);
            this.pbCurrentEnergyMyEntity.TabIndex = 3;
            // 
            // pbCurrentLifeMyEntity
            // 
            this.pbCurrentLifeMyEntity.Location = new System.Drawing.Point(22, 72);
            this.pbCurrentLifeMyEntity.Name = "pbCurrentLifeMyEntity";
            this.pbCurrentLifeMyEntity.Size = new System.Drawing.Size(100, 23);
            this.pbCurrentLifeMyEntity.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Terreno Seleccionado";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbSelectEntityFromOtherUser);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pbCurrentEnergyOtherUser);
            this.panel2.Controls.Add(this.pbDefenseShieldOtherUser);
            this.panel2.Controls.Add(this.pbCurrentLifeOtherUser);
            this.panel2.Location = new System.Drawing.Point(489, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 197);
            this.panel2.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Escudo de Defensa";
            // 
            // cbSelectEntityFromOtherUser
            // 
            this.cbSelectEntityFromOtherUser.FormattingEnabled = true;
            this.cbSelectEntityFromOtherUser.Location = new System.Drawing.Point(16, 22);
            this.cbSelectEntityFromOtherUser.Name = "cbSelectEntityFromOtherUser";
            this.cbSelectEntityFromOtherUser.Size = new System.Drawing.Size(121, 21);
            this.cbSelectEntityFromOtherUser.TabIndex = 1;
            this.cbSelectEntityFromOtherUser.SelectedIndexChanged += new System.EventHandler(this.cbSelectEntityFromOtherUser_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Energía Actual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Entidades en este terreno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Vida Actual";
            // 
            // pbCurrentEnergyOtherUser
            // 
            this.pbCurrentEnergyOtherUser.Location = new System.Drawing.Point(16, 114);
            this.pbCurrentEnergyOtherUser.Name = "pbCurrentEnergyOtherUser";
            this.pbCurrentEnergyOtherUser.Size = new System.Drawing.Size(100, 23);
            this.pbCurrentEnergyOtherUser.TabIndex = 10;
            // 
            // pbDefenseShieldOtherUser
            // 
            this.pbDefenseShieldOtherUser.Location = new System.Drawing.Point(16, 156);
            this.pbDefenseShieldOtherUser.Name = "pbDefenseShieldOtherUser";
            this.pbDefenseShieldOtherUser.Size = new System.Drawing.Size(100, 23);
            this.pbDefenseShieldOtherUser.TabIndex = 9;
            // 
            // pbCurrentLifeOtherUser
            // 
            this.pbCurrentLifeOtherUser.Location = new System.Drawing.Point(16, 72);
            this.pbCurrentLifeOtherUser.Name = "pbCurrentLifeOtherUser";
            this.pbCurrentLifeOtherUser.Size = new System.Drawing.Size(100, 23);
            this.pbCurrentLifeOtherUser.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Mapa";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(265, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 197);
            this.panel3.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(572, 83);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(508, 323);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 8;
            this.btnAttack.Text = "Atacar";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnInteract
            // 
            this.btnInteract.Location = new System.Drawing.Point(664, 323);
            this.btnInteract.Name = "btnInteract";
            this.btnInteract.Size = new System.Drawing.Size(75, 23);
            this.btnInteract.TabIndex = 14;
            this.btnInteract.Text = "Interactuar";
            this.btnInteract.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.cbItems);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(645, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 197);
            this.panel4.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Info del item";
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(16, 22);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 21);
            this.cbItems.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Items en este terreno";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(316, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Mover";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PrincipalFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnInteract);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmin);
            this.Name = "PrincipalFormTest";
            this.Text = "PincipalFormTest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSelectMyEntity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbDefenseShieldMyEntity;
        private System.Windows.Forms.ProgressBar pbCurrentEnergyMyEntity;
        private System.Windows.Forms.ProgressBar pbCurrentLifeMyEntity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSelectEntityFromOtherUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar pbCurrentEnergyOtherUser;
        private System.Windows.Forms.ProgressBar pbDefenseShieldOtherUser;
        private System.Windows.Forms.ProgressBar pbCurrentLifeOtherUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnInteract;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
    }
}