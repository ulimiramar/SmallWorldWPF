namespace SmallWorld.src.UI
{
    partial class TestForm
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
            this.btnCreateEntity = new System.Windows.Forms.Button();
            this.cbKingdom = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDiet = new System.Windows.Forms.ComboBox();
            this.cbHabitat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAttack = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDefense = new System.Windows.Forms.TrackBar();
            this.lblAttackPoints = new System.Windows.Forms.Label();
            this.lblDefensePoints = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEntities = new System.Windows.Forms.DataGridView();
            this.cbSelectAttackEntity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSelectDefenseEntity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.dgvWarResults = new System.Windows.Forms.DataGridView();
            this.btnCreateMap = new System.Windows.Forms.Button();
            this.btnShowMap = new System.Windows.Forms.Button();
            this.panelMap = new System.Windows.Forms.Panel();
            this.btnOpenKingdomCrudForm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAttackPoints = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDefensePoints = new System.Windows.Forms.TextBox();
            this.chbAttackRange = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaxLife = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaxEnergy = new System.Windows.Forms.TextBox();
            this.btnRest = new System.Windows.Forms.Button();
            this.cbSelectUniqueEntity = new System.Windows.Forms.ComboBox();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnInteract = new System.Windows.Forms.Button();
            this.btnItemsCRUD = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEat = new System.Windows.Forms.Button();
            this.btnFoodsCRUD = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDefenseShield = new System.Windows.Forms.TextBox();
            this.pbCurrentLife = new System.Windows.Forms.ProgressBar();
            this.pbDefenseShield = new System.Windows.Forms.ProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pbCurrentEnergy = new System.Windows.Forms.ProgressBar();
            this.iKingdomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vegetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vegetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vegetableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKingdomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateEntity
            // 
            this.btnCreateEntity.Location = new System.Drawing.Point(58, 190);
            this.btnCreateEntity.Name = "btnCreateEntity";
            this.btnCreateEntity.Size = new System.Drawing.Size(197, 23);
            this.btnCreateEntity.TabIndex = 0;
            this.btnCreateEntity.Text = "Crear Entidad";
            this.btnCreateEntity.UseVisualStyleBackColor = true;
            this.btnCreateEntity.Click += new System.EventHandler(this.btnCreateEntity_Click);
            // 
            // cbKingdom
            // 
            this.cbKingdom.FormattingEnabled = true;
            this.cbKingdom.Location = new System.Drawing.Point(234, 51);
            this.cbKingdom.Name = "cbKingdom";
            this.cbKingdom.Size = new System.Drawing.Size(121, 21);
            this.cbKingdom.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Entidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dieta";
            // 
            // cbDiet
            // 
            this.cbDiet.FormattingEnabled = true;
            this.cbDiet.Location = new System.Drawing.Point(462, 51);
            this.cbDiet.Name = "cbDiet";
            this.cbDiet.Size = new System.Drawing.Size(121, 21);
            this.cbDiet.TabIndex = 7;
            // 
            // cbHabitat
            // 
            this.cbHabitat.FormattingEnabled = true;
            this.cbHabitat.Location = new System.Drawing.Point(462, 18);
            this.cbHabitat.Name = "cbHabitat";
            this.cbHabitat.Size = new System.Drawing.Size(121, 21);
            this.cbHabitat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Habitat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fuerza de Ataque";
            // 
            // tbAttack
            // 
            this.tbAttack.LargeChange = 10;
            this.tbAttack.Location = new System.Drawing.Point(132, 598);
            this.tbAttack.Maximum = 90;
            this.tbAttack.Minimum = 10;
            this.tbAttack.Name = "tbAttack";
            this.tbAttack.Size = new System.Drawing.Size(104, 45);
            this.tbAttack.SmallChange = 10;
            this.tbAttack.TabIndex = 11;
            this.tbAttack.Value = 10;
            this.tbAttack.Scroll += new System.EventHandler(this.tbAttack_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Escudo de Defensa";
            // 
            // tbDefense
            // 
            this.tbDefense.Enabled = false;
            this.tbDefense.LargeChange = 10;
            this.tbDefense.Location = new System.Drawing.Point(440, 598);
            this.tbDefense.Maximum = 100;
            this.tbDefense.Name = "tbDefense";
            this.tbDefense.Size = new System.Drawing.Size(104, 45);
            this.tbDefense.SmallChange = 10;
            this.tbDefense.TabIndex = 13;
            this.tbDefense.Value = 90;
            // 
            // lblAttackPoints
            // 
            this.lblAttackPoints.AutoSize = true;
            this.lblAttackPoints.Location = new System.Drawing.Point(38, 615);
            this.lblAttackPoints.Name = "lblAttackPoints";
            this.lblAttackPoints.Size = new System.Drawing.Size(31, 13);
            this.lblAttackPoints.TabIndex = 14;
            this.lblAttackPoints.Text = "Valor";
            // 
            // lblDefensePoints
            // 
            this.lblDefensePoints.AutoSize = true;
            this.lblDefensePoints.Location = new System.Drawing.Point(318, 615);
            this.lblDefensePoints.Name = "lblDefensePoints";
            this.lblDefensePoints.Size = new System.Drawing.Size(31, 13);
            this.lblDefensePoints.TabIndex = 15;
            this.lblDefensePoints.Text = "Valor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Mostrar Entidades Por Consola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEntities
            // 
            this.dgvEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntities.Location = new System.Drawing.Point(282, 190);
            this.dgvEntities.Name = "dgvEntities";
            this.dgvEntities.Size = new System.Drawing.Size(416, 150);
            this.dgvEntities.TabIndex = 18;
            // 
            // cbSelectAttackEntity
            // 
            this.cbSelectAttackEntity.FormattingEnabled = true;
            this.cbSelectAttackEntity.Location = new System.Drawing.Point(58, 376);
            this.cbSelectAttackEntity.Name = "cbSelectAttackEntity";
            this.cbSelectAttackEntity.Size = new System.Drawing.Size(121, 21);
            this.cbSelectAttackEntity.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Seleccionar Entidad Atacante";
            // 
            // cbSelectDefenseEntity
            // 
            this.cbSelectDefenseEntity.FormattingEnabled = true;
            this.cbSelectDefenseEntity.Location = new System.Drawing.Point(247, 376);
            this.cbSelectDefenseEntity.Name = "cbSelectDefenseEntity";
            this.cbSelectDefenseEntity.Size = new System.Drawing.Size(121, 21);
            this.cbSelectDefenseEntity.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Seleccionar Entidad a Atacar";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(394, 374);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 23;
            this.btnAttack.Text = "Atacar";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // dgvWarResults
            // 
            this.dgvWarResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarResults.Location = new System.Drawing.Point(576, 351);
            this.dgvWarResults.Name = "dgvWarResults";
            this.dgvWarResults.Size = new System.Drawing.Size(279, 150);
            this.dgvWarResults.TabIndex = 24;
            // 
            // btnCreateMap
            // 
            this.btnCreateMap.Location = new System.Drawing.Point(875, 66);
            this.btnCreateMap.Name = "btnCreateMap";
            this.btnCreateMap.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMap.TabIndex = 26;
            this.btnCreateMap.Text = "Crear Mapa";
            this.btnCreateMap.UseVisualStyleBackColor = true;
            this.btnCreateMap.Click += new System.EventHandler(this.btnCreateMap_Click);
            // 
            // btnShowMap
            // 
            this.btnShowMap.Location = new System.Drawing.Point(978, 66);
            this.btnShowMap.Name = "btnShowMap";
            this.btnShowMap.Size = new System.Drawing.Size(112, 23);
            this.btnShowMap.TabIndex = 27;
            this.btnShowMap.Text = "Mostrar Mapa";
            this.btnShowMap.UseVisualStyleBackColor = true;
            this.btnShowMap.Click += new System.EventHandler(this.btnShowMap_Click);
            // 
            // panelMap
            // 
            this.panelMap.Location = new System.Drawing.Point(875, 98);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(310, 331);
            this.panelMap.TabIndex = 28;
            // 
            // btnOpenKingdomCrudForm
            // 
            this.btnOpenKingdomCrudForm.Location = new System.Drawing.Point(32, 649);
            this.btnOpenKingdomCrudForm.Name = "btnOpenKingdomCrudForm";
            this.btnOpenKingdomCrudForm.Size = new System.Drawing.Size(156, 23);
            this.btnOpenKingdomCrudForm.TabIndex = 29;
            this.btnOpenKingdomCrudForm.Text = "CRUD Reinos";
            this.btnOpenKingdomCrudForm.UseVisualStyleBackColor = true;
            this.btnOpenKingdomCrudForm.Click += new System.EventHandler(this.btnOpenKingdomCrudForm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Puntos de ataque";
            // 
            // txtAttackPoints
            // 
            this.txtAttackPoints.Location = new System.Drawing.Point(234, 95);
            this.txtAttackPoints.Name = "txtAttackPoints";
            this.txtAttackPoints.Size = new System.Drawing.Size(100, 20);
            this.txtAttackPoints.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Puntos de Defensa";
            // 
            // txtDefensePoints
            // 
            this.txtDefensePoints.Location = new System.Drawing.Point(534, 98);
            this.txtDefensePoints.Name = "txtDefensePoints";
            this.txtDefensePoints.Size = new System.Drawing.Size(100, 20);
            this.txtDefensePoints.TabIndex = 33;
            // 
            // chbAttackRange
            // 
            this.chbAttackRange.AutoSize = true;
            this.chbAttackRange.Location = new System.Drawing.Point(644, 55);
            this.chbAttackRange.Name = "chbAttackRange";
            this.chbAttackRange.Size = new System.Drawing.Size(172, 17);
            this.chbAttackRange.TabIndex = 34;
            this.chbAttackRange.Text = "Habilidad de atacar a distancia";
            this.chbAttackRange.UseVisualStyleBackColor = true;
            this.chbAttackRange.CheckedChanged += new System.EventHandler(this.chbAttackRange_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 568);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Cosas que fui descartando";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(140, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Vida Máxima";
            // 
            // txtMaxLife
            // 
            this.txtMaxLife.Location = new System.Drawing.Point(234, 132);
            this.txtMaxLife.Name = "txtMaxLife";
            this.txtMaxLife.Size = new System.Drawing.Size(100, 20);
            this.txtMaxLife.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(419, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Energía máxima";
            // 
            // txtMaxEnergy
            // 
            this.txtMaxEnergy.Location = new System.Drawing.Point(534, 138);
            this.txtMaxEnergy.Name = "txtMaxEnergy";
            this.txtMaxEnergy.Size = new System.Drawing.Size(100, 20);
            this.txtMaxEnergy.TabIndex = 39;
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(41, 454);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(75, 23);
            this.btnRest.TabIndex = 40;
            this.btnRest.Text = "Descansar";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // cbSelectUniqueEntity
            // 
            this.cbSelectUniqueEntity.FormattingEnabled = true;
            this.cbSelectUniqueEntity.Location = new System.Drawing.Point(41, 427);
            this.cbSelectUniqueEntity.Name = "cbSelectUniqueEntity";
            this.cbSelectUniqueEntity.Size = new System.Drawing.Size(121, 21);
            this.cbSelectUniqueEntity.TabIndex = 41;
            this.cbSelectUniqueEntity.SelectedIndexChanged += new System.EventHandler(this.cbSelectUniqueEntity_SelectedIndexChanged);
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(282, 427);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 21);
            this.cbItems.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 411);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Seleccionar una entidad para hacer algo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(282, 412);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Seleccionar un Item";
            // 
            // btnInteract
            // 
            this.btnInteract.Location = new System.Drawing.Point(282, 453);
            this.btnInteract.Name = "btnInteract";
            this.btnInteract.Size = new System.Drawing.Size(75, 23);
            this.btnInteract.TabIndex = 45;
            this.btnInteract.Text = "Interactuar";
            this.btnInteract.UseVisualStyleBackColor = true;
            // 
            // btnItemsCRUD
            // 
            this.btnItemsCRUD.Location = new System.Drawing.Point(282, 477);
            this.btnItemsCRUD.Name = "btnItemsCRUD";
            this.btnItemsCRUD.Size = new System.Drawing.Size(107, 23);
            this.btnItemsCRUD.TabIndex = 46;
            this.btnItemsCRUD.Text = "CRUD de items";
            this.btnItemsCRUD.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(428, 411);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Seleccionar un alimento";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(431, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // btnEat
            // 
            this.btnEat.Location = new System.Drawing.Point(431, 455);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(75, 23);
            this.btnEat.TabIndex = 49;
            this.btnEat.Text = "Comer";
            this.btnEat.UseVisualStyleBackColor = true;
            // 
            // btnFoodsCRUD
            // 
            this.btnFoodsCRUD.Location = new System.Drawing.Point(431, 478);
            this.btnFoodsCRUD.Name = "btnFoodsCRUD";
            this.btnFoodsCRUD.Size = new System.Drawing.Size(117, 23);
            this.btnFoodsCRUD.TabIndex = 50;
            this.btnFoodsCRUD.Text = "CRUD de alimentos";
            this.btnFoodsCRUD.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(696, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Puntos del Escudo de defensa";
            // 
            // txtDefenseShield
            // 
            this.txtDefenseShield.Location = new System.Drawing.Point(699, 114);
            this.txtDefenseShield.Name = "txtDefenseShield";
            this.txtDefenseShield.Size = new System.Drawing.Size(100, 20);
            this.txtDefenseShield.TabIndex = 52;
            // 
            // pbCurrentLife
            // 
            this.pbCurrentLife.BackColor = System.Drawing.Color.Red;
            this.pbCurrentLife.Location = new System.Drawing.Point(31, 510);
            this.pbCurrentLife.Name = "pbCurrentLife";
            this.pbCurrentLife.Size = new System.Drawing.Size(100, 23);
            this.pbCurrentLife.TabIndex = 53;
            // 
            // pbDefenseShield
            // 
            this.pbDefenseShield.Location = new System.Drawing.Point(171, 510);
            this.pbDefenseShield.Name = "pbDefenseShield";
            this.pbDefenseShield.Size = new System.Drawing.Size(100, 23);
            this.pbDefenseShield.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 491);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Vida Actual";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(171, 490);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "Escudo de Defensa";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(206, 551);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "Energía Actual";
            // 
            // pbCurrentEnergy
            // 
            this.pbCurrentEnergy.Location = new System.Drawing.Point(282, 541);
            this.pbCurrentEnergy.Name = "pbCurrentEnergy";
            this.pbCurrentEnergy.Size = new System.Drawing.Size(100, 23);
            this.pbCurrentEnergy.TabIndex = 58;
            // 
            // iKingdomBindingSource
            // 
            this.iKingdomBindingSource.DataSource = typeof(SmallWorld.src.Interfaces.IKingdom);
            // 
            // vegetableBindingSource
            // 
            this.vegetableBindingSource.DataSource = typeof(SmallWorld.src.Model.Reino.Vegetable);
            // 
            // vegetableBindingSource1
            // 
            this.vegetableBindingSource1.DataSource = typeof(SmallWorld.src.Model.Reino.Vegetable);
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(SmallWorld.src.Model.Reino.Animal);
            // 
            // vegetableBindingSource2
            // 
            this.vegetableBindingSource2.DataSource = typeof(SmallWorld.src.Model.Reino.Vegetable);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1212, 701);
            this.Controls.Add(this.pbCurrentEnergy);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pbDefenseShield);
            this.Controls.Add(this.pbCurrentLife);
            this.Controls.Add(this.txtDefenseShield);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnFoodsCRUD);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnItemsCRUD);
            this.Controls.Add(this.btnInteract);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.cbSelectUniqueEntity);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.txtMaxEnergy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMaxLife);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chbAttackRange);
            this.Controls.Add(this.txtDefensePoints);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAttackPoints);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnOpenKingdomCrudForm);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.btnShowMap);
            this.Controls.Add(this.btnCreateMap);
            this.Controls.Add(this.dgvWarResults);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSelectDefenseEntity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSelectAttackEntity);
            this.Controls.Add(this.dgvEntities);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDefensePoints);
            this.Controls.Add(this.lblAttackPoints);
            this.Controls.Add(this.tbDefense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAttack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHabitat);
            this.Controls.Add(this.cbDiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbKingdom);
            this.Controls.Add(this.btnCreateEntity);
            this.Name = "TestForm";
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKingdomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEntity;
        private System.Windows.Forms.ComboBox cbKingdom;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDiet;
        private System.Windows.Forms.ComboBox cbHabitat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbAttack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbDefense;
        private System.Windows.Forms.Label lblAttackPoints;
        private System.Windows.Forms.Label lblDefensePoints;
        private System.Windows.Forms.BindingSource vegetableBindingSource;
        private System.Windows.Forms.BindingSource vegetableBindingSource1;
        private System.Windows.Forms.BindingSource iKingdomBindingSource;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.BindingSource vegetableBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvEntities;
        private System.Windows.Forms.ComboBox cbSelectAttackEntity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSelectDefenseEntity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.DataGridView dgvWarResults;
        private System.Windows.Forms.Button btnCreateMap;
        private System.Windows.Forms.Button btnShowMap;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Button btnOpenKingdomCrudForm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAttackPoints;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDefensePoints;
        private System.Windows.Forms.CheckBox chbAttackRange;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaxLife;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaxEnergy;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.ComboBox cbSelectUniqueEntity;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnInteract;
        private System.Windows.Forms.Button btnItemsCRUD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.Button btnFoodsCRUD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDefenseShield;
        private System.Windows.Forms.ProgressBar pbCurrentLife;
        private System.Windows.Forms.ProgressBar pbDefenseShield;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ProgressBar pbCurrentEnergy;
    }
}