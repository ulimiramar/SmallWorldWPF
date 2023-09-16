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
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Efecto del Item";
            // 
            // cbItemEffect
            // 
            this.cbItemEffect.FormattingEnabled = true;
            this.cbItemEffect.Location = new System.Drawing.Point(135, 163);
            this.cbItemEffect.Name = "cbItemEffect";
            this.cbItemEffect.Size = new System.Drawing.Size(195, 21);
            this.cbItemEffect.TabIndex = 26;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(118, 245);
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
            this.btnRandomData.Location = new System.Drawing.Point(26, 213);
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
            this.btnCreate.Location = new System.Drawing.Point(229, 213);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(197, 25);
            this.btnCreate.TabIndex = 102;
            this.btnCreate.Text = "Crear Item";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormCreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
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
    }
}