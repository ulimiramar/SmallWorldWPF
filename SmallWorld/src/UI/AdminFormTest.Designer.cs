namespace SmallWorld.src.UI
{
    partial class AdminFormTest
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
            this.btnEntitiesCrud = new System.Windows.Forms.Button();
            this.btnItemsCrud = new System.Windows.Forms.Button();
            this.btnFoodCrud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntitiesCrud
            // 
            this.btnEntitiesCrud.Location = new System.Drawing.Point(132, 194);
            this.btnEntitiesCrud.Name = "btnEntitiesCrud";
            this.btnEntitiesCrud.Size = new System.Drawing.Size(116, 23);
            this.btnEntitiesCrud.TabIndex = 0;
            this.btnEntitiesCrud.Text = "Crud Entidades";
            this.btnEntitiesCrud.UseVisualStyleBackColor = true;
            this.btnEntitiesCrud.Click += new System.EventHandler(this.btnEntitiesCrud_Click);
            // 
            // btnItemsCrud
            // 
            this.btnItemsCrud.Location = new System.Drawing.Point(298, 194);
            this.btnItemsCrud.Name = "btnItemsCrud";
            this.btnItemsCrud.Size = new System.Drawing.Size(116, 23);
            this.btnItemsCrud.TabIndex = 1;
            this.btnItemsCrud.Text = "Crud Items";
            this.btnItemsCrud.UseVisualStyleBackColor = true;
            this.btnItemsCrud.Click += new System.EventHandler(this.btnItemsCrud_Click);
            // 
            // btnFoodCrud
            // 
            this.btnFoodCrud.Location = new System.Drawing.Point(464, 194);
            this.btnFoodCrud.Name = "btnFoodCrud";
            this.btnFoodCrud.Size = new System.Drawing.Size(116, 23);
            this.btnFoodCrud.TabIndex = 2;
            this.btnFoodCrud.Text = "Crud Alimentos";
            this.btnFoodCrud.UseVisualStyleBackColor = true;
            this.btnFoodCrud.Click += new System.EventHandler(this.btnFoodCrud_Click);
            // 
            // AdminFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFoodCrud);
            this.Controls.Add(this.btnItemsCrud);
            this.Controls.Add(this.btnEntitiesCrud);
            this.Name = "AdminFormTest";
            this.Text = "AdminFormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntitiesCrud;
        private System.Windows.Forms.Button btnItemsCrud;
        private System.Windows.Forms.Button btnFoodCrud;
    }
}