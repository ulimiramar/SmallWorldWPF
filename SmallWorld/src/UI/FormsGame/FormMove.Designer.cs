namespace SmallWorld.src.UI.FormsGame
{
    partial class FormMove
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLands = new System.Windows.Forms.DataGridView();
            this.NumLand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerrainType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLands)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLands
            // 
            this.dgvLands.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvLands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLands.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvLands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLands.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumLand,
            this.TerrainType});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLands.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLands.EnableHeadersVisualStyles = false;
            this.dgvLands.GridColor = System.Drawing.Color.LavenderBlush;
            this.dgvLands.Location = new System.Drawing.Point(0, -3);
            this.dgvLands.MultiSelect = false;
            this.dgvLands.Name = "dgvLands";
            this.dgvLands.ReadOnly = true;
            this.dgvLands.RowHeadersVisible = false;
            this.dgvLands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLands.Size = new System.Drawing.Size(488, 184);
            this.dgvLands.TabIndex = 79;
            // 
            // NumLand
            // 
            this.NumLand.HeaderText = "Número de Tierra";
            this.NumLand.Name = "NumLand";
            this.NumLand.ReadOnly = true;
            this.NumLand.Width = 50;
            // 
            // TerrainType
            // 
            this.TerrainType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TerrainType.HeaderText = "Tipo de Terreno";
            this.TerrainType.Name = "TerrainType";
            this.TerrainType.ReadOnly = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(0, 177);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(240, 49);
            this.btnMove.TabIndex = 80;
            this.btnMove.Text = "Mover";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(250, 49);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 226);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.dgvLands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMove";
            this.Text = "FormMove";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLands)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLands;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLand;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerrainType;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnCancel;
    }
}