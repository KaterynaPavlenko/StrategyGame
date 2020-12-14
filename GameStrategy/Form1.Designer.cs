using GameStrategy.Controller;

namespace GameStrategy
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureGameObject = new System.Windows.Forms.PictureBox();
            this.pictureBoxCastle = new System.Windows.Forms.PictureBox();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonTask = new System.Windows.Forms.Button();
            this.buttonShowBuildings = new System.Windows.Forms.Button();
            this.buttonShowArmy = new System.Windows.Forms.Button();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelTextLevel = new System.Windows.Forms.Label();
            this.labelCountPeople = new System.Windows.Forms.Label();
            this.labelTextCountPeople = new System.Windows.Forms.Label();
            this.labelCountCoin = new System.Windows.Forms.Label();
            this.labelTextCountCoin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxArmyAttack = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonAddShooterForAttck = new System.Windows.Forms.Button();
            this.buttonAddInfantrymanForAttack = new System.Windows.Forms.Button();
            this.buttonAddCavarlyForAttack = new System.Windows.Forms.Button();
            this.buttonAddRecruitForAttck = new System.Windows.Forms.Button();
            this.labelCavalryAttac = new System.Windows.Forms.Label();
            this.labelShooterAttac = new System.Windows.Forms.Label();
            this.labelInfantrymanAttac = new System.Windows.Forms.Label();
            this.labelRecruitAttac = new System.Windows.Forms.Label();
            this.groupBoxArmy = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.labelTrainedRecruit = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelRecruitInform = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddRecruit = new System.Windows.Forms.Button();
            this.labelRecruitText = new System.Windows.Forms.Label();
            this.labelRecruit = new System.Windows.Forms.Label();
            this.textBoxRecruit = new System.Windows.Forms.TextBox();
            this.labelRecruitCost = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label36 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.buttonAddInfantryman = new System.Windows.Forms.Button();
            this.labelInfantrymanText = new System.Windows.Forms.Label();
            this.labelInfantryman = new System.Windows.Forms.Label();
            this.textBoxInfantryman = new System.Windows.Forms.TextBox();
            this.labelInfantrymanCost = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label37 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.buttonAddCavalry = new System.Windows.Forms.Button();
            this.labelCavalryText = new System.Windows.Forms.Label();
            this.labelCavalryCost = new System.Windows.Forms.Label();
            this.labelCavalry = new System.Windows.Forms.Label();
            this.textBoxCavalry = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label38 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.buttonAddShooter = new System.Windows.Forms.Button();
            this.labelShooterText = new System.Windows.Forms.Label();
            this.labelShooter = new System.Windows.Forms.Label();
            this.labelShooterCost = new System.Windows.Forms.Label();
            this.textBoxShooter = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.groupBoxInformCastle = new System.Windows.Forms.GroupBox();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelDescriptionBuildings = new System.Windows.Forms.Label();
            this.labelLevelBuildings = new System.Windows.Forms.Label();
            this.labelLevelBuildingsText = new System.Windows.Forms.Label();
            this.buttonLevelUp = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelCostText = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelDescriptionBuildings2 = new System.Windows.Forms.Label();
            this.labelLevelBuildings2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelCost2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelDescriptionBuildings3 = new System.Windows.Forms.Label();
            this.labelLevelBuildings3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelCost3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelDescriptionBuildings4 = new System.Windows.Forms.Label();
            this.labelLevelBuildings4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.labelCost4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.labelDescriptionBuildings5 = new System.Windows.Forms.Label();
            this.labelLevelBuildings5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.labelCost5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.buttonTask3 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonTask2 = new System.Windows.Forms.Button();
            this.buttonTask1 = new System.Windows.Forms.Button();
            this.labelTask3 = new System.Windows.Forms.Label();
            this.labelTask2 = new System.Windows.Forms.Label();
            this.labelTask1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGameObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCastle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxArmyAttack.SuspendLayout();
            this.groupBoxArmy.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBoxInformCastle.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureGameObject);
            this.panel1.Controls.Add(this.pictureBoxCastle);
            this.panel1.Controls.Add(this.pictureBoxMap);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 810);
            this.panel1.TabIndex = 1;
            // 
            // pictureGameObject
            // 
            this.pictureGameObject.Location = new System.Drawing.Point(0, 0);
            this.pictureGameObject.Name = "pictureGameObject";
            this.pictureGameObject.Size = new System.Drawing.Size(4000, 4000);
            this.pictureGameObject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureGameObject.TabIndex = 3;
            this.pictureGameObject.TabStop = false;
            this.pictureGameObject.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureGameObject_Paint);
            this.pictureGameObject.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureGameObject_MouseDoubleClick);
            // 
            // pictureBoxCastle
            // 
            this.pictureBoxCastle.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCastle.MinimumSize = new System.Drawing.Size(1100, 809);
            this.pictureBoxCastle.Name = "pictureBoxCastle";
            this.pictureBoxCastle.Size = new System.Drawing.Size(1100, 809);
            this.pictureBoxCastle.TabIndex = 0;
            this.pictureBoxCastle.TabStop = false;
            this.pictureBoxCastle.Visible = false;
            this.pictureBoxCastle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCastle_MouseClick);
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(2400, 2400);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMap.TabIndex = 1;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMap_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-3, -10);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(1100, 809);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1100, 809);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMove);
            this.groupBox1.Controls.Add(this.buttonAttack);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.buttonTask);
            this.groupBox1.Controls.Add(this.buttonShowBuildings);
            this.groupBox1.Controls.Add(this.buttonShowArmy);
            this.groupBox1.Controls.Add(this.labelDay);
            this.groupBox1.Controls.Add(this.labelTextLevel);
            this.groupBox1.Controls.Add(this.labelCountPeople);
            this.groupBox1.Controls.Add(this.labelTextCountPeople);
            this.groupBox1.Controls.Add(this.labelCountCoin);
            this.groupBox1.Controls.Add(this.labelTextCountCoin);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBoxArmyAttack);
            this.groupBox1.Controls.Add(this.groupBoxArmy);
            this.groupBox1.Controls.Add(this.groupBoxInformCastle);
            this.groupBox1.Controls.Add(this.groupBoxTask);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(1122, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 810);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonMove.Image = global::GameStrategy.Properties.Resources.position_marker;
            this.buttonMove.Location = new System.Drawing.Point(165, 12);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(65, 65);
            this.buttonMove.TabIndex = 34;
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonAttack
            // 
            this.buttonAttack.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAttack.Image = global::GameStrategy.Properties.Resources.sword_clash;
            this.buttonAttack.Location = new System.Drawing.Point(94, 12);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(65, 65);
            this.buttonAttack.TabIndex = 33;
            this.buttonAttack.UseVisualStyleBackColor = false;
            this.buttonAttack.Visible = false;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlText;
            this.button6.Image = global::GameStrategy.Properties.Resources.sands_of_time;
            this.button6.Location = new System.Drawing.Point(383, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 19;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonTask
            // 
            this.buttonTask.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonTask.Image = global::GameStrategy.Properties.Resources.scroll_quill;
            this.buttonTask.Location = new System.Drawing.Point(175, 160);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(75, 75);
            this.buttonTask.TabIndex = 18;
            this.buttonTask.UseVisualStyleBackColor = false;
            this.buttonTask.Visible = false;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // buttonShowBuildings
            // 
            this.buttonShowBuildings.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonShowBuildings.Image = global::GameStrategy.Properties.Resources.medieval_gate;
            this.buttonShowBuildings.Location = new System.Drawing.Point(94, 160);
            this.buttonShowBuildings.Name = "buttonShowBuildings";
            this.buttonShowBuildings.Size = new System.Drawing.Size(75, 75);
            this.buttonShowBuildings.TabIndex = 17;
            this.buttonShowBuildings.UseVisualStyleBackColor = false;
            this.buttonShowBuildings.Visible = false;
            this.buttonShowBuildings.Click += new System.EventHandler(this.buttonShowBuildings_Click_1);
            // 
            // buttonShowArmy
            // 
            this.buttonShowArmy.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonShowArmy.Image = global::GameStrategy.Properties.Resources.rally_the_troops;
            this.buttonShowArmy.Location = new System.Drawing.Point(15, 160);
            this.buttonShowArmy.Name = "buttonShowArmy";
            this.buttonShowArmy.Size = new System.Drawing.Size(75, 75);
            this.buttonShowArmy.TabIndex = 16;
            this.buttonShowArmy.UseVisualStyleBackColor = false;
            this.buttonShowArmy.Click += new System.EventHandler(this.buttonShowArmy_Click);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(296, 44);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(37, 17);
            this.labelDay.TabIndex = 7;
            this.labelDay.Text = "level";
            // 
            // labelTextLevel
            // 
            this.labelTextLevel.AutoSize = true;
            this.labelTextLevel.Location = new System.Drawing.Point(277, 12);
            this.labelTextLevel.Name = "labelTextLevel";
            this.labelTextLevel.Size = new System.Drawing.Size(77, 17);
            this.labelTextLevel.TabIndex = 6;
            this.labelTextLevel.Text = "День(Ход)";
            // 
            // labelCountPeople
            // 
            this.labelCountPeople.AutoSize = true;
            this.labelCountPeople.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCountPeople.ForeColor = System.Drawing.Color.White;
            this.labelCountPeople.Location = new System.Drawing.Point(106, 124);
            this.labelCountPeople.Name = "labelCountPeople";
            this.labelCountPeople.Size = new System.Drawing.Size(90, 17);
            this.labelCountPeople.TabIndex = 5;
            this.labelCountPeople.Text = "count people";
            // 
            // labelTextCountPeople
            // 
            this.labelTextCountPeople.AutoSize = true;
            this.labelTextCountPeople.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTextCountPeople.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelTextCountPeople.Location = new System.Drawing.Point(24, 124);
            this.labelTextCountPeople.Name = "labelTextCountPeople";
            this.labelTextCountPeople.Size = new System.Drawing.Size(44, 17);
            this.labelTextCountPeople.TabIndex = 4;
            this.labelTextCountPeople.Text = "Люди";
            // 
            // labelCountCoin
            // 
            this.labelCountCoin.AutoSize = true;
            this.labelCountCoin.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelCountCoin.ForeColor = System.Drawing.Color.White;
            this.labelCountCoin.Location = new System.Drawing.Point(106, 89);
            this.labelCountCoin.Name = "labelCountCoin";
            this.labelCountCoin.Size = new System.Drawing.Size(77, 17);
            this.labelCountCoin.TabIndex = 3;
            this.labelCountCoin.Text = "Count Coin";
            // 
            // labelTextCountCoin
            // 
            this.labelTextCountCoin.AutoSize = true;
            this.labelTextCountCoin.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelTextCountCoin.ForeColor = System.Drawing.Color.White;
            this.labelTextCountCoin.Location = new System.Drawing.Point(24, 89);
            this.labelTextCountCoin.Name = "labelTextCountCoin";
            this.labelTextCountCoin.Size = new System.Drawing.Size(60, 17);
            this.labelTextCountCoin.TabIndex = 2;
            this.labelTextCountCoin.Text = "Монеты";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::GameStrategy.Properties.Resources.fast_backward_button;
            this.button1.Location = new System.Drawing.Point(15, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxArmyAttack
            // 
            this.groupBoxArmyAttack.Controls.Add(this.label39);
            this.groupBoxArmyAttack.Controls.Add(this.label21);
            this.groupBoxArmyAttack.Controls.Add(this.label19);
            this.groupBoxArmyAttack.Controls.Add(this.label13);
            this.groupBoxArmyAttack.Controls.Add(this.label15);
            this.groupBoxArmyAttack.Controls.Add(this.label17);
            this.groupBoxArmyAttack.Controls.Add(this.label18);
            this.groupBoxArmyAttack.Controls.Add(this.label5);
            this.groupBoxArmyAttack.Controls.Add(this.label7);
            this.groupBoxArmyAttack.Controls.Add(this.label9);
            this.groupBoxArmyAttack.Controls.Add(this.label11);
            this.groupBoxArmyAttack.Controls.Add(this.label3);
            this.groupBoxArmyAttack.Controls.Add(this.textBox1);
            this.groupBoxArmyAttack.Controls.Add(this.textBox2);
            this.groupBoxArmyAttack.Controls.Add(this.textBox3);
            this.groupBoxArmyAttack.Controls.Add(this.textBox4);
            this.groupBoxArmyAttack.Controls.Add(this.buttonAddShooterForAttck);
            this.groupBoxArmyAttack.Controls.Add(this.buttonAddInfantrymanForAttack);
            this.groupBoxArmyAttack.Controls.Add(this.buttonAddCavarlyForAttack);
            this.groupBoxArmyAttack.Controls.Add(this.buttonAddRecruitForAttck);
            this.groupBoxArmyAttack.Controls.Add(this.labelCavalryAttac);
            this.groupBoxArmyAttack.Controls.Add(this.labelShooterAttac);
            this.groupBoxArmyAttack.Controls.Add(this.labelInfantrymanAttac);
            this.groupBoxArmyAttack.Controls.Add(this.labelRecruitAttac);
            this.groupBoxArmyAttack.Location = new System.Drawing.Point(0, 241);
            this.groupBoxArmyAttack.Name = "groupBoxArmyAttack";
            this.groupBoxArmyAttack.Size = new System.Drawing.Size(454, 569);
            this.groupBoxArmyAttack.TabIndex = 32;
            this.groupBoxArmyAttack.TabStop = false;
            this.groupBoxArmyAttack.Text = "Армия";
            this.groupBoxArmyAttack.Visible = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(219, 34);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(118, 17);
            this.label39.TabIndex = 43;
            this.label39.Text = "Отправить в бой";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(38, 273);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 17);
            this.label21.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(127, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 17);
            this.label19.TabIndex = 40;
            this.label19.Text = "В замке";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = "Кавалерист";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(222, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "Стрелок";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(222, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "Пехотинец";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(219, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "Рекрут";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Кавалерист";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Стрелок";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Пехотинец";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Рекрут";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 22);
            this.textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 22);
            this.textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(322, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 22);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(322, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(45, 22);
            this.textBox4.TabIndex = 23;
            // 
            // buttonAddShooterForAttck
            // 
            this.buttonAddShooterForAttck.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddShooterForAttck.Image = global::GameStrategy.Properties.Resources.plus;
            this.buttonAddShooterForAttck.Location = new System.Drawing.Point(383, 156);
            this.buttonAddShooterForAttck.Name = "buttonAddShooterForAttck";
            this.buttonAddShooterForAttck.Size = new System.Drawing.Size(40, 40);
            this.buttonAddShooterForAttck.TabIndex = 22;
            this.buttonAddShooterForAttck.UseVisualStyleBackColor = false;
            this.buttonAddShooterForAttck.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonAddInfantrymanForAttack
            // 
            this.buttonAddInfantrymanForAttack.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddInfantrymanForAttack.Image = global::GameStrategy.Properties.Resources.plus;
            this.buttonAddInfantrymanForAttack.Location = new System.Drawing.Point(383, 105);
            this.buttonAddInfantrymanForAttack.Name = "buttonAddInfantrymanForAttack";
            this.buttonAddInfantrymanForAttack.Size = new System.Drawing.Size(40, 40);
            this.buttonAddInfantrymanForAttack.TabIndex = 21;
            this.buttonAddInfantrymanForAttack.UseVisualStyleBackColor = false;
            this.buttonAddInfantrymanForAttack.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonAddCavarlyForAttack
            // 
            this.buttonAddCavarlyForAttack.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddCavarlyForAttack.Image = global::GameStrategy.Properties.Resources.plus;
            this.buttonAddCavarlyForAttack.Location = new System.Drawing.Point(383, 205);
            this.buttonAddCavarlyForAttack.Name = "buttonAddCavarlyForAttack";
            this.buttonAddCavarlyForAttack.Size = new System.Drawing.Size(40, 40);
            this.buttonAddCavarlyForAttack.TabIndex = 20;
            this.buttonAddCavarlyForAttack.UseVisualStyleBackColor = false;
            this.buttonAddCavarlyForAttack.Click += new System.EventHandler(this.button12_Click);
            // 
            // buttonAddRecruitForAttck
            // 
            this.buttonAddRecruitForAttck.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddRecruitForAttck.Image = global::GameStrategy.Properties.Resources.plus;
            this.buttonAddRecruitForAttck.Location = new System.Drawing.Point(383, 58);
            this.buttonAddRecruitForAttck.Name = "buttonAddRecruitForAttck";
            this.buttonAddRecruitForAttck.Size = new System.Drawing.Size(40, 40);
            this.buttonAddRecruitForAttck.TabIndex = 19;
            this.buttonAddRecruitForAttck.UseVisualStyleBackColor = false;
            this.buttonAddRecruitForAttck.Click += new System.EventHandler(this.button13_Click);
            // 
            // labelCavalryAttac
            // 
            this.labelCavalryAttac.AutoSize = true;
            this.labelCavalryAttac.Location = new System.Drawing.Point(130, 213);
            this.labelCavalryAttac.Name = "labelCavalryAttac";
            this.labelCavalryAttac.Size = new System.Drawing.Size(86, 17);
            this.labelCavalryAttac.TabIndex = 13;
            this.labelCavalryAttac.Text = "Кавалерист";
            // 
            // labelShooterAttac
            // 
            this.labelShooterAttac.AutoSize = true;
            this.labelShooterAttac.Location = new System.Drawing.Point(130, 164);
            this.labelShooterAttac.Name = "labelShooterAttac";
            this.labelShooterAttac.Size = new System.Drawing.Size(63, 17);
            this.labelShooterAttac.TabIndex = 11;
            this.labelShooterAttac.Text = "Стрелок";
            // 
            // labelInfantrymanAttac
            // 
            this.labelInfantrymanAttac.AutoSize = true;
            this.labelInfantrymanAttac.Location = new System.Drawing.Point(130, 113);
            this.labelInfantrymanAttac.Name = "labelInfantrymanAttac";
            this.labelInfantrymanAttac.Size = new System.Drawing.Size(79, 17);
            this.labelInfantrymanAttac.TabIndex = 9;
            this.labelInfantrymanAttac.Text = "Пехотинец";
            // 
            // labelRecruitAttac
            // 
            this.labelRecruitAttac.AutoSize = true;
            this.labelRecruitAttac.Location = new System.Drawing.Point(127, 67);
            this.labelRecruitAttac.Name = "labelRecruitAttac";
            this.labelRecruitAttac.Size = new System.Drawing.Size(54, 17);
            this.labelRecruitAttac.TabIndex = 7;
            this.labelRecruitAttac.Text = "Рекрут";
            // 
            // groupBoxArmy
            // 
            this.groupBoxArmy.Controls.Add(this.tabControl1);
            this.groupBoxArmy.Controls.Add(this.labelError);
            this.groupBoxArmy.Location = new System.Drawing.Point(0, 241);
            this.groupBoxArmy.Name = "groupBoxArmy";
            this.groupBoxArmy.Size = new System.Drawing.Size(454, 569);
            this.groupBoxArmy.TabIndex = 15;
            this.groupBoxArmy.TabStop = false;
            this.groupBoxArmy.Text = "Армия";
            this.groupBoxArmy.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 535);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.labelTrainedRecruit);
            this.tabPage6.Controls.Add(this.label23);
            this.tabPage6.Controls.Add(this.labelRecruitInform);
            this.tabPage6.Controls.Add(this.label22);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.buttonAddRecruit);
            this.tabPage6.Controls.Add(this.labelRecruitText);
            this.tabPage6.Controls.Add(this.labelRecruit);
            this.tabPage6.Controls.Add(this.textBoxRecruit);
            this.tabPage6.Controls.Add(this.labelRecruitCost);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(450, 506);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Рекрут";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // labelTrainedRecruit
            // 
            this.labelTrainedRecruit.AutoSize = true;
            this.labelTrainedRecruit.Location = new System.Drawing.Point(157, 98);
            this.labelTrainedRecruit.Name = "labelTrainedRecruit";
            this.labelTrainedRecruit.Size = new System.Drawing.Size(131, 17);
            this.labelTrainedRecruit.TabIndex = 32;
            this.labelTrainedRecruit.Text = "Количество армии";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 17);
            this.label23.TabIndex = 31;
            this.label23.Text = "Количество армии";
            // 
            // labelRecruitInform
            // 
            this.labelRecruitInform.AutoSize = true;
            this.labelRecruitInform.Location = new System.Drawing.Point(20, 138);
            this.labelRecruitInform.MaximumSize = new System.Drawing.Size(400, 500);
            this.labelRecruitInform.Name = "labelRecruitInform";
            this.labelRecruitInform.Size = new System.Drawing.Size(54, 17);
            this.labelRecruitInform.TabIndex = 30;
            this.labelRecruitInform.Text = "Рекрут";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(102, 5);
            this.label22.MaximumSize = new System.Drawing.Size(100, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 34);
            this.label22.TabIndex = 29;
            this.label22.Text = "Количество нанимаемых";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Стоимость";
            // 
            // buttonAddRecruit
            // 
            this.buttonAddRecruit.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddRecruit.Image = global::GameStrategy.Properties.Resources.plus;
            this.buttonAddRecruit.Location = new System.Drawing.Point(390, 31);
            this.buttonAddRecruit.Name = "buttonAddRecruit";
            this.buttonAddRecruit.Size = new System.Drawing.Size(40, 40);
            this.buttonAddRecruit.TabIndex = 19;
            this.buttonAddRecruit.UseVisualStyleBackColor = false;
            this.buttonAddRecruit.Click += new System.EventHandler(this.buttonAddRecruit_Click);
            // 
            // labelRecruitText
            // 
            this.labelRecruitText.AutoSize = true;
            this.labelRecruitText.Location = new System.Drawing.Point(20, 43);
            this.labelRecruitText.Name = "labelRecruitText";
            this.labelRecruitText.Size = new System.Drawing.Size(54, 17);
            this.labelRecruitText.TabIndex = 7;
            this.labelRecruitText.Text = "Рекрут";
            // 
            // labelRecruit
            // 
            this.labelRecruit.AutoSize = true;
            this.labelRecruit.Location = new System.Drawing.Point(102, 43);
            this.labelRecruit.Name = "labelRecruit";
            this.labelRecruit.Size = new System.Drawing.Size(54, 17);
            this.labelRecruit.TabIndex = 8;
            this.labelRecruit.Text = "Рекрут";
            // 
            // textBoxRecruit
            // 
            this.textBoxRecruit.Location = new System.Drawing.Point(328, 40);
            this.textBoxRecruit.Name = "textBoxRecruit";
            this.textBoxRecruit.Size = new System.Drawing.Size(45, 22);
            this.textBoxRecruit.TabIndex = 23;
            // 
            // labelRecruitCost
            // 
            this.labelRecruitCost.AutoSize = true;
            this.labelRecruitCost.Location = new System.Drawing.Point(227, 42);
            this.labelRecruitCost.Name = "labelRecruitCost";
            this.labelRecruitCost.Size = new System.Drawing.Size(54, 17);
            this.labelRecruitCost.TabIndex = 27;
            this.labelRecruitCost.Text = "Рекрут";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label36);
            this.tabPage7.Controls.Add(this.label26);
            this.tabPage7.Controls.Add(this.label27);
            this.tabPage7.Controls.Add(this.label24);
            this.tabPage7.Controls.Add(this.label25);
            this.tabPage7.Controls.Add(this.buttonAddInfantryman);
            this.tabPage7.Controls.Add(this.labelInfantrymanText);
            this.tabPage7.Controls.Add(this.labelInfantryman);
            this.tabPage7.Controls.Add(this.textBoxInfantryman);
            this.tabPage7.Controls.Add(this.labelInfantrymanCost);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(450, 506);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Пехотинец";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(31, 172);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(79, 17);
            this.label36.TabIndex = 37;
            this.label36.Text = "Пехотинец";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(137, 8);
            this.label26.MaximumSize = new System.Drawing.Size(100, 80);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 34);
            this.label26.TabIndex = 36;
            this.label26.Text = "Количество нанимаемых";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(254, 15);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 17);
            this.label27.TabIndex = 35;
            this.label27.Text = "Стоимость";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(173, 112);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(131, 17);
            this.label24.TabIndex = 34;
            this.label24.Text = "Количество армии";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(31, 112);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(131, 17);
            this.label25.TabIndex = 33;
            this.label25.Text = "Количество армии";
            // 
            // buttonAddInfantryman
            // 
            this.buttonAddInfantryman.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddInfantryman.Image = global::GameStrategy.Properties.Resources.plus;
            this.buttonAddInfantryman.Location = new System.Drawing.Point(400, 37);
            this.buttonAddInfantryman.Name = "buttonAddInfantryman";
            this.buttonAddInfantryman.Size = new System.Drawing.Size(40, 40);
            this.buttonAddInfantryman.TabIndex = 21;
            this.buttonAddInfantryman.UseVisualStyleBackColor = false;
            this.buttonAddInfantryman.Click += new System.EventHandler(this.buttonAddInfantryman_Click);
            // 
            // labelInfantrymanText
            // 
            this.labelInfantrymanText.AutoSize = true;
            this.labelInfantrymanText.Location = new System.Drawing.Point(31, 49);
            this.labelInfantrymanText.Name = "labelInfantrymanText";
            this.labelInfantrymanText.Size = new System.Drawing.Size(79, 17);
            this.labelInfantrymanText.TabIndex = 9;
            this.labelInfantrymanText.Text = "Пехотинец";
            // 
            // labelInfantryman
            // 
            this.labelInfantryman.AutoSize = true;
            this.labelInfantryman.Location = new System.Drawing.Point(137, 49);
            this.labelInfantryman.Name = "labelInfantryman";
            this.labelInfantryman.Size = new System.Drawing.Size(79, 17);
            this.labelInfantryman.TabIndex = 10;
            this.labelInfantryman.Text = "Пехотинец";
            // 
            // textBoxInfantryman
            // 
            this.textBoxInfantryman.Location = new System.Drawing.Point(339, 46);
            this.textBoxInfantryman.Name = "textBoxInfantryman";
            this.textBoxInfantryman.Size = new System.Drawing.Size(45, 22);
            this.textBoxInfantryman.TabIndex = 24;
            // 
            // labelInfantrymanCost
            // 
            this.labelInfantrymanCost.AutoSize = true;
            this.labelInfantrymanCost.Location = new System.Drawing.Point(254, 49);
            this.labelInfantrymanCost.Name = "labelInfantrymanCost";
            this.labelInfantrymanCost.Size = new System.Drawing.Size(79, 17);
            this.labelInfantrymanCost.TabIndex = 28;
            this.labelInfantrymanCost.Text = "Пехотинец";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label37);
            this.tabPage8.Controls.Add(this.label30);
            this.tabPage8.Controls.Add(this.label31);
            this.tabPage8.Controls.Add(this.label28);
            this.tabPage8.Controls.Add(this.label29);
            this.tabPage8.Controls.Add(this.buttonAddCavalry);
            this.tabPage8.Controls.Add(this.labelCavalryText);
            this.tabPage8.Controls.Add(this.labelCavalryCost);
            this.tabPage8.Controls.Add(this.labelCavalry);
            this.tabPage8.Controls.Add(this.textBoxCavalry);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(450, 506);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Кавалерист";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(20, 155);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(86, 17);
            this.label37.TabIndex = 41;
            this.label37.Text = "Кавалерист";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(154, 96);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(131, 17);
            this.label30.TabIndex = 40;
            this.label30.Text = "Количество армии";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(17, 95);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 17);
            this.label31.TabIndex = 39;
            this.label31.Text = "Количество армии";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(126, 5);
            this.label28.MaximumSize = new System.Drawing.Size(100, 80);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(90, 34);
            this.label28.TabIndex = 38;
            this.label28.Text = "Количество нанимаемых";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(243, 12);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(78, 17);
            this.label29.TabIndex = 37;
            this.label29.Text = "Стоимость";
            // 
            // buttonAddCavalry
            // 
            this.buttonAddCavalry.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddCavalry.Image = global::GameStrategy.Properties.Resources.plus;
            this.buttonAddCavalry.Location = new System.Drawing.Point(399, 30);
            this.buttonAddCavalry.Name = "buttonAddCavalry";
            this.buttonAddCavalry.Size = new System.Drawing.Size(40, 40);
            this.buttonAddCavalry.TabIndex = 20;
            this.buttonAddCavalry.UseVisualStyleBackColor = false;
            this.buttonAddCavalry.Click += new System.EventHandler(this.buttonAddCavalry_Click);
            // 
            // labelCavalryText
            // 
            this.labelCavalryText.AutoSize = true;
            this.labelCavalryText.Location = new System.Drawing.Point(20, 44);
            this.labelCavalryText.Name = "labelCavalryText";
            this.labelCavalryText.Size = new System.Drawing.Size(86, 17);
            this.labelCavalryText.TabIndex = 13;
            this.labelCavalryText.Text = "Кавалерист";
            // 
            // labelCavalryCost
            // 
            this.labelCavalryCost.AutoSize = true;
            this.labelCavalryCost.Location = new System.Drawing.Point(243, 42);
            this.labelCavalryCost.Name = "labelCavalryCost";
            this.labelCavalryCost.Size = new System.Drawing.Size(86, 17);
            this.labelCavalryCost.TabIndex = 30;
            this.labelCavalryCost.Text = "Кавалерист";
            // 
            // labelCavalry
            // 
            this.labelCavalry.AutoSize = true;
            this.labelCavalry.Location = new System.Drawing.Point(126, 44);
            this.labelCavalry.Name = "labelCavalry";
            this.labelCavalry.Size = new System.Drawing.Size(86, 17);
            this.labelCavalry.TabIndex = 14;
            this.labelCavalry.Text = "Кавалерист";
            // 
            // textBoxCavalry
            // 
            this.textBoxCavalry.Location = new System.Drawing.Point(338, 39);
            this.textBoxCavalry.Name = "textBoxCavalry";
            this.textBoxCavalry.Size = new System.Drawing.Size(45, 22);
            this.textBoxCavalry.TabIndex = 26;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.label38);
            this.tabPage9.Controls.Add(this.label34);
            this.tabPage9.Controls.Add(this.label35);
            this.tabPage9.Controls.Add(this.label32);
            this.tabPage9.Controls.Add(this.label33);
            this.tabPage9.Controls.Add(this.buttonAddShooter);
            this.tabPage9.Controls.Add(this.labelShooterText);
            this.tabPage9.Controls.Add(this.labelShooter);
            this.tabPage9.Controls.Add(this.labelShooterCost);
            this.tabPage9.Controls.Add(this.textBoxShooter);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(450, 506);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "Стрелок";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(23, 185);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(63, 17);
            this.label38.TabIndex = 41;
            this.label38.Text = "Стрелок";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(126, 8);
            this.label34.MaximumSize = new System.Drawing.Size(100, 80);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(90, 34);
            this.label34.TabIndex = 40;
            this.label34.Text = "Количество нанимаемых";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(243, 15);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(78, 17);
            this.label35.TabIndex = 39;
            this.label35.Text = "Стоимость";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(160, 121);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(131, 17);
            this.label32.TabIndex = 36;
            this.label32.Text = "Количество армии";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(20, 122);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(131, 17);
            this.label33.TabIndex = 35;
            this.label33.Text = "Количество армии";
            // 
            // buttonAddShooter
            // 
            this.buttonAddShooter.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddShooter.Image = global::GameStrategy.Properties.Resources.plus;
            this.buttonAddShooter.Location = new System.Drawing.Point(400, 43);
            this.buttonAddShooter.Name = "buttonAddShooter";
            this.buttonAddShooter.Size = new System.Drawing.Size(40, 40);
            this.buttonAddShooter.TabIndex = 22;
            this.buttonAddShooter.UseVisualStyleBackColor = false;
            this.buttonAddShooter.Click += new System.EventHandler(this.buttonAddShooter_Click);
            // 
            // labelShooterText
            // 
            this.labelShooterText.AutoSize = true;
            this.labelShooterText.Location = new System.Drawing.Point(20, 59);
            this.labelShooterText.Name = "labelShooterText";
            this.labelShooterText.Size = new System.Drawing.Size(63, 17);
            this.labelShooterText.TabIndex = 11;
            this.labelShooterText.Text = "Стрелок";
            // 
            // labelShooter
            // 
            this.labelShooter.AutoSize = true;
            this.labelShooter.Location = new System.Drawing.Point(126, 59);
            this.labelShooter.Name = "labelShooter";
            this.labelShooter.Size = new System.Drawing.Size(63, 17);
            this.labelShooter.TabIndex = 12;
            this.labelShooter.Text = "Стрелок";
            // 
            // labelShooterCost
            // 
            this.labelShooterCost.AutoSize = true;
            this.labelShooterCost.Location = new System.Drawing.Point(243, 59);
            this.labelShooterCost.Name = "labelShooterCost";
            this.labelShooterCost.Size = new System.Drawing.Size(63, 17);
            this.labelShooterCost.TabIndex = 29;
            this.labelShooterCost.Text = "Стрелок";
            // 
            // textBoxShooter
            // 
            this.textBoxShooter.Location = new System.Drawing.Point(339, 52);
            this.textBoxShooter.Name = "textBoxShooter";
            this.textBoxShooter.Size = new System.Drawing.Size(45, 22);
            this.textBoxShooter.TabIndex = 25;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(24, 223);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 31;
            // 
            // groupBoxInformCastle
            // 
            this.groupBoxInformCastle.Controls.Add(this.tabPage);
            this.groupBoxInformCastle.Location = new System.Drawing.Point(0, 241);
            this.groupBoxInformCastle.Name = "groupBoxInformCastle";
            this.groupBoxInformCastle.Size = new System.Drawing.Size(454, 569);
            this.groupBoxInformCastle.TabIndex = 14;
            this.groupBoxInformCastle.TabStop = false;
            this.groupBoxInformCastle.Text = "Строения";
            this.groupBoxInformCastle.Visible = false;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPage1);
            this.tabPage.Controls.Add(this.tabPage2);
            this.tabPage.Controls.Add(this.tabPage3);
            this.tabPage.Controls.Add(this.tabPage4);
            this.tabPage.Controls.Add(this.tabPage5);
            this.tabPage.Location = new System.Drawing.Point(0, 34);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(454, 604);
            this.tabPage.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelDescriptionBuildings);
            this.tabPage1.Controls.Add(this.labelLevelBuildings);
            this.tabPage1.Controls.Add(this.labelLevelBuildingsText);
            this.tabPage1.Controls.Add(this.buttonLevelUp);
            this.tabPage1.Controls.Add(this.labelCost);
            this.tabPage1.Controls.Add(this.labelCostText);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ратуша";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelDescriptionBuildings
            // 
            this.labelDescriptionBuildings.AutoEllipsis = true;
            this.labelDescriptionBuildings.AutoSize = true;
            this.labelDescriptionBuildings.Location = new System.Drawing.Point(6, 117);
            this.labelDescriptionBuildings.MaximumSize = new System.Drawing.Size(400, 500);
            this.labelDescriptionBuildings.Name = "labelDescriptionBuildings";
            this.labelDescriptionBuildings.Size = new System.Drawing.Size(77, 17);
            this.labelDescriptionBuildings.TabIndex = 14;
            this.labelDescriptionBuildings.Text = "description";
            // 
            // labelLevelBuildings
            // 
            this.labelLevelBuildings.AutoSize = true;
            this.labelLevelBuildings.Location = new System.Drawing.Point(102, 29);
            this.labelLevelBuildings.Name = "labelLevelBuildings";
            this.labelLevelBuildings.Size = new System.Drawing.Size(63, 17);
            this.labelLevelBuildings.TabIndex = 11;
            this.labelLevelBuildings.Text = "Уровень";
            // 
            // labelLevelBuildingsText
            // 
            this.labelLevelBuildingsText.AutoSize = true;
            this.labelLevelBuildingsText.Location = new System.Drawing.Point(23, 29);
            this.labelLevelBuildingsText.Name = "labelLevelBuildingsText";
            this.labelLevelBuildingsText.Size = new System.Drawing.Size(63, 17);
            this.labelLevelBuildingsText.TabIndex = 9;
            this.labelLevelBuildingsText.Text = "Уровень";
            // 
            // buttonLevelUp
            // 
            this.buttonLevelUp.Location = new System.Drawing.Point(276, 62);
            this.buttonLevelUp.Name = "buttonLevelUp";
            this.buttonLevelUp.Size = new System.Drawing.Size(107, 33);
            this.buttonLevelUp.TabIndex = 10;
            this.buttonLevelUp.Text = "Улучшить";
            this.buttonLevelUp.UseVisualStyleBackColor = true;
            this.buttonLevelUp.Click += new System.EventHandler(this.buttonLevelUp_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(200, 70);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(43, 17);
            this.labelCost.TabIndex = 13;
            this.labelCost.Text = "Цена";
            // 
            // labelCostText
            // 
            this.labelCostText.AutoSize = true;
            this.labelCostText.Location = new System.Drawing.Point(23, 70);
            this.labelCostText.Name = "labelCostText";
            this.labelCostText.Size = new System.Drawing.Size(164, 17);
            this.labelCostText.TabIndex = 12;
            this.labelCostText.Text = "Цена за новый уровень";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelDescriptionBuildings2);
            this.tabPage2.Controls.Add(this.labelLevelBuildings2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.labelCost2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Храм";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelDescriptionBuildings2
            // 
            this.labelDescriptionBuildings2.AutoSize = true;
            this.labelDescriptionBuildings2.Location = new System.Drawing.Point(20, 125);
            this.labelDescriptionBuildings2.MaximumSize = new System.Drawing.Size(400, 500);
            this.labelDescriptionBuildings2.Name = "labelDescriptionBuildings2";
            this.labelDescriptionBuildings2.Size = new System.Drawing.Size(77, 17);
            this.labelDescriptionBuildings2.TabIndex = 19;
            this.labelDescriptionBuildings2.Text = "description";
            // 
            // labelLevelBuildings2
            // 
            this.labelLevelBuildings2.AutoSize = true;
            this.labelLevelBuildings2.Location = new System.Drawing.Point(99, 28);
            this.labelLevelBuildings2.Name = "labelLevelBuildings2";
            this.labelLevelBuildings2.Size = new System.Drawing.Size(63, 17);
            this.labelLevelBuildings2.TabIndex = 16;
            this.labelLevelBuildings2.Text = "Уровень";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Уровень";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 33);
            this.button2.TabIndex = 15;
            this.button2.Text = "Улучшить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCost2
            // 
            this.labelCost2.AutoSize = true;
            this.labelCost2.Location = new System.Drawing.Point(214, 69);
            this.labelCost2.Name = "labelCost2";
            this.labelCost2.Size = new System.Drawing.Size(43, 17);
            this.labelCost2.TabIndex = 18;
            this.labelCost2.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Цена за новый уровень";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelDescriptionBuildings3);
            this.tabPage3.Controls.Add(this.labelLevelBuildings3);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.labelCost3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(446, 575);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Казармы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelDescriptionBuildings3
            // 
            this.labelDescriptionBuildings3.AutoSize = true;
            this.labelDescriptionBuildings3.Location = new System.Drawing.Point(20, 107);
            this.labelDescriptionBuildings3.MaximumSize = new System.Drawing.Size(400, 500);
            this.labelDescriptionBuildings3.Name = "labelDescriptionBuildings3";
            this.labelDescriptionBuildings3.Size = new System.Drawing.Size(77, 17);
            this.labelDescriptionBuildings3.TabIndex = 19;
            this.labelDescriptionBuildings3.Text = "description";
            // 
            // labelLevelBuildings3
            // 
            this.labelLevelBuildings3.AutoSize = true;
            this.labelLevelBuildings3.Location = new System.Drawing.Point(99, 19);
            this.labelLevelBuildings3.Name = "labelLevelBuildings3";
            this.labelLevelBuildings3.Size = new System.Drawing.Size(63, 17);
            this.labelLevelBuildings3.TabIndex = 16;
            this.labelLevelBuildings3.Text = "Уровень";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Уровень";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(282, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 33);
            this.button3.TabIndex = 15;
            this.button3.Text = "Улучшить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelCost3
            // 
            this.labelCost3.AutoSize = true;
            this.labelCost3.Location = new System.Drawing.Point(210, 60);
            this.labelCost3.Name = "labelCost3";
            this.labelCost3.Size = new System.Drawing.Size(43, 17);
            this.labelCost3.TabIndex = 18;
            this.labelCost3.Text = "Цена";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Цена за новый уровень";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelDescriptionBuildings4);
            this.tabPage4.Controls.Add(this.labelLevelBuildings4);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.labelCost4);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(446, 575);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Жилые Дома";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelDescriptionBuildings4
            // 
            this.labelDescriptionBuildings4.AutoSize = true;
            this.labelDescriptionBuildings4.Location = new System.Drawing.Point(21, 111);
            this.labelDescriptionBuildings4.MaximumSize = new System.Drawing.Size(400, 500);
            this.labelDescriptionBuildings4.Name = "labelDescriptionBuildings4";
            this.labelDescriptionBuildings4.Size = new System.Drawing.Size(77, 17);
            this.labelDescriptionBuildings4.TabIndex = 19;
            this.labelDescriptionBuildings4.Text = "description";
            // 
            // labelLevelBuildings4
            // 
            this.labelLevelBuildings4.AutoSize = true;
            this.labelLevelBuildings4.Location = new System.Drawing.Point(99, 22);
            this.labelLevelBuildings4.Name = "labelLevelBuildings4";
            this.labelLevelBuildings4.Size = new System.Drawing.Size(63, 17);
            this.labelLevelBuildings4.TabIndex = 16;
            this.labelLevelBuildings4.Text = "Уровень";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Уровень";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 33);
            this.button4.TabIndex = 15;
            this.button4.Text = "Улучшить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelCost4
            // 
            this.labelCost4.AutoSize = true;
            this.labelCost4.Location = new System.Drawing.Point(190, 63);
            this.labelCost4.Name = "labelCost4";
            this.labelCost4.Size = new System.Drawing.Size(43, 17);
            this.labelCost4.TabIndex = 18;
            this.labelCost4.Text = "Цена";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Цена за новый уровень";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.labelDescriptionBuildings5);
            this.tabPage5.Controls.Add(this.labelLevelBuildings5);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.labelCost5);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(446, 575);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Стена";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // labelDescriptionBuildings5
            // 
            this.labelDescriptionBuildings5.AutoSize = true;
            this.labelDescriptionBuildings5.Location = new System.Drawing.Point(20, 128);
            this.labelDescriptionBuildings5.MaximumSize = new System.Drawing.Size(400, 500);
            this.labelDescriptionBuildings5.Name = "labelDescriptionBuildings5";
            this.labelDescriptionBuildings5.Size = new System.Drawing.Size(77, 17);
            this.labelDescriptionBuildings5.TabIndex = 19;
            this.labelDescriptionBuildings5.Text = "description";
            // 
            // labelLevelBuildings5
            // 
            this.labelLevelBuildings5.AutoSize = true;
            this.labelLevelBuildings5.Location = new System.Drawing.Point(99, 24);
            this.labelLevelBuildings5.Name = "labelLevelBuildings5";
            this.labelLevelBuildings5.Size = new System.Drawing.Size(63, 17);
            this.labelLevelBuildings5.TabIndex = 16;
            this.labelLevelBuildings5.Text = "Уровень";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Уровень";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(279, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 33);
            this.button5.TabIndex = 15;
            this.button5.Text = "Улучшить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelCost5
            // 
            this.labelCost5.AutoSize = true;
            this.labelCost5.Location = new System.Drawing.Point(190, 73);
            this.labelCost5.Name = "labelCost5";
            this.labelCost5.Size = new System.Drawing.Size(43, 17);
            this.labelCost5.TabIndex = 18;
            this.labelCost5.Text = "Цена";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "Цена за новый уровень";
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.buttonTask3);
            this.groupBoxTask.Controls.Add(this.label20);
            this.groupBoxTask.Controls.Add(this.buttonTask2);
            this.groupBoxTask.Controls.Add(this.buttonTask1);
            this.groupBoxTask.Controls.Add(this.labelTask3);
            this.groupBoxTask.Controls.Add(this.labelTask2);
            this.groupBoxTask.Controls.Add(this.labelTask1);
            this.groupBoxTask.Location = new System.Drawing.Point(0, 241);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(454, 569);
            this.groupBoxTask.TabIndex = 32;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Задания";
            this.groupBoxTask.Visible = false;
            // 
            // buttonTask3
            // 
            this.buttonTask3.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonTask3.Image = global::GameStrategy.Properties.Resources.plus;
            this.buttonTask3.Location = new System.Drawing.Point(383, 159);
            this.buttonTask3.Name = "buttonTask3";
            this.buttonTask3.Size = new System.Drawing.Size(40, 40);
            this.buttonTask3.TabIndex = 22;
            this.buttonTask3.UseVisualStyleBackColor = false;
            this.buttonTask3.Click += new System.EventHandler(this.button7_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 17);
            this.label20.TabIndex = 41;
            this.label20.Text = "Выбери одно задание";
            // 
            // buttonTask2
            // 
            this.buttonTask2.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonTask2.Image = global::GameStrategy.Properties.Resources.plus;
            this.buttonTask2.Location = new System.Drawing.Point(383, 108);
            this.buttonTask2.Name = "buttonTask2";
            this.buttonTask2.Size = new System.Drawing.Size(40, 40);
            this.buttonTask2.TabIndex = 21;
            this.buttonTask2.UseVisualStyleBackColor = false;
            this.buttonTask2.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonTask1
            // 
            this.buttonTask1.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonTask1.Image = global::GameStrategy.Properties.Resources.plus;
            this.buttonTask1.Location = new System.Drawing.Point(383, 61);
            this.buttonTask1.Name = "buttonTask1";
            this.buttonTask1.Size = new System.Drawing.Size(40, 40);
            this.buttonTask1.TabIndex = 19;
            this.buttonTask1.UseVisualStyleBackColor = false;
            this.buttonTask1.Click += new System.EventHandler(this.buttonTask1_Click);
            // 
            // labelTask3
            // 
            this.labelTask3.AutoSize = true;
            this.labelTask3.Location = new System.Drawing.Point(24, 171);
            this.labelTask3.Name = "labelTask3";
            this.labelTask3.Size = new System.Drawing.Size(65, 17);
            this.labelTask3.TabIndex = 11;
            this.labelTask3.Text = "Задание";
            // 
            // labelTask2
            // 
            this.labelTask2.AutoSize = true;
            this.labelTask2.Location = new System.Drawing.Point(24, 120);
            this.labelTask2.Name = "labelTask2";
            this.labelTask2.Size = new System.Drawing.Size(65, 17);
            this.labelTask2.TabIndex = 9;
            this.labelTask2.Text = "Задание";
            // 
            // labelTask1
            // 
            this.labelTask1.AutoSize = true;
            this.labelTask1.Location = new System.Drawing.Point(21, 74);
            this.labelTask1.Name = "labelTask1";
            this.labelTask1.Size = new System.Drawing.Size(65, 17);
            this.labelTask1.TabIndex = 7;
            this.labelTask1.Text = "Задание";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 810);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "Form1";
            this.Text = "MainMap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGameObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCastle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxArmyAttack.ResumeLayout(false);
            this.groupBoxArmyAttack.PerformLayout();
            this.groupBoxArmy.ResumeLayout(false);
            this.groupBoxArmy.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.groupBoxInformCastle.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCountPeople;
        private System.Windows.Forms.Label labelTextCountPeople;
        private System.Windows.Forms.Label labelCountCoin;
        private System.Windows.Forms.Label labelTextCountCoin;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelTextLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxCastle;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelLevelBuildingsText;
        private System.Windows.Forms.Label labelLevelBuildings;
        private System.Windows.Forms.Button buttonLevelUp;
        private System.Windows.Forms.GroupBox groupBoxInformCastle;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelCostText;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelLevelBuildings2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelCost2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelLevelBuildings3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelCost3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelLevelBuildings4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelCost4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label labelLevelBuildings5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelCost5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelDescriptionBuildings;
        private System.Windows.Forms.Label labelDescriptionBuildings2;
        private System.Windows.Forms.Label labelDescriptionBuildings3;
        private System.Windows.Forms.Label labelDescriptionBuildings4;
        private System.Windows.Forms.Label labelDescriptionBuildings5;
        private System.Windows.Forms.Button buttonShowArmy;
        private System.Windows.Forms.Button buttonShowBuildings;
        private System.Windows.Forms.Button buttonTask;
        private System.Windows.Forms.GroupBox groupBoxArmy;
        private System.Windows.Forms.Button buttonAddShooter;
        private System.Windows.Forms.Button buttonAddInfantryman;
        private System.Windows.Forms.Button buttonAddCavalry;
        private System.Windows.Forms.Button buttonAddRecruit;
        private System.Windows.Forms.Label labelCavalry;
        private System.Windows.Forms.Label labelCavalryText;
        private System.Windows.Forms.Label labelShooter;
        private System.Windows.Forms.Label labelShooterText;
        private System.Windows.Forms.Label labelInfantryman;
        private System.Windows.Forms.Label labelInfantrymanText;
        private System.Windows.Forms.Label labelRecruit;
        private System.Windows.Forms.Label labelRecruitText;
        private System.Windows.Forms.Label labelCavalryCost;
        private System.Windows.Forms.Label labelShooterCost;
        private System.Windows.Forms.Label labelInfantrymanCost;
        private System.Windows.Forms.Label labelRecruitCost;
        private System.Windows.Forms.TextBox textBoxCavalry;
        private System.Windows.Forms.TextBox textBoxShooter;
        private System.Windows.Forms.TextBox textBoxInfantryman;
        private System.Windows.Forms.TextBox textBoxRecruit;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureGameObject;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Button buttonTask1;
        private System.Windows.Forms.Label labelTask1;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.GroupBox groupBoxArmyAttack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonAddShooterForAttck;
        private System.Windows.Forms.Button buttonAddInfantrymanForAttack;
        private System.Windows.Forms.Button buttonAddCavarlyForAttack;
        private System.Windows.Forms.Button buttonAddRecruitForAttck;
        private System.Windows.Forms.Label labelCavalryAttac;
        private System.Windows.Forms.Label labelShooterAttac;
        private System.Windows.Forms.Label labelInfantrymanAttac;
        private System.Windows.Forms.Label labelRecruitAttac;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonTask3;
        private System.Windows.Forms.Button buttonTask2;
        private System.Windows.Forms.Label labelTask3;
        private System.Windows.Forms.Label labelTask2;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelRecruitInform;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label labelTrainedRecruit;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
    }
}

