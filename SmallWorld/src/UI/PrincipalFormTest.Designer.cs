namespace SmallWorld.src.UI
{
    partial class PrincipalFormTest
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAttackPointsCurrentPlayerEntity = new System.Windows.Forms.Label();
            this.lblDefensePointsCurrentPlayerEntity = new System.Windows.Forms.Label();
            this.lblCurrentEnergyCurrentPlayerEntity = new System.Windows.Forms.Label();
            this.pbAttackPointsCurrentPlayerEntity = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCurrentLifeCurrentPlayerEntity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCurrentPlayerEntities = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbDefensePointsCurrentPlayerEntity = new System.Windows.Forms.ProgressBar();
            this.pbCurrentEnergyCurrentPlayerEntity = new System.Windows.Forms.ProgressBar();
            this.pbCurrentLifeCurrentPlayerEntity = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAttackPointsWaitingPlayerEntity = new System.Windows.Forms.Label();
            this.lblDefensePointsWaitingPlayerEntity = new System.Windows.Forms.Label();
            this.lblCurrentEnergyWaitingPlayerEntity = new System.Windows.Forms.Label();
            this.lblCurrentLifeWaitingPlayerEntity = new System.Windows.Forms.Label();
            this.pbAttackPointsWaitingPlayerEntity = new System.Windows.Forms.ProgressBar();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbWaitingPlayersEntities = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbCurrentEnergyWaitingPlayerEntity = new System.Windows.Forms.ProgressBar();
            this.pbDefensePointsWaitingPlayerEntity = new System.Windows.Forms.ProgressBar();
            this.pbCurrentLifeWaitingPlayerEntity = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.cbBorderingLands = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbLands = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnInteract = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.bsCurrentPlayerEntities = new System.Windows.Forms.BindingSource(this.components);
            this.bsWaitingPlayersEntities = new System.Windows.Forms.BindingSource(this.components);
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.bsFoods = new System.Windows.Forms.BindingSource(this.components);
            this.btnGenerateMap = new System.Windows.Forms.Button();
            this.bsLands = new System.Windows.Forms.BindingSource(this.components);
            this.bsBorderingLands = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrentPlayerEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWaitingPlayersEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBorderingLands)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(38, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(91, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entidades";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAttackPointsCurrentPlayerEntity);
            this.panel1.Controls.Add(this.lblDefensePointsCurrentPlayerEntity);
            this.panel1.Controls.Add(this.lblCurrentEnergyCurrentPlayerEntity);
            this.panel1.Controls.Add(this.pbAttackPointsCurrentPlayerEntity);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lblCurrentLifeCurrentPlayerEntity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbCurrentPlayerEntities);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pbDefensePointsCurrentPlayerEntity);
            this.panel1.Controls.Add(this.pbCurrentEnergyCurrentPlayerEntity);
            this.panel1.Controls.Add(this.pbCurrentLifeCurrentPlayerEntity);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 261);
            this.panel1.TabIndex = 2;
            // 
            // lblAttackPointsCurrentPlayerEntity
            // 
            this.lblAttackPointsCurrentPlayerEntity.AutoSize = true;
            this.lblAttackPointsCurrentPlayerEntity.Location = new System.Drawing.Point(128, 199);
            this.lblAttackPointsCurrentPlayerEntity.Name = "lblAttackPointsCurrentPlayerEntity";
            this.lblAttackPointsCurrentPlayerEntity.Size = new System.Drawing.Size(31, 13);
            this.lblAttackPointsCurrentPlayerEntity.TabIndex = 12;
            this.lblAttackPointsCurrentPlayerEntity.Text = "Valor";
            // 
            // lblDefensePointsCurrentPlayerEntity
            // 
            this.lblDefensePointsCurrentPlayerEntity.AutoSize = true;
            this.lblDefensePointsCurrentPlayerEntity.Location = new System.Drawing.Point(128, 156);
            this.lblDefensePointsCurrentPlayerEntity.Name = "lblDefensePointsCurrentPlayerEntity";
            this.lblDefensePointsCurrentPlayerEntity.Size = new System.Drawing.Size(31, 13);
            this.lblDefensePointsCurrentPlayerEntity.TabIndex = 11;
            this.lblDefensePointsCurrentPlayerEntity.Text = "Valor";
            // 
            // lblCurrentEnergyCurrentPlayerEntity
            // 
            this.lblCurrentEnergyCurrentPlayerEntity.AutoSize = true;
            this.lblCurrentEnergyCurrentPlayerEntity.Location = new System.Drawing.Point(128, 114);
            this.lblCurrentEnergyCurrentPlayerEntity.Name = "lblCurrentEnergyCurrentPlayerEntity";
            this.lblCurrentEnergyCurrentPlayerEntity.Size = new System.Drawing.Size(31, 13);
            this.lblCurrentEnergyCurrentPlayerEntity.TabIndex = 10;
            this.lblCurrentEnergyCurrentPlayerEntity.Text = "Valor";
            // 
            // pbAttackPointsCurrentPlayerEntity
            // 
            this.pbAttackPointsCurrentPlayerEntity.Location = new System.Drawing.Point(22, 199);
            this.pbAttackPointsCurrentPlayerEntity.Name = "pbAttackPointsCurrentPlayerEntity";
            this.pbAttackPointsCurrentPlayerEntity.Size = new System.Drawing.Size(100, 23);
            this.pbAttackPointsCurrentPlayerEntity.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Puntos de Ataque";
            // 
            // lblCurrentLifeCurrentPlayerEntity
            // 
            this.lblCurrentLifeCurrentPlayerEntity.AutoSize = true;
            this.lblCurrentLifeCurrentPlayerEntity.Location = new System.Drawing.Point(128, 82);
            this.lblCurrentLifeCurrentPlayerEntity.Name = "lblCurrentLifeCurrentPlayerEntity";
            this.lblCurrentLifeCurrentPlayerEntity.Size = new System.Drawing.Size(31, 13);
            this.lblCurrentLifeCurrentPlayerEntity.TabIndex = 7;
            this.lblCurrentLifeCurrentPlayerEntity.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tus entidades";
            // 
            // cbCurrentPlayerEntities
            // 
            this.cbCurrentPlayerEntities.FormattingEnabled = true;
            this.cbCurrentPlayerEntities.Location = new System.Drawing.Point(22, 23);
            this.cbCurrentPlayerEntities.Name = "cbCurrentPlayerEntities";
            this.cbCurrentPlayerEntities.Size = new System.Drawing.Size(121, 21);
            this.cbCurrentPlayerEntities.TabIndex = 6;
            this.cbCurrentPlayerEntities.SelectedIndexChanged += new System.EventHandler(this.cbSelectMyEntity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Puntos de Defensa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Energía Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vida Actual";
            // 
            // pbDefensePointsCurrentPlayerEntity
            // 
            this.pbDefensePointsCurrentPlayerEntity.Location = new System.Drawing.Point(22, 156);
            this.pbDefensePointsCurrentPlayerEntity.Name = "pbDefensePointsCurrentPlayerEntity";
            this.pbDefensePointsCurrentPlayerEntity.Size = new System.Drawing.Size(100, 23);
            this.pbDefensePointsCurrentPlayerEntity.TabIndex = 3;
            // 
            // pbCurrentEnergyCurrentPlayerEntity
            // 
            this.pbCurrentEnergyCurrentPlayerEntity.Location = new System.Drawing.Point(22, 114);
            this.pbCurrentEnergyCurrentPlayerEntity.Name = "pbCurrentEnergyCurrentPlayerEntity";
            this.pbCurrentEnergyCurrentPlayerEntity.Size = new System.Drawing.Size(100, 23);
            this.pbCurrentEnergyCurrentPlayerEntity.TabIndex = 3;
            // 
            // pbCurrentLifeCurrentPlayerEntity
            // 
            this.pbCurrentLifeCurrentPlayerEntity.Location = new System.Drawing.Point(22, 72);
            this.pbCurrentLifeCurrentPlayerEntity.Name = "pbCurrentLifeCurrentPlayerEntity";
            this.pbCurrentLifeCurrentPlayerEntity.Size = new System.Drawing.Size(100, 23);
            this.pbCurrentLifeCurrentPlayerEntity.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Terreno Seleccionado";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAttackPointsWaitingPlayerEntity);
            this.panel2.Controls.Add(this.lblDefensePointsWaitingPlayerEntity);
            this.panel2.Controls.Add(this.lblCurrentEnergyWaitingPlayerEntity);
            this.panel2.Controls.Add(this.lblCurrentLifeWaitingPlayerEntity);
            this.panel2.Controls.Add(this.pbAttackPointsWaitingPlayerEntity);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbWaitingPlayersEntities);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pbCurrentEnergyWaitingPlayerEntity);
            this.panel2.Controls.Add(this.pbDefensePointsWaitingPlayerEntity);
            this.panel2.Controls.Add(this.pbCurrentLifeWaitingPlayerEntity);
            this.panel2.Location = new System.Drawing.Point(386, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 261);
            this.panel2.TabIndex = 4;
            // 
            // lblAttackPointsWaitingPlayerEntity
            // 
            this.lblAttackPointsWaitingPlayerEntity.AutoSize = true;
            this.lblAttackPointsWaitingPlayerEntity.Location = new System.Drawing.Point(122, 199);
            this.lblAttackPointsWaitingPlayerEntity.Name = "lblAttackPointsWaitingPlayerEntity";
            this.lblAttackPointsWaitingPlayerEntity.Size = new System.Drawing.Size(31, 13);
            this.lblAttackPointsWaitingPlayerEntity.TabIndex = 16;
            this.lblAttackPointsWaitingPlayerEntity.Text = "Valor";
            // 
            // lblDefensePointsWaitingPlayerEntity
            // 
            this.lblDefensePointsWaitingPlayerEntity.AutoSize = true;
            this.lblDefensePointsWaitingPlayerEntity.Location = new System.Drawing.Point(122, 156);
            this.lblDefensePointsWaitingPlayerEntity.Name = "lblDefensePointsWaitingPlayerEntity";
            this.lblDefensePointsWaitingPlayerEntity.Size = new System.Drawing.Size(31, 13);
            this.lblDefensePointsWaitingPlayerEntity.TabIndex = 15;
            this.lblDefensePointsWaitingPlayerEntity.Text = "Valor";
            // 
            // lblCurrentEnergyWaitingPlayerEntity
            // 
            this.lblCurrentEnergyWaitingPlayerEntity.AutoSize = true;
            this.lblCurrentEnergyWaitingPlayerEntity.Location = new System.Drawing.Point(122, 114);
            this.lblCurrentEnergyWaitingPlayerEntity.Name = "lblCurrentEnergyWaitingPlayerEntity";
            this.lblCurrentEnergyWaitingPlayerEntity.Size = new System.Drawing.Size(31, 13);
            this.lblCurrentEnergyWaitingPlayerEntity.TabIndex = 14;
            this.lblCurrentEnergyWaitingPlayerEntity.Text = "Valor";
            // 
            // lblCurrentLifeWaitingPlayerEntity
            // 
            this.lblCurrentLifeWaitingPlayerEntity.AutoSize = true;
            this.lblCurrentLifeWaitingPlayerEntity.Location = new System.Drawing.Point(122, 72);
            this.lblCurrentLifeWaitingPlayerEntity.Name = "lblCurrentLifeWaitingPlayerEntity";
            this.lblCurrentLifeWaitingPlayerEntity.Size = new System.Drawing.Size(31, 13);
            this.lblCurrentLifeWaitingPlayerEntity.TabIndex = 13;
            this.lblCurrentLifeWaitingPlayerEntity.Text = "Valor";
            // 
            // pbAttackPointsWaitingPlayerEntity
            // 
            this.pbAttackPointsWaitingPlayerEntity.Location = new System.Drawing.Point(17, 199);
            this.pbAttackPointsWaitingPlayerEntity.Name = "pbAttackPointsWaitingPlayerEntity";
            this.pbAttackPointsWaitingPlayerEntity.Size = new System.Drawing.Size(100, 23);
            this.pbAttackPointsWaitingPlayerEntity.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Puntos de Ataque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Puntos de Defensa";
            // 
            // cbWaitingPlayersEntities
            // 
            this.cbWaitingPlayersEntities.FormattingEnabled = true;
            this.cbWaitingPlayersEntities.Location = new System.Drawing.Point(16, 22);
            this.cbWaitingPlayersEntities.Name = "cbWaitingPlayersEntities";
            this.cbWaitingPlayersEntities.Size = new System.Drawing.Size(121, 21);
            this.cbWaitingPlayersEntities.TabIndex = 1;
            this.cbWaitingPlayersEntities.SelectedIndexChanged += new System.EventHandler(this.cbSelectEntityFromOtherUser_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Energía Actual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Entidades en este terreno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Vida Actual";
            // 
            // pbCurrentEnergyWaitingPlayerEntity
            // 
            this.pbCurrentEnergyWaitingPlayerEntity.Location = new System.Drawing.Point(16, 114);
            this.pbCurrentEnergyWaitingPlayerEntity.Name = "pbCurrentEnergyWaitingPlayerEntity";
            this.pbCurrentEnergyWaitingPlayerEntity.Size = new System.Drawing.Size(100, 23);
            this.pbCurrentEnergyWaitingPlayerEntity.TabIndex = 10;
            // 
            // pbDefensePointsWaitingPlayerEntity
            // 
            this.pbDefensePointsWaitingPlayerEntity.Location = new System.Drawing.Point(16, 156);
            this.pbDefensePointsWaitingPlayerEntity.Name = "pbDefensePointsWaitingPlayerEntity";
            this.pbDefensePointsWaitingPlayerEntity.Size = new System.Drawing.Size(100, 23);
            this.pbDefensePointsWaitingPlayerEntity.TabIndex = 9;
            // 
            // pbCurrentLifeWaitingPlayerEntity
            // 
            this.pbCurrentLifeWaitingPlayerEntity.Location = new System.Drawing.Point(16, 72);
            this.pbCurrentLifeWaitingPlayerEntity.Name = "pbCurrentLifeWaitingPlayerEntity";
            this.pbCurrentLifeWaitingPlayerEntity.Size = new System.Drawing.Size(100, 23);
            this.pbCurrentLifeWaitingPlayerEntity.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Mapa";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.cbBorderingLands);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.cbLands);
            this.panel3.Location = new System.Drawing.Point(194, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 261);
            this.panel3.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Terrenos Limítrofes";
            // 
            // cbBorderingLands
            // 
            this.cbBorderingLands.FormattingEnabled = true;
            this.cbBorderingLands.Location = new System.Drawing.Point(28, 129);
            this.cbBorderingLands.Name = "cbBorderingLands";
            this.cbBorderingLands.Size = new System.Drawing.Size(121, 21);
            this.cbBorderingLands.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Terreno";
            // 
            // cbLands
            // 
            this.cbLands.FormattingEnabled = true;
            this.cbLands.Location = new System.Drawing.Point(28, 56);
            this.cbLands.Name = "cbLands";
            this.cbLands.Size = new System.Drawing.Size(121, 21);
            this.cbLands.TabIndex = 0;
            this.cbLands.SelectedIndexChanged += new System.EventHandler(this.cbLands_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(568, 73);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(454, 375);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 8;
            this.btnAttack.Text = "Atacar";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnInteract
            // 
            this.btnInteract.Location = new System.Drawing.Point(640, 375);
            this.btnInteract.Name = "btnInteract";
            this.btnInteract.Size = new System.Drawing.Size(75, 23);
            this.btnInteract.TabIndex = 14;
            this.btnInteract.Text = "Interactuar";
            this.btnInteract.UseVisualStyleBackColor = true;
            this.btnInteract.Click += new System.EventHandler(this.btnInteract_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.cbItems);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(570, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 261);
            this.panel4.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Comida en este terreno";
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(16, 115);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 21);
            this.cbFood.TabIndex = 3;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Info del item";
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(16, 22);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 21);
            this.cbItems.TabIndex = 1;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Items en este terreno";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(250, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Mover";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Location = new System.Drawing.Point(154, 12);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(107, 23);
            this.btnRefreshData.TabIndex = 16;
            this.btnRefreshData.Text = "Refrescar Datos";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(59, 375);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(75, 23);
            this.btnRest.TabIndex = 17;
            this.btnRest.Text = "Descansar";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnGenerateMap
            // 
            this.btnGenerateMap.Location = new System.Drawing.Point(250, 71);
            this.btnGenerateMap.Name = "btnGenerateMap";
            this.btnGenerateMap.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateMap.TabIndex = 18;
            this.btnGenerateMap.Text = "Generar";
            this.btnGenerateMap.UseVisualStyleBackColor = true;
            this.btnGenerateMap.Click += new System.EventHandler(this.btnGenerateMap_Click);
            // 
            // PrincipalFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerateMap);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnRefreshData);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnInteract);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalFormTest";
            this.Text = "PincipalFormTest";
            this.Load += new System.EventHandler(this.PrincipalFormTest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrentPlayerEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWaitingPlayersEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBorderingLands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCurrentPlayerEntities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbDefensePointsCurrentPlayerEntity;
        private System.Windows.Forms.ProgressBar pbCurrentEnergyCurrentPlayerEntity;
        private System.Windows.Forms.ProgressBar pbCurrentLifeCurrentPlayerEntity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbWaitingPlayersEntities;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar pbCurrentEnergyWaitingPlayerEntity;
        private System.Windows.Forms.ProgressBar pbDefensePointsWaitingPlayerEntity;
        private System.Windows.Forms.ProgressBar pbCurrentLifeWaitingPlayerEntity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnInteract;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bsCurrentPlayerEntities;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.BindingSource bsWaitingPlayersEntities;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Label lblCurrentLifeCurrentPlayerEntity;
        private System.Windows.Forms.ProgressBar pbAttackPointsCurrentPlayerEntity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ProgressBar pbAttackPointsWaitingPlayerEntity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAttackPointsCurrentPlayerEntity;
        private System.Windows.Forms.Label lblDefensePointsCurrentPlayerEntity;
        private System.Windows.Forms.Label lblCurrentEnergyCurrentPlayerEntity;
        private System.Windows.Forms.Label lblAttackPointsWaitingPlayerEntity;
        private System.Windows.Forms.Label lblDefensePointsWaitingPlayerEntity;
        private System.Windows.Forms.Label lblCurrentEnergyWaitingPlayerEntity;
        private System.Windows.Forms.Label lblCurrentLifeWaitingPlayerEntity;
        private System.Windows.Forms.BindingSource bsItems;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.BindingSource bsFoods;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbBorderingLands;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbLands;
        private System.Windows.Forms.Button btnGenerateMap;
        private System.Windows.Forms.BindingSource bsLands;
        private System.Windows.Forms.BindingSource bsBorderingLands;
    }
}