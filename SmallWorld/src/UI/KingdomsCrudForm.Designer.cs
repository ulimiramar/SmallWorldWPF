namespace SmallWorld.src.UI
{
    partial class KingdomsCrudForm
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
            this.txtKingdomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateKingdom = new System.Windows.Forms.Button();
            this.btnDeleteKingdom = new System.Windows.Forms.Button();
            this.btnUpdateKingdom = new System.Windows.Forms.Button();
            this.dgvKingdoms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKingdoms)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKingdomName
            // 
            this.txtKingdomName.Location = new System.Drawing.Point(40, 63);
            this.txtKingdomName.Name = "txtKingdomName";
            this.txtKingdomName.Size = new System.Drawing.Size(100, 20);
            this.txtKingdomName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Reino";
            // 
            // btnCreateKingdom
            // 
            this.btnCreateKingdom.Location = new System.Drawing.Point(40, 98);
            this.btnCreateKingdom.Name = "btnCreateKingdom";
            this.btnCreateKingdom.Size = new System.Drawing.Size(75, 23);
            this.btnCreateKingdom.TabIndex = 2;
            this.btnCreateKingdom.Text = "Crear";
            this.btnCreateKingdom.UseVisualStyleBackColor = true;
            this.btnCreateKingdom.Click += new System.EventHandler(this.btnCreateKingdom_Click);
            // 
            // btnDeleteKingdom
            // 
            this.btnDeleteKingdom.Location = new System.Drawing.Point(40, 145);
            this.btnDeleteKingdom.Name = "btnDeleteKingdom";
            this.btnDeleteKingdom.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteKingdom.TabIndex = 3;
            this.btnDeleteKingdom.Text = "Eliminar";
            this.btnDeleteKingdom.UseVisualStyleBackColor = true;
            this.btnDeleteKingdom.Click += new System.EventHandler(this.btnDeleteKingdom_Click);
            // 
            // btnUpdateKingdom
            // 
            this.btnUpdateKingdom.Location = new System.Drawing.Point(40, 191);
            this.btnUpdateKingdom.Name = "btnUpdateKingdom";
            this.btnUpdateKingdom.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateKingdom.TabIndex = 4;
            this.btnUpdateKingdom.Text = "Modificar";
            this.btnUpdateKingdom.UseVisualStyleBackColor = true;
            // 
            // dgvKingdoms
            // 
            this.dgvKingdoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKingdoms.Location = new System.Drawing.Point(209, 63);
            this.dgvKingdoms.Name = "dgvKingdoms";
            this.dgvKingdoms.Size = new System.Drawing.Size(240, 150);
            this.dgvKingdoms.TabIndex = 5;
            // 
            // KingdomsCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKingdoms);
            this.Controls.Add(this.btnUpdateKingdom);
            this.Controls.Add(this.btnDeleteKingdom);
            this.Controls.Add(this.btnCreateKingdom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKingdomName);
            this.Name = "KingdomsCrudForm";
            this.Text = "KingdomsCrud";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKingdoms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKingdomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateKingdom;
        private System.Windows.Forms.Button btnDeleteKingdom;
        private System.Windows.Forms.Button btnUpdateKingdom;
        private System.Windows.Forms.DataGridView dgvKingdoms;
    }
}