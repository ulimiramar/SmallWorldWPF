namespace SmallWorld.src.UI
{
    partial class FoodCrudFormTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDiet = new System.Windows.Forms.ComboBox();
            this.btnCreateFood = new System.Windows.Forms.Button();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.btnModifyUpdateFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.txtEnergyValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.bsFoods = new System.Windows.Forms.BindingSource(this.components);
            this.btnRandomData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Alimento";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(89, 92);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(100, 20);
            this.txtFoodName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dieta";
            // 
            // cbDiet
            // 
            this.cbDiet.FormattingEnabled = true;
            this.cbDiet.Location = new System.Drawing.Point(89, 139);
            this.cbDiet.Name = "cbDiet";
            this.cbDiet.Size = new System.Drawing.Size(121, 21);
            this.cbDiet.TabIndex = 3;
            // 
            // btnCreateFood
            // 
            this.btnCreateFood.Location = new System.Drawing.Point(89, 232);
            this.btnCreateFood.Name = "btnCreateFood";
            this.btnCreateFood.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFood.TabIndex = 4;
            this.btnCreateFood.Text = "Crear";
            this.btnCreateFood.UseVisualStyleBackColor = true;
            this.btnCreateFood.Click += new System.EventHandler(this.btnCreateFood_Click);
            // 
            // dgvFoods
            // 
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Location = new System.Drawing.Point(288, 60);
            this.dgvFoods.MultiSelect = false;
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoods.Size = new System.Drawing.Size(330, 150);
            this.dgvFoods.TabIndex = 5;
            // 
            // btnModifyUpdateFood
            // 
            this.btnModifyUpdateFood.Location = new System.Drawing.Point(320, 232);
            this.btnModifyUpdateFood.Name = "btnModifyUpdateFood";
            this.btnModifyUpdateFood.Size = new System.Drawing.Size(75, 23);
            this.btnModifyUpdateFood.TabIndex = 6;
            this.btnModifyUpdateFood.Text = "Modificar";
            this.btnModifyUpdateFood.UseVisualStyleBackColor = true;
            this.btnModifyUpdateFood.Click += new System.EventHandler(this.btnModifyUpdateFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(419, 232);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFood.TabIndex = 7;
            this.btnDeleteFood.Text = "Borrar";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(320, 278);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdate.TabIndex = 8;
            this.btnCancelUpdate.Text = "Cancelar";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // txtEnergyValue
            // 
            this.txtEnergyValue.Location = new System.Drawing.Point(89, 190);
            this.txtEnergyValue.Name = "txtEnergyValue";
            this.txtEnergyValue.Size = new System.Drawing.Size(100, 20);
            this.txtEnergyValue.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor energético";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(230, 92);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Valor";
            // 
            // btnRandomData
            // 
            this.btnRandomData.Location = new System.Drawing.Point(89, 33);
            this.btnRandomData.Name = "btnRandomData";
            this.btnRandomData.Size = new System.Drawing.Size(121, 23);
            this.btnRandomData.TabIndex = 13;
            this.btnRandomData.Text = "Llenado automático";
            this.btnRandomData.UseVisualStyleBackColor = true;
            this.btnRandomData.Click += new System.EventHandler(this.btnRandomData_Click);
            // 
            // FoodCrudFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 483);
            this.Controls.Add(this.btnRandomData);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnergyValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnModifyUpdateFood);
            this.Controls.Add(this.dgvFoods);
            this.Controls.Add(this.btnCreateFood);
            this.Controls.Add(this.cbDiet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label1);
            this.Name = "FoodCrudFormTest";
            this.Text = "FoodCrudFormTest";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDiet;
        private System.Windows.Forms.Button btnCreateFood;
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.Button btnModifyUpdateFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.TextBox txtEnergyValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.BindingSource bsFoods;
        private System.Windows.Forms.Button btnRandomData;
    }
}