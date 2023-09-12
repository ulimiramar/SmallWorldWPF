namespace SmallWorld.src.UI
{
    partial class ItemsCrudFormTest
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModifyUpdate = new System.Windows.Forms.Button();
            this.cbItemEffect = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbKingdom = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(272, 24);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(374, 150);
            this.dgvItems.TabIndex = 0;
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.Location = new System.Drawing.Point(153, 97);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(75, 23);
            this.btnCreateItem.TabIndex = 15;
            this.btnCreateItem.Text = "Crear";
            this.btnCreateItem.UseVisualStyleBackColor = true;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(386, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModifyUpdate
            // 
            this.btnModifyUpdate.Location = new System.Drawing.Point(295, 195);
            this.btnModifyUpdate.Name = "btnModifyUpdate";
            this.btnModifyUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnModifyUpdate.TabIndex = 17;
            this.btnModifyUpdate.Text = "Modificar";
            this.btnModifyUpdate.UseVisualStyleBackColor = true;
            this.btnModifyUpdate.Click += new System.EventHandler(this.btnModifyUpdate_Click);
            // 
            // cbItemEffect
            // 
            this.cbItemEffect.FormattingEnabled = true;
            this.cbItemEffect.Location = new System.Drawing.Point(26, 99);
            this.cbItemEffect.Name = "cbItemEffect";
            this.cbItemEffect.Size = new System.Drawing.Size(121, 21);
            this.cbItemEffect.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Efecto del Item";
            // 
            // cbKingdom
            // 
            this.cbKingdom.FormattingEnabled = true;
            this.cbKingdom.Location = new System.Drawing.Point(26, 51);
            this.cbKingdom.Name = "cbKingdom";
            this.cbKingdom.Size = new System.Drawing.Size(121, 21);
            this.cbKingdom.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Reino compatible (falta implementar)";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(295, 235);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdate.TabIndex = 22;
            this.btnCancelUpdate.Text = "Cancelar";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Id";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(108, 161);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 13);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "Valor";
            // 
            // ItemsCrudFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbKingdom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbItemEffect);
            this.Controls.Add(this.btnModifyUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateItem);
            this.Controls.Add(this.dgvItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsCrudFormTest";
            this.Text = "ItemsCrudFormTest";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModifyUpdate;
        private System.Windows.Forms.ComboBox cbItemEffect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbKingdom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bsItems;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblId;
    }
}