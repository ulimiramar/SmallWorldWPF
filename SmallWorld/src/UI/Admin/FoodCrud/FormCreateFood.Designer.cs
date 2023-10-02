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
            this.cbDiet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbListDiets = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRandomsNumber = new System.Windows.Forms.TextBox();
            this.btnCreateRandoms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(26, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 25);
            this.btnExit.TabIndex = 107;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRandomData
            // 
            this.btnRandomData.BackColor = System.Drawing.Color.HotPink;
            this.btnRandomData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomData.ForeColor = System.Drawing.Color.White;
            this.btnRandomData.Location = new System.Drawing.Point(26, 264);
            this.btnRandomData.Name = "btnRandomData";
            this.btnRandomData.Size = new System.Drawing.Size(197, 26);
            this.btnRandomData.TabIndex = 106;
            this.btnRandomData.Text = "Elegir aleatoriamente";
            this.btnRandomData.UseVisualStyleBackColor = false;
            this.btnRandomData.Click += new System.EventHandler(this.btnRandomData_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(229, 264);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(197, 25);
            this.btnCreate.TabIndex = 105;
            this.btnCreate.Text = "Crear Comida";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtEnergyValue
            // 
            this.txtEnergyValue.Location = new System.Drawing.Point(151, 209);
            this.txtEnergyValue.Name = "txtEnergyValue";
            this.txtEnergyValue.Size = new System.Drawing.Size(100, 20);
            this.txtEnergyValue.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Valor energético";
            // 
            // cbDiet
            // 
            this.cbDiet.FormattingEnabled = true;
            this.cbDiet.Location = new System.Drawing.Point(146, 158);
            this.cbDiet.Name = "cbDiet";
            this.cbDiet.Size = new System.Drawing.Size(121, 21);
            this.cbDiet.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "Dieta";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(151, 111);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(100, 20);
            this.txtFoodName.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Nombre Alimento";
            // 
            // clbListDiets
            // 
            this.clbListDiets.FormattingEnabled = true;
            this.clbListDiets.Location = new System.Drawing.Point(306, 85);
            this.clbListDiets.Name = "clbListDiets";
            this.clbListDiets.Size = new System.Drawing.Size(120, 94);
            this.clbListDiets.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Número de Aleatorios";
            // 
            // txtRandomsNumber
            // 
            this.txtRandomsNumber.Location = new System.Drawing.Point(241, 303);
            this.txtRandomsNumber.Name = "txtRandomsNumber";
            this.txtRandomsNumber.Size = new System.Drawing.Size(56, 20);
            this.txtRandomsNumber.TabIndex = 120;
            // 
            // btnCreateRandoms
            // 
            this.btnCreateRandoms.BackColor = System.Drawing.Color.Gold;
            this.btnCreateRandoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRandoms.ForeColor = System.Drawing.Color.Black;
            this.btnCreateRandoms.Location = new System.Drawing.Point(26, 297);
            this.btnCreateRandoms.Name = "btnCreateRandoms";
            this.btnCreateRandoms.Size = new System.Drawing.Size(197, 25);
            this.btnCreateRandoms.TabIndex = 119;
            this.btnCreateRandoms.Text = "Crear aleatorios";
            this.btnCreateRandoms.UseVisualStyleBackColor = false;
            this.btnCreateRandoms.Click += new System.EventHandler(this.btnCreateRandoms_Click);
            // 
            // FormCreateFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRandomsNumber);
            this.Controls.Add(this.btnCreateRandoms);
            this.Controls.Add(this.clbListDiets);
            this.Controls.Add(this.txtEnergyValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDiet);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.ComboBox cbDiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbListDiets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRandomsNumber;
        private System.Windows.Forms.Button btnCreateRandoms;
    }
}