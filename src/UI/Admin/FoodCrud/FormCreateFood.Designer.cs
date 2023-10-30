namespace SmallWorld.src.UI.Admin.FoodCrud
{
    partial class FormCreateFood
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRandomData = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtEnergyValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbListDiets = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRandomsNumber = new System.Windows.Forms.TextBox();
            this.btnCreateRandoms = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(26, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 25);
            this.btnExit.TabIndex = 107;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRandomData
            // 
            this.btnRandomData.BackColor = System.Drawing.Color.LightBlue;
            this.btnRandomData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomData.ForeColor = System.Drawing.Color.Black;
            this.btnRandomData.Location = new System.Drawing.Point(26, 223);
            this.btnRandomData.Name = "btnRandomData";
            this.btnRandomData.Size = new System.Drawing.Size(120, 26);
            this.btnRandomData.TabIndex = 106;
            this.btnRandomData.Text = "Elegir aleatoriamente";
            this.btnRandomData.UseVisualStyleBackColor = false;
            this.btnRandomData.Click += new System.EventHandler(this.btnRandomData_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(247)))), ((int)(((byte)(129)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(26, 255);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 25);
            this.btnCreate.TabIndex = 105;
            this.btnCreate.Text = "Crear Comida";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtEnergyValue
            // 
            this.txtEnergyValue.Location = new System.Drawing.Point(36, 187);
            this.txtEnergyValue.Name = "txtEnergyValue";
            this.txtEnergyValue.Size = new System.Drawing.Size(100, 20);
            this.txtEnergyValue.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Valor energético";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(36, 33);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(100, 20);
            this.txtFoodName.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Nombre Alimento";
            // 
            // clbListDiets
            // 
            this.clbListDiets.FormattingEnabled = true;
            this.clbListDiets.Location = new System.Drawing.Point(26, 73);
            this.clbListDiets.Name = "clbListDiets";
            this.clbListDiets.Size = new System.Drawing.Size(120, 94);
            this.clbListDiets.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Núm de Aleatorios";
            // 
            // txtRandomsNumber
            // 
            this.txtRandomsNumber.Location = new System.Drawing.Point(26, 317);
            this.txtRandomsNumber.Name = "txtRandomsNumber";
            this.txtRandomsNumber.Size = new System.Drawing.Size(36, 20);
            this.txtRandomsNumber.TabIndex = 120;
            // 
            // btnCreateRandoms
            // 
            this.btnCreateRandoms.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCreateRandoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRandoms.ForeColor = System.Drawing.Color.Black;
            this.btnCreateRandoms.Location = new System.Drawing.Point(26, 286);
            this.btnCreateRandoms.Name = "btnCreateRandoms";
            this.btnCreateRandoms.Size = new System.Drawing.Size(120, 25);
            this.btnCreateRandoms.TabIndex = 119;
            this.btnCreateRandoms.Text = "Crear aleatorios";
            this.btnCreateRandoms.UseVisualStyleBackColor = false;
            this.btnCreateRandoms.Click += new System.EventHandler(this.btnCreateRandoms_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "Dietas Compatibles";
            // 
            // FormCreateFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(222)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(175, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRandomsNumber);
            this.Controls.Add(this.btnCreateRandoms);
            this.Controls.Add(this.clbListDiets);
            this.Controls.Add(this.txtEnergyValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRandomData);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCreateFood";
            this.Text = "FormCreateFood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRandomData;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtEnergyValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbListDiets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRandomsNumber;
        private System.Windows.Forms.Button btnCreateRandoms;
        private System.Windows.Forms.Label label2;
    }
}