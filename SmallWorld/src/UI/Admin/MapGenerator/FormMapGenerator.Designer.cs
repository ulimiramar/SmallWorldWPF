namespace SmallWorld.src.UI.Admin.MapGenerator
{
    partial class FormMapGenerator
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
            this.components = new System.ComponentModel.Container();
            this.btnGenerateMap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.cbBorderingLands = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbLands = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPositionablesInCurrentLand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPositionablesInBorderingLand = new System.Windows.Forms.ComboBox();
            this.bsLands = new System.Windows.Forms.BindingSource(this.components);
            this.bsBorderingLands = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBorderingLands)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateMap
            // 
            this.btnGenerateMap.Location = new System.Drawing.Point(232, 44);
            this.btnGenerateMap.Name = "btnGenerateMap";
            this.btnGenerateMap.Size = new System.Drawing.Size(208, 23);
            this.btnGenerateMap.TabIndex = 21;
            this.btnGenerateMap.Text = "Generar Mapa Aleatoriamente";
            this.btnGenerateMap.UseVisualStyleBackColor = true;
            this.btnGenerateMap.Click += new System.EventHandler(this.btnGenerateMap_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbPositionablesInBorderingLand);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbPositionablesInCurrentLand);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.cbBorderingLands);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.cbLands);
            this.panel3.Location = new System.Drawing.Point(97, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 261);
            this.panel3.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(271, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Terrenos Limítrofes";
            // 
            // cbBorderingLands
            // 
            this.cbBorderingLands.FormattingEnabled = true;
            this.cbBorderingLands.Location = new System.Drawing.Point(274, 26);
            this.cbBorderingLands.Name = "cbBorderingLands";
            this.cbBorderingLands.Size = new System.Drawing.Size(121, 21);
            this.cbBorderingLands.TabIndex = 2;
            this.cbBorderingLands.SelectedIndexChanged += new System.EventHandler(this.cbBorderingLands_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Terreno";
            // 
            // cbLands
            // 
            this.cbLands.FormattingEnabled = true;
            this.cbLands.Location = new System.Drawing.Point(28, 26);
            this.cbLands.Name = "cbLands";
            this.cbLands.Size = new System.Drawing.Size(121, 21);
            this.cbLands.TabIndex = 0;
            this.cbLands.SelectedIndexChanged += new System.EventHandler(this.cbLands_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Mapa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Qué hay en este terreno?";
            // 
            // cbPositionablesInCurrentLand
            // 
            this.cbPositionablesInCurrentLand.FormattingEnabled = true;
            this.cbPositionablesInCurrentLand.Location = new System.Drawing.Point(28, 99);
            this.cbPositionablesInCurrentLand.Name = "cbPositionablesInCurrentLand";
            this.cbPositionablesInCurrentLand.Size = new System.Drawing.Size(121, 21);
            this.cbPositionablesInCurrentLand.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "¿Qué hay en este terreno?";
            // 
            // cbPositionablesInBorderingLand
            // 
            this.cbPositionablesInBorderingLand.FormattingEnabled = true;
            this.cbPositionablesInBorderingLand.Location = new System.Drawing.Point(274, 99);
            this.cbPositionablesInBorderingLand.Name = "cbPositionablesInBorderingLand";
            this.cbPositionablesInBorderingLand.Size = new System.Drawing.Size(121, 21);
            this.cbPositionablesInBorderingLand.TabIndex = 7;
            // 
            // FormMapGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 444);
            this.Controls.Add(this.btnGenerateMap);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMapGenerator";
            this.Text = "FormMapGenerator";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBorderingLands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateMap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbPositionablesInBorderingLand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPositionablesInCurrentLand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbBorderingLands;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbLands;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource bsLands;
        private System.Windows.Forms.BindingSource bsBorderingLands;
    }
}