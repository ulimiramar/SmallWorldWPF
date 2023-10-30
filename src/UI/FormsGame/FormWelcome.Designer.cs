namespace SmallWorld.src.UI.Game
{
    partial class FormWelcome
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
            btnPlay = new Button();
            btnOptions = new Button();
            btnExit = new Button();
            btnCodeView = new Button();
            btnInstructions = new Button();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.DarkGoldenrod;
            btnPlay.FlatAppearance.BorderColor = Color.Bisque;
            btnPlay.FlatAppearance.BorderSize = 4;
            btnPlay.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(287, 120);
            btnPlay.Margin = new Padding(4, 3, 4, 3);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(164, 44);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Jugar";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnOptions
            // 
            btnOptions.BackColor = Color.DarkGoldenrod;
            btnOptions.FlatAppearance.BorderColor = Color.Bisque;
            btnOptions.FlatAppearance.BorderSize = 4;
            btnOptions.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnOptions.FlatStyle = FlatStyle.Flat;
            btnOptions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOptions.ForeColor = Color.White;
            btnOptions.Location = new Point(287, 171);
            btnOptions.Margin = new Padding(4, 3, 4, 3);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(164, 44);
            btnOptions.TabIndex = 1;
            btnOptions.Text = "Opciones";
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += btnOptions_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGoldenrod;
            btnExit.FlatAppearance.BorderColor = Color.Bisque;
            btnExit.FlatAppearance.BorderSize = 4;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(287, 322);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(164, 44);
            btnExit.TabIndex = 2;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCodeView
            // 
            btnCodeView.BackColor = Color.DarkGoldenrod;
            btnCodeView.FlatAppearance.BorderColor = Color.Bisque;
            btnCodeView.FlatAppearance.BorderSize = 4;
            btnCodeView.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnCodeView.FlatStyle = FlatStyle.Flat;
            btnCodeView.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCodeView.ForeColor = Color.White;
            btnCodeView.Location = new Point(287, 271);
            btnCodeView.Margin = new Padding(4, 3, 4, 3);
            btnCodeView.Name = "btnCodeView";
            btnCodeView.Size = new Size(164, 44);
            btnCodeView.TabIndex = 4;
            btnCodeView.Text = "Ver Código";
            btnCodeView.UseVisualStyleBackColor = false;
            btnCodeView.Click += btnCodeView_Click;
            // 
            // btnInstructions
            // 
            btnInstructions.BackColor = Color.DarkGoldenrod;
            btnInstructions.FlatAppearance.BorderColor = Color.Bisque;
            btnInstructions.FlatAppearance.BorderSize = 4;
            btnInstructions.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnInstructions.FlatStyle = FlatStyle.Flat;
            btnInstructions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInstructions.ForeColor = Color.White;
            btnInstructions.Location = new Point(287, 220);
            btnInstructions.Margin = new Padding(4, 3, 4, 3);
            btnInstructions.Name = "btnInstructions";
            btnInstructions.Size = new Size(164, 44);
            btnInstructions.TabIndex = 8;
            btnInstructions.Text = "Instrucciones";
            btnInstructions.UseVisualStyleBackColor = false;
            btnInstructions.Click += btnInstructions_Click;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.cover;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(520, 519);
            Controls.Add(btnInstructions);
            Controls.Add(btnCodeView);
            Controls.Add(btnExit);
            Controls.Add(btnOptions);
            Controls.Add(btnPlay);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormWelcome";
            ShowIcon = false;
            Text = "Bienvenido";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Button btnOptions;
        private Button btnExit;
        private Button btnCodeView;
        private Button btnInstructions;
    }
}