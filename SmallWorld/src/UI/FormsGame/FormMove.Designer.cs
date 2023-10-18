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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLands = new System.Windows.Forms.DataGridView();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.NumLand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerrainType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLands)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLands
            // 
            this.dgvLands.AllowUserToAddRows = false;
            this.dgvLands.AllowUserToDeleteRows = false;
            this.dgvLands.AllowUserToResizeColumns = false;
            this.dgvLands.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvLands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLands.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.dgvLands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLands.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumLand,
            this.TerrainType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLands.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLands.EnableHeadersVisualStyles = false;
            this.dgvLands.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvLands.Location = new System.Drawing.Point(12, 12);
            this.dgvLands.MultiSelect = false;
            this.dgvLands.Name = "dgvLands";
            this.dgvLands.ReadOnly = true;
            this.dgvLands.RowHeadersVisible = false;
            this.dgvLands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLands.Size = new System.Drawing.Size(460, 159);
            this.dgvLands.TabIndex = 79;
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btnMove.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnMove.FlatAppearance.BorderSize = 4;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.Color.Orange;
            this.btnMove.Location = new System.Drawing.Point(12, 177);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(228, 49);
            this.btnMove.TabIndex = 80;
            this.btnMove.Text = "Mover";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnCancel.FlatAppearance.BorderSize = 4;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Orange;
            this.btnCancel.Location = new System.Drawing.Point(238, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(234, 49);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NumLand
            // 
            this.NumLand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumLand.HeaderText = "Número de Tierra";
            this.NumLand.Name = "NumLand";
            this.NumLand.ReadOnly = true;
            // 
            // TerrainType
            // 
            this.TerrainType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TerrainType.HeaderText = "Tipo de Terreno";
            this.TerrainType.Name = "TerrainType";
            this.TerrainType.ReadOnly = true;
            // 
            // FormMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(484, 226);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.dgvLands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMove";
            this.Text = "Mover";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLands)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLands;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLand;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerrainType;
    }
}