namespace SmallWorld.src.UI.Admin.ItemsCrud
{
    partial class FormCreateItem
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
            this.label8 = new System.Windows.Forms.Label();
            this.cbItemEffect = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRandomData = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.clbListEffects = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRandomsNumber = new System.Windows.Forms.TextBox();
            this.btnCreateRandoms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Efecto del Item";
            // 
            // cbItemEffect
            // 
            this.cbItemEffect.FormattingEnabled = true;
            this.cbItemEffect.Location = new System.Drawing.Point(135, 222);
            this.cbItemEffect.Name = "cbItemEffect";
            this.cbItemEffect.Size = new System.Drawing.Size(195, 21);
            this.cbItemEffect.TabIndex = 26;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(26, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 25);
            this.btnExit.TabIndex = 104;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRandomData
            // 
            this.btnRandomData.BackColor = System.Drawing.Color.HotPink;
            this.btnRandomData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomData.ForeColor = System.Drawing.Color.White;
            this.btnRandomData.Location = new System.Drawing.Point(26, 265);
            this.btnRandomData.Name = "btnRandomData";
            this.btnRandomData.Size = new System.Drawing.Size(197, 26);
            this.btnRandomData.TabIndex = 103;
            this.btnRandomData.Text = "Elegir aleatoriamente";
            this.btnRandomData.UseVisualStyleBackColor = false;
            this.btnRandomData.Click += new System.EventHandler(this.btnRandomData_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(229, 265);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(197, 25);
            this.btnCreate.TabIndex = 102;
            this.btnCreate.Text = "Crear Item";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // clbListEffects
            // 
            this.clbListEffects.FormattingEnabled = true;
            this.clbListEffects.Location = new System.Drawing.Point(179, 122);
            this.clbListEffects.Name = "clbListEffects";
            this.clbListEffects.Size = new System.Drawing.Size(120, 94);
            this.clbListEffects.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Nombre del Item";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 124;
            this.label5.Text = "Número de Aleatorios";
            // 
            // txtRandomsNumber
            // 
            this.txtRandomsNumber.Location = new System.Drawing.Point(241, 303);
            this.txtRandomsNumber.Name = "txtRandomsNumber";
            this.txtRandomsNumber.Size = new System.Drawing.Size(56, 20);
            this.txtRandomsNumber.TabIndex = 123;
            // 
            // btnCreateRandoms
            // 
            this.btnCreateRandoms.BackColor = System.Drawing.Color.Gold;
            this.btnCreateRandoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRandoms.ForeColor = System.Drawing.Color.Black;
            this.btnCreateRandoms.Location = new System.Drawing.Point(26, 297);
            this.btnCreateRandoms.Name = "btnCreateRandoms";
            this.btnCreateRandoms.Size = new System.Drawing.Size(197, 25);
            this.btnCreateRandoms.TabIndex = 122;
            this.btnCreateRandoms.Text = "Crear aleatorios";
            this.btnCreateRandoms.UseVisualStyleBackColor = false;
            this.btnCreateRandoms.Click += new System.EventHandler(this.btnCreateRandoms_Click);
            // 
            // FormCreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRandomsNumber);
            this.Controls.Add(this.btnCreateRandoms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.clbListEffects);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRandomData);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbItemEffect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCreateItem";
            this.Text = "FormCreateItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbItemEffect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRandomData;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckedListBox clbListEffects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRandomsNumber;
        private System.Windows.Forms.Button btnCreateRandoms;
    }
}