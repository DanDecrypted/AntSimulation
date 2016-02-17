namespace AntSimulation
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tmrWorld = new System.Windows.Forms.Timer(this.components);
            this.pnlWorld = new System.Windows.Forms.Panel();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.grpKey = new System.Windows.Forms.GroupBox();
            this.lblOrangeNest = new System.Windows.Forms.Label();
            this.pboOrangeNest = new System.Windows.Forms.PictureBox();
            this.pboOrangeAnt = new System.Windows.Forms.PictureBox();
            this.pboOrangeAntFood = new System.Windows.Forms.PictureBox();
            this.lblOrangeAnts = new System.Windows.Forms.Label();
            this.lblOrangeAntsFood = new System.Windows.Forms.Label();
            this.lblBlueNest = new System.Windows.Forms.Label();
            this.pboBlueNest = new System.Windows.Forms.PictureBox();
            this.pboBlueAnt = new System.Windows.Forms.PictureBox();
            this.pboBlueAntFood = new System.Windows.Forms.PictureBox();
            this.lblBlueAnts = new System.Windows.Forms.Label();
            this.lblBlueAntsFood = new System.Windows.Forms.Label();
            this.lblCivilianNest = new System.Windows.Forms.Label();
            this.lblRedNest = new System.Windows.Forms.Label();
            this.pboCivilianNest = new System.Windows.Forms.PictureBox();
            this.pboRedNest = new System.Windows.Forms.PictureBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.pboRedAnt = new System.Windows.Forms.PictureBox();
            this.lblCivilainsFood = new System.Windows.Forms.Label();
            this.pboRedAntFood = new System.Windows.Forms.PictureBox();
            this.lblCivilians = new System.Windows.Forms.Label();
            this.lblRedAnts = new System.Windows.Forms.Label();
            this.pboFood = new System.Windows.Forms.PictureBox();
            this.lblRedAntsFood = new System.Windows.Forms.Label();
            this.pboCiviliansFood = new System.Windows.Forms.PictureBox();
            this.pboCivilains = new System.Windows.Forms.PictureBox();
            this.grpDropBase = new System.Windows.Forms.GroupBox();
            this.rdoOrange = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblCivilianStats = new System.Windows.Forms.Label();
            this.lblRedStats = new System.Windows.Forms.Label();
            this.lblBlueStats = new System.Windows.Forms.Label();
            this.lblOrangeStats = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            this.grpKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboOrangeNest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboOrangeAnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboOrangeAntFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBlueNest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBlueAnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBlueAntFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCivilianNest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRedNest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRedAnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRedAntFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCiviliansFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCivilains)).BeginInit();
            this.grpDropBase.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrWorld
            // 
            this.tmrWorld.Tick += new System.EventHandler(this.tmrWorld_Tick);
            // 
            // pnlWorld
            // 
            this.pnlWorld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorld.BackColor = System.Drawing.Color.White;
            this.pnlWorld.Location = new System.Drawing.Point(0, 0);
            this.pnlWorld.Name = "pnlWorld";
            this.pnlWorld.Size = new System.Drawing.Size(605, 637);
            this.pnlWorld.TabIndex = 0;
            this.pnlWorld.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelWorld_MouseClick);
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSettings.Controls.Add(this.grpStats);
            this.grpSettings.Controls.Add(this.grpKey);
            this.grpSettings.Controls.Add(this.grpDropBase);
            this.grpSettings.Location = new System.Drawing.Point(604, 0);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(174, 637);
            this.grpSettings.TabIndex = 1;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // grpKey
            // 
            this.grpKey.Controls.Add(this.lblOrangeNest);
            this.grpKey.Controls.Add(this.pboOrangeNest);
            this.grpKey.Controls.Add(this.pboOrangeAnt);
            this.grpKey.Controls.Add(this.pboOrangeAntFood);
            this.grpKey.Controls.Add(this.lblOrangeAnts);
            this.grpKey.Controls.Add(this.lblOrangeAntsFood);
            this.grpKey.Controls.Add(this.lblBlueNest);
            this.grpKey.Controls.Add(this.pboBlueNest);
            this.grpKey.Controls.Add(this.pboBlueAnt);
            this.grpKey.Controls.Add(this.pboBlueAntFood);
            this.grpKey.Controls.Add(this.lblBlueAnts);
            this.grpKey.Controls.Add(this.lblBlueAntsFood);
            this.grpKey.Controls.Add(this.lblCivilianNest);
            this.grpKey.Controls.Add(this.lblRedNest);
            this.grpKey.Controls.Add(this.pboCivilianNest);
            this.grpKey.Controls.Add(this.pboRedNest);
            this.grpKey.Controls.Add(this.lblFood);
            this.grpKey.Controls.Add(this.pboRedAnt);
            this.grpKey.Controls.Add(this.lblCivilainsFood);
            this.grpKey.Controls.Add(this.pboRedAntFood);
            this.grpKey.Controls.Add(this.lblCivilians);
            this.grpKey.Controls.Add(this.lblRedAnts);
            this.grpKey.Controls.Add(this.pboFood);
            this.grpKey.Controls.Add(this.lblRedAntsFood);
            this.grpKey.Controls.Add(this.pboCiviliansFood);
            this.grpKey.Controls.Add(this.pboCivilains);
            this.grpKey.Location = new System.Drawing.Point(7, 139);
            this.grpKey.Name = "grpKey";
            this.grpKey.Size = new System.Drawing.Size(167, 357);
            this.grpKey.TabIndex = 1;
            this.grpKey.TabStop = false;
            this.grpKey.Text = "Key";
            // 
            // lblOrangeNest
            // 
            this.lblOrangeNest.AutoSize = true;
            this.lblOrangeNest.Location = new System.Drawing.Point(32, 286);
            this.lblOrangeNest.Name = "lblOrangeNest";
            this.lblOrangeNest.Size = new System.Drawing.Size(110, 13);
            this.lblOrangeNest.TabIndex = 25;
            this.lblOrangeNest.Text = "Orange Robbers Nest";
            // 
            // pboOrangeNest
            // 
            this.pboOrangeNest.BackColor = System.Drawing.Color.Transparent;
            this.pboOrangeNest.Image = ((System.Drawing.Image)(resources.GetObject("pboOrangeNest.Image")));
            this.pboOrangeNest.Location = new System.Drawing.Point(6, 279);
            this.pboOrangeNest.Name = "pboOrangeNest";
            this.pboOrangeNest.Size = new System.Drawing.Size(20, 20);
            this.pboOrangeNest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboOrangeNest.TabIndex = 24;
            this.pboOrangeNest.TabStop = false;
            // 
            // pboOrangeAnt
            // 
            this.pboOrangeAnt.BackColor = System.Drawing.Color.Red;
            this.pboOrangeAnt.Image = ((System.Drawing.Image)(resources.GetObject("pboOrangeAnt.Image")));
            this.pboOrangeAnt.Location = new System.Drawing.Point(6, 305);
            this.pboOrangeAnt.Name = "pboOrangeAnt";
            this.pboOrangeAnt.Size = new System.Drawing.Size(20, 20);
            this.pboOrangeAnt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboOrangeAnt.TabIndex = 20;
            this.pboOrangeAnt.TabStop = false;
            // 
            // pboOrangeAntFood
            // 
            this.pboOrangeAntFood.BackColor = System.Drawing.Color.Pink;
            this.pboOrangeAntFood.Image = ((System.Drawing.Image)(resources.GetObject("pboOrangeAntFood.Image")));
            this.pboOrangeAntFood.Location = new System.Drawing.Point(6, 331);
            this.pboOrangeAntFood.Name = "pboOrangeAntFood";
            this.pboOrangeAntFood.Size = new System.Drawing.Size(20, 20);
            this.pboOrangeAntFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboOrangeAntFood.TabIndex = 21;
            this.pboOrangeAntFood.TabStop = false;
            // 
            // lblOrangeAnts
            // 
            this.lblOrangeAnts.AutoSize = true;
            this.lblOrangeAnts.Location = new System.Drawing.Point(32, 312);
            this.lblOrangeAnts.Name = "lblOrangeAnts";
            this.lblOrangeAnts.Size = new System.Drawing.Size(85, 13);
            this.lblOrangeAnts.TabIndex = 22;
            this.lblOrangeAnts.Text = "Orange Robbers";
            // 
            // lblOrangeAntsFood
            // 
            this.lblOrangeAntsFood.AutoSize = true;
            this.lblOrangeAntsFood.Location = new System.Drawing.Point(32, 338);
            this.lblOrangeAntsFood.Name = "lblOrangeAntsFood";
            this.lblOrangeAntsFood.Size = new System.Drawing.Size(131, 13);
            this.lblOrangeAntsFood.TabIndex = 23;
            this.lblOrangeAntsFood.Text = "Orange Robbers with food";
            // 
            // lblBlueNest
            // 
            this.lblBlueNest.AutoSize = true;
            this.lblBlueNest.Location = new System.Drawing.Point(32, 208);
            this.lblBlueNest.Name = "lblBlueNest";
            this.lblBlueNest.Size = new System.Drawing.Size(96, 13);
            this.lblBlueNest.TabIndex = 19;
            this.lblBlueNest.Text = "Blue Robbers Nest";
            // 
            // pboBlueNest
            // 
            this.pboBlueNest.BackColor = System.Drawing.Color.Transparent;
            this.pboBlueNest.Image = ((System.Drawing.Image)(resources.GetObject("pboBlueNest.Image")));
            this.pboBlueNest.Location = new System.Drawing.Point(6, 201);
            this.pboBlueNest.Name = "pboBlueNest";
            this.pboBlueNest.Size = new System.Drawing.Size(20, 20);
            this.pboBlueNest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboBlueNest.TabIndex = 18;
            this.pboBlueNest.TabStop = false;
            // 
            // pboBlueAnt
            // 
            this.pboBlueAnt.BackColor = System.Drawing.Color.Red;
            this.pboBlueAnt.Image = ((System.Drawing.Image)(resources.GetObject("pboBlueAnt.Image")));
            this.pboBlueAnt.Location = new System.Drawing.Point(6, 227);
            this.pboBlueAnt.Name = "pboBlueAnt";
            this.pboBlueAnt.Size = new System.Drawing.Size(20, 20);
            this.pboBlueAnt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboBlueAnt.TabIndex = 14;
            this.pboBlueAnt.TabStop = false;
            // 
            // pboBlueAntFood
            // 
            this.pboBlueAntFood.BackColor = System.Drawing.Color.Pink;
            this.pboBlueAntFood.Image = ((System.Drawing.Image)(resources.GetObject("pboBlueAntFood.Image")));
            this.pboBlueAntFood.Location = new System.Drawing.Point(6, 253);
            this.pboBlueAntFood.Name = "pboBlueAntFood";
            this.pboBlueAntFood.Size = new System.Drawing.Size(20, 20);
            this.pboBlueAntFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboBlueAntFood.TabIndex = 15;
            this.pboBlueAntFood.TabStop = false;
            // 
            // lblBlueAnts
            // 
            this.lblBlueAnts.AutoSize = true;
            this.lblBlueAnts.Location = new System.Drawing.Point(32, 234);
            this.lblBlueAnts.Name = "lblBlueAnts";
            this.lblBlueAnts.Size = new System.Drawing.Size(71, 13);
            this.lblBlueAnts.TabIndex = 16;
            this.lblBlueAnts.Text = "Blue Robbers";
            // 
            // lblBlueAntsFood
            // 
            this.lblBlueAntsFood.AutoSize = true;
            this.lblBlueAntsFood.Location = new System.Drawing.Point(32, 260);
            this.lblBlueAntsFood.Name = "lblBlueAntsFood";
            this.lblBlueAntsFood.Size = new System.Drawing.Size(117, 13);
            this.lblBlueAntsFood.TabIndex = 17;
            this.lblBlueAntsFood.Text = "Blue Robbers with food";
            // 
            // lblCivilianNest
            // 
            this.lblCivilianNest.AutoSize = true;
            this.lblCivilianNest.Location = new System.Drawing.Point(32, 26);
            this.lblCivilianNest.Name = "lblCivilianNest";
            this.lblCivilianNest.Size = new System.Drawing.Size(70, 13);
            this.lblCivilianNest.TabIndex = 13;
            this.lblCivilianNest.Text = "Civilians Nest";
            // 
            // lblRedNest
            // 
            this.lblRedNest.AutoSize = true;
            this.lblRedNest.Location = new System.Drawing.Point(33, 130);
            this.lblRedNest.Name = "lblRedNest";
            this.lblRedNest.Size = new System.Drawing.Size(95, 13);
            this.lblRedNest.TabIndex = 12;
            this.lblRedNest.Text = "Red Robbers Nest";
            // 
            // pboCivilianNest
            // 
            this.pboCivilianNest.BackColor = System.Drawing.Color.Transparent;
            this.pboCivilianNest.Image = ((System.Drawing.Image)(resources.GetObject("pboCivilianNest.Image")));
            this.pboCivilianNest.Location = new System.Drawing.Point(6, 19);
            this.pboCivilianNest.Name = "pboCivilianNest";
            this.pboCivilianNest.Size = new System.Drawing.Size(20, 20);
            this.pboCivilianNest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboCivilianNest.TabIndex = 10;
            this.pboCivilianNest.TabStop = false;
            // 
            // pboRedNest
            // 
            this.pboRedNest.BackColor = System.Drawing.Color.Transparent;
            this.pboRedNest.Image = ((System.Drawing.Image)(resources.GetObject("pboRedNest.Image")));
            this.pboRedNest.Location = new System.Drawing.Point(7, 123);
            this.pboRedNest.Name = "pboRedNest";
            this.pboRedNest.Size = new System.Drawing.Size(20, 20);
            this.pboRedNest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboRedNest.TabIndex = 11;
            this.pboRedNest.TabStop = false;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(32, 104);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(61, 13);
            this.lblFood.TabIndex = 9;
            this.lblFood.Text = "Food depot";
            // 
            // pboRedAnt
            // 
            this.pboRedAnt.BackColor = System.Drawing.Color.Red;
            this.pboRedAnt.Image = ((System.Drawing.Image)(resources.GetObject("pboRedAnt.Image")));
            this.pboRedAnt.Location = new System.Drawing.Point(7, 149);
            this.pboRedAnt.Name = "pboRedAnt";
            this.pboRedAnt.Size = new System.Drawing.Size(20, 20);
            this.pboRedAnt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboRedAnt.TabIndex = 0;
            this.pboRedAnt.TabStop = false;
            // 
            // lblCivilainsFood
            // 
            this.lblCivilainsFood.AutoSize = true;
            this.lblCivilainsFood.Location = new System.Drawing.Point(32, 78);
            this.lblCivilainsFood.Name = "lblCivilainsFood";
            this.lblCivilainsFood.Size = new System.Drawing.Size(91, 13);
            this.lblCivilainsFood.TabIndex = 8;
            this.lblCivilainsFood.Text = "Civilians with food";
            // 
            // pboRedAntFood
            // 
            this.pboRedAntFood.BackColor = System.Drawing.Color.Pink;
            this.pboRedAntFood.Image = ((System.Drawing.Image)(resources.GetObject("pboRedAntFood.Image")));
            this.pboRedAntFood.Location = new System.Drawing.Point(7, 175);
            this.pboRedAntFood.Name = "pboRedAntFood";
            this.pboRedAntFood.Size = new System.Drawing.Size(20, 20);
            this.pboRedAntFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboRedAntFood.TabIndex = 1;
            this.pboRedAntFood.TabStop = false;
            // 
            // lblCivilians
            // 
            this.lblCivilians.AutoSize = true;
            this.lblCivilians.Location = new System.Drawing.Point(32, 52);
            this.lblCivilians.Name = "lblCivilians";
            this.lblCivilians.Size = new System.Drawing.Size(45, 13);
            this.lblCivilians.TabIndex = 7;
            this.lblCivilians.Text = "Civilians";
            // 
            // lblRedAnts
            // 
            this.lblRedAnts.AutoSize = true;
            this.lblRedAnts.Location = new System.Drawing.Point(33, 156);
            this.lblRedAnts.Name = "lblRedAnts";
            this.lblRedAnts.Size = new System.Drawing.Size(70, 13);
            this.lblRedAnts.TabIndex = 5;
            this.lblRedAnts.Text = "Red Robbers";
            // 
            // pboFood
            // 
            this.pboFood.BackColor = System.Drawing.Color.Lime;
            this.pboFood.Image = ((System.Drawing.Image)(resources.GetObject("pboFood.Image")));
            this.pboFood.Location = new System.Drawing.Point(6, 97);
            this.pboFood.Name = "pboFood";
            this.pboFood.Size = new System.Drawing.Size(20, 20);
            this.pboFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFood.TabIndex = 4;
            this.pboFood.TabStop = false;
            // 
            // lblRedAntsFood
            // 
            this.lblRedAntsFood.AutoSize = true;
            this.lblRedAntsFood.Location = new System.Drawing.Point(33, 182);
            this.lblRedAntsFood.Name = "lblRedAntsFood";
            this.lblRedAntsFood.Size = new System.Drawing.Size(116, 13);
            this.lblRedAntsFood.TabIndex = 6;
            this.lblRedAntsFood.Text = "Red Robbers with food";
            // 
            // pboCiviliansFood
            // 
            this.pboCiviliansFood.BackColor = System.Drawing.Color.SkyBlue;
            this.pboCiviliansFood.Image = ((System.Drawing.Image)(resources.GetObject("pboCiviliansFood.Image")));
            this.pboCiviliansFood.Location = new System.Drawing.Point(6, 71);
            this.pboCiviliansFood.Name = "pboCiviliansFood";
            this.pboCiviliansFood.Size = new System.Drawing.Size(20, 20);
            this.pboCiviliansFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboCiviliansFood.TabIndex = 3;
            this.pboCiviliansFood.TabStop = false;
            // 
            // pboCivilains
            // 
            this.pboCivilains.BackColor = System.Drawing.Color.Blue;
            this.pboCivilains.Image = ((System.Drawing.Image)(resources.GetObject("pboCivilains.Image")));
            this.pboCivilains.Location = new System.Drawing.Point(6, 45);
            this.pboCivilains.Name = "pboCivilains";
            this.pboCivilains.Size = new System.Drawing.Size(20, 20);
            this.pboCivilains.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboCivilains.TabIndex = 2;
            this.pboCivilains.TabStop = false;
            // 
            // grpDropBase
            // 
            this.grpDropBase.Controls.Add(this.rdoOrange);
            this.grpDropBase.Controls.Add(this.rdoBlue);
            this.grpDropBase.Controls.Add(this.rdoRed);
            this.grpDropBase.Controls.Add(this.rdoYellow);
            this.grpDropBase.Location = new System.Drawing.Point(7, 20);
            this.grpDropBase.Name = "grpDropBase";
            this.grpDropBase.Size = new System.Drawing.Size(161, 113);
            this.grpDropBase.TabIndex = 0;
            this.grpDropBase.TabStop = false;
            this.grpDropBase.Text = "Drop base for";
            // 
            // rdoOrange
            // 
            this.rdoOrange.AutoSize = true;
            this.rdoOrange.Location = new System.Drawing.Point(7, 91);
            this.rdoOrange.Name = "rdoOrange";
            this.rdoOrange.Size = new System.Drawing.Size(60, 17);
            this.rdoOrange.TabIndex = 3;
            this.rdoOrange.Text = "Orange";
            this.rdoOrange.UseVisualStyleBackColor = true;
            this.rdoOrange.CheckedChanged += new System.EventHandler(this.radioBaseDrop_CheckChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(7, 67);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(46, 17);
            this.rdoBlue.TabIndex = 2;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.radioBaseDrop_CheckChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(7, 44);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(45, 17);
            this.rdoRed.TabIndex = 1;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.radioBaseDrop_CheckChanged);
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.Checked = true;
            this.rdoYellow.Location = new System.Drawing.Point(7, 20);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(56, 17);
            this.rdoYellow.TabIndex = 0;
            this.rdoYellow.TabStop = true;
            this.rdoYellow.Text = "Yellow";
            this.rdoYellow.UseVisualStyleBackColor = true;
            this.rdoYellow.CheckedChanged += new System.EventHandler(this.radioBaseDrop_CheckChanged);
            // 
            // grpStats
            // 
            this.grpStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStats.Controls.Add(this.lblOrangeStats);
            this.grpStats.Controls.Add(this.lblBlueStats);
            this.grpStats.Controls.Add(this.lblRedStats);
            this.grpStats.Controls.Add(this.lblCivilianStats);
            this.grpStats.Location = new System.Drawing.Point(8, 502);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(161, 74);
            this.grpStats.TabIndex = 2;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stats";
            // 
            // lblCivilianStats
            // 
            this.lblCivilianStats.AutoSize = true;
            this.lblCivilianStats.Location = new System.Drawing.Point(6, 16);
            this.lblCivilianStats.Name = "lblCivilianStats";
            this.lblCivilianStats.Size = new System.Drawing.Size(74, 13);
            this.lblCivilianStats.TabIndex = 0;
            this.lblCivilianStats.Text = "lblCivilianStats";
            // 
            // lblRedStats
            // 
            this.lblRedStats.AutoSize = true;
            this.lblRedStats.Location = new System.Drawing.Point(6, 29);
            this.lblRedStats.Name = "lblRedStats";
            this.lblRedStats.Size = new System.Drawing.Size(61, 13);
            this.lblRedStats.TabIndex = 1;
            this.lblRedStats.Text = "lblRedStats";
            // 
            // lblBlueStats
            // 
            this.lblBlueStats.AutoSize = true;
            this.lblBlueStats.Location = new System.Drawing.Point(6, 42);
            this.lblBlueStats.Name = "lblBlueStats";
            this.lblBlueStats.Size = new System.Drawing.Size(62, 13);
            this.lblBlueStats.TabIndex = 2;
            this.lblBlueStats.Text = "lblBlueStats";
            // 
            // lblOrangeStats
            // 
            this.lblOrangeStats.AutoSize = true;
            this.lblOrangeStats.Location = new System.Drawing.Point(6, 55);
            this.lblOrangeStats.Name = "lblOrangeStats";
            this.lblOrangeStats.Size = new System.Drawing.Size(76, 13);
            this.lblOrangeStats.TabIndex = 3;
            this.lblOrangeStats.Text = "lblOrangeStats";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 637);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.pnlWorld);
            this.Name = "FrmMain";
            this.Text = "AntSimulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.LocationChanged += new System.EventHandler(this.FrmMain_LocationChanged);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.grpSettings.ResumeLayout(false);
            this.grpKey.ResumeLayout(false);
            this.grpKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboOrangeNest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboOrangeAnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboOrangeAntFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBlueNest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBlueAnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBlueAntFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCivilianNest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRedNest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRedAnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRedAntFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCiviliansFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCivilains)).EndInit();
            this.grpDropBase.ResumeLayout(false);
            this.grpDropBase.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrWorld;
        private System.Windows.Forms.Panel pnlWorld;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.GroupBox grpDropBase;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoYellow;
        private System.Windows.Forms.GroupBox grpKey;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblCivilainsFood;
        private System.Windows.Forms.Label lblCivilians;
        private System.Windows.Forms.Label lblRedAntsFood;
        private System.Windows.Forms.Label lblRedAnts;
        private System.Windows.Forms.PictureBox pboFood;
        private System.Windows.Forms.PictureBox pboCiviliansFood;
        private System.Windows.Forms.PictureBox pboCivilains;
        private System.Windows.Forms.PictureBox pboRedAntFood;
        private System.Windows.Forms.PictureBox pboRedAnt;
        private System.Windows.Forms.Label lblCivilianNest;
        private System.Windows.Forms.Label lblRedNest;
        private System.Windows.Forms.PictureBox pboRedNest;
        private System.Windows.Forms.PictureBox pboCivilianNest;
        private System.Windows.Forms.RadioButton rdoOrange;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.Label lblOrangeNest;
        private System.Windows.Forms.PictureBox pboOrangeNest;
        private System.Windows.Forms.PictureBox pboOrangeAnt;
        private System.Windows.Forms.PictureBox pboOrangeAntFood;
        private System.Windows.Forms.Label lblOrangeAnts;
        private System.Windows.Forms.Label lblOrangeAntsFood;
        private System.Windows.Forms.Label lblBlueNest;
        private System.Windows.Forms.PictureBox pboBlueNest;
        private System.Windows.Forms.PictureBox pboBlueAnt;
        private System.Windows.Forms.PictureBox pboBlueAntFood;
        private System.Windows.Forms.Label lblBlueAnts;
        private System.Windows.Forms.Label lblBlueAntsFood;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblRedStats;
        private System.Windows.Forms.Label lblCivilianStats;
        private System.Windows.Forms.Label lblBlueStats;
        private System.Windows.Forms.Label lblOrangeStats;
    }
}

