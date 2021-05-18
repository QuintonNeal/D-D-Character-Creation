
namespace DNDCharacterCreation
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
            this.cmbChar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HitPointTextBox = new System.Windows.Forms.TextBox();
            this.CharacterIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RaceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StrengthTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IntelligenceTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DexterityTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstEquip = new System.Windows.Forms.ListBox();
            this.TypeTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SizeTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EquipIDTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RarityTxtBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SlotTxtBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.LossDateTxtBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.StatusTxtBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.AcquireDateTxtBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInsertC = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnInsertItem = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnUpdateC = new System.Windows.Forms.Button();
            this.btnDeleteC = new System.Windows.Forms.Button();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.equipmentNameTxtBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.avPanel = new System.Windows.Forms.Panel();
            this.hideAvsBtn = new System.Windows.Forms.Button();
            this.avHitPointsTextBox = new System.Windows.Forms.TextBox();
            this.avIntelligenceTextBox = new System.Windows.Forms.TextBox();
            this.avDexterityTextBox = new System.Windows.Forms.TextBox();
            this.avStrengthTextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.showAvsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.avPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbChar
            // 
            this.cmbChar.FormattingEnabled = true;
            this.cmbChar.Location = new System.Drawing.Point(22, 21);
            this.cmbChar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbChar.Name = "cmbChar";
            this.cmbChar.Size = new System.Drawing.Size(140, 21);
            this.cmbChar.TabIndex = 0;
            this.cmbChar.SelectedIndexChanged += new System.EventHandler(this.cmbChar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Your Character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hit Points";
            // 
            // HitPointTextBox
            // 
            this.HitPointTextBox.Location = new System.Drawing.Point(79, 120);
            this.HitPointTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HitPointTextBox.Name = "HitPointTextBox";
            this.HitPointTextBox.Size = new System.Drawing.Size(76, 20);
            this.HitPointTextBox.TabIndex = 3;
            // 
            // CharacterIDTextBox
            // 
            this.CharacterIDTextBox.Location = new System.Drawing.Point(278, 2);
            this.CharacterIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CharacterIDTextBox.Name = "CharacterIDTextBox";
            this.CharacterIDTextBox.Size = new System.Drawing.Size(97, 20);
            this.CharacterIDTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CharacterID";
            // 
            // PlayerTextBox
            // 
            this.PlayerTextBox.Location = new System.Drawing.Point(278, 36);
            this.PlayerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerTextBox.Name = "PlayerTextBox";
            this.PlayerTextBox.Size = new System.Drawing.Size(97, 20);
            this.PlayerTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player";
            // 
            // RaceTextBox
            // 
            this.RaceTextBox.Location = new System.Drawing.Point(422, 2);
            this.RaceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RaceTextBox.Name = "RaceTextBox";
            this.RaceTextBox.Size = new System.Drawing.Size(97, 20);
            this.RaceTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Race";
            // 
            // ClassTextBox
            // 
            this.ClassTextBox.Location = new System.Drawing.Point(422, 36);
            this.ClassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassTextBox.Name = "ClassTextBox";
            this.ClassTextBox.Size = new System.Drawing.Size(97, 20);
            this.ClassTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Class";
            // 
            // StrengthTextBox
            // 
            this.StrengthTextBox.Location = new System.Drawing.Point(79, 52);
            this.StrengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StrengthTextBox.Name = "StrengthTextBox";
            this.StrengthTextBox.Size = new System.Drawing.Size(76, 20);
            this.StrengthTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Strength";
            // 
            // IntelligenceTextBox
            // 
            this.IntelligenceTextBox.Location = new System.Drawing.Point(79, 97);
            this.IntelligenceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IntelligenceTextBox.Name = "IntelligenceTextBox";
            this.IntelligenceTextBox.Size = new System.Drawing.Size(76, 20);
            this.IntelligenceTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Intelligence";
            // 
            // DexterityTextBox
            // 
            this.DexterityTextBox.Location = new System.Drawing.Point(79, 74);
            this.DexterityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DexterityTextBox.Name = "DexterityTextBox";
            this.DexterityTextBox.Size = new System.Drawing.Size(76, 20);
            this.DexterityTextBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Dexterity";
            // 
            // lstEquip
            // 
            this.lstEquip.FormattingEnabled = true;
            this.lstEquip.Location = new System.Drawing.Point(674, 7);
            this.lstEquip.Margin = new System.Windows.Forms.Padding(2);
            this.lstEquip.Name = "lstEquip";
            this.lstEquip.Size = new System.Drawing.Size(183, 199);
            this.lstEquip.TabIndex = 18;
            this.lstEquip.SelectedIndexChanged += new System.EventHandler(this.lstEquip_SelectedIndexChanged);
            // 
            // TypeTxtBox
            // 
            this.TypeTxtBox.Location = new System.Drawing.Point(69, 87);
            this.TypeTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.TypeTxtBox.Name = "TypeTxtBox";
            this.TypeTxtBox.Size = new System.Drawing.Size(84, 20);
            this.TypeTxtBox.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Type";
            // 
            // SizeTxtBox
            // 
            this.SizeTxtBox.Location = new System.Drawing.Point(69, 109);
            this.SizeTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.SizeTxtBox.Name = "SizeTxtBox";
            this.SizeTxtBox.Size = new System.Drawing.Size(84, 20);
            this.SizeTxtBox.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Size";
            // 
            // EquipIDTxtBox
            // 
            this.EquipIDTxtBox.Enabled = false;
            this.EquipIDTxtBox.Location = new System.Drawing.Point(69, 64);
            this.EquipIDTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.EquipIDTxtBox.Name = "EquipIDTxtBox";
            this.EquipIDTxtBox.Size = new System.Drawing.Size(84, 20);
            this.EquipIDTxtBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 67);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Equip ID";
            // 
            // RarityTxtBox
            // 
            this.RarityTxtBox.Location = new System.Drawing.Point(69, 132);
            this.RarityTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.RarityTxtBox.Name = "RarityTxtBox";
            this.RarityTxtBox.Size = new System.Drawing.Size(84, 20);
            this.RarityTxtBox.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Rarity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(408, 151);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SlotTxtBox
            // 
            this.SlotTxtBox.Location = new System.Drawing.Point(241, 36);
            this.SlotTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.SlotTxtBox.Name = "SlotTxtBox";
            this.SlotTxtBox.Size = new System.Drawing.Size(76, 20);
            this.SlotTxtBox.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(208, 43);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Slot";
            // 
            // LossDateTxtBox
            // 
            this.LossDateTxtBox.Location = new System.Drawing.Point(241, 6);
            this.LossDateTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.LossDateTxtBox.Name = "LossDateTxtBox";
            this.LossDateTxtBox.Size = new System.Drawing.Size(76, 20);
            this.LossDateTxtBox.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(173, 14);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Loss Date";
            // 
            // StatusTxtBox
            // 
            this.StatusTxtBox.Location = new System.Drawing.Point(91, 36);
            this.StatusTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.StatusTxtBox.Name = "StatusTxtBox";
            this.StatusTxtBox.Size = new System.Drawing.Size(76, 20);
            this.StatusTxtBox.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(44, 43);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Status";
            // 
            // AcquireDateTxtBox
            // 
            this.AcquireDateTxtBox.Location = new System.Drawing.Point(91, 6);
            this.AcquireDateTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.AcquireDateTxtBox.Name = "AcquireDateTxtBox";
            this.AcquireDateTxtBox.Size = new System.Drawing.Size(76, 20);
            this.AcquireDateTxtBox.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 14);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Acquire Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DNDCharacterCreation.Properties.Resources.DNDCharacterPic;
            this.pictureBox1.InitialImage = global::DNDCharacterCreation.Properties.Resources.DNDCharacterPic;
            this.pictureBox1.Location = new System.Drawing.Point(6, 272);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnInsertC
            // 
            this.btnInsertC.Location = new System.Drawing.Point(159, 9);
            this.btnInsertC.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertC.Name = "btnInsertC";
            this.btnInsertC.Size = new System.Drawing.Size(55, 42);
            this.btnInsertC.TabIndex = 37;
            this.btnInsertC.Text = "Insert";
            this.btnInsertC.UseVisualStyleBackColor = true;
            this.btnInsertC.Click += new System.EventHandler(this.btnInsertC_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(555, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Choose your wares";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(157, 14);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(55, 42);
            this.InsertButton.TabIndex = 39;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(157, 62);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(55, 42);
            this.UpdateButton.TabIndex = 40;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(157, 110);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(55, 42);
            this.DeleteButton.TabIndex = 41;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(132, 67);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(55, 42);
            this.btnDeleteItem.TabIndex = 44;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(71, 67);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(55, 42);
            this.btnUpdateItem.TabIndex = 43;
            this.btnUpdateItem.Text = "Update";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnInsertItem
            // 
            this.btnInsertItem.Location = new System.Drawing.Point(10, 67);
            this.btnInsertItem.Name = "btnInsertItem";
            this.btnInsertItem.Size = new System.Drawing.Size(55, 42);
            this.btnInsertItem.TabIndex = 42;
            this.btnInsertItem.Text = "Insert";
            this.btnInsertItem.UseVisualStyleBackColor = true;
            this.btnInsertItem.Click += new System.EventHandler(this.btnInsertItem_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(373, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Character Inventory";
            // 
            // btnUpdateC
            // 
            this.btnUpdateC.Location = new System.Drawing.Point(159, 55);
            this.btnUpdateC.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateC.Name = "btnUpdateC";
            this.btnUpdateC.Size = new System.Drawing.Size(55, 42);
            this.btnUpdateC.TabIndex = 46;
            this.btnUpdateC.Text = "Update";
            this.btnUpdateC.UseVisualStyleBackColor = true;
            this.btnUpdateC.Click += new System.EventHandler(this.btnUpdateC_Click);
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.Location = new System.Drawing.Point(159, 101);
            this.btnDeleteC.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(55, 42);
            this.btnDeleteC.TabIndex = 47;
            this.btnDeleteC.Text = "Delete";
            this.btnDeleteC.UseVisualStyleBackColor = true;
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Location = new System.Drawing.Point(37, 27);
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.CharacterNameTextBox.TabIndex = 48;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(50, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "Character Name:";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshButton.Location = new System.Drawing.Point(780, 401);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(77, 46);
            this.refreshButton.TabIndex = 50;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // equipmentNameTxtBox
            // 
            this.equipmentNameTxtBox.Location = new System.Drawing.Point(28, 36);
            this.equipmentNameTxtBox.Name = "equipmentNameTxtBox";
            this.equipmentNameTxtBox.Size = new System.Drawing.Size(125, 20);
            this.equipmentNameTxtBox.TabIndex = 51;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(44, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "Equipment Name:";
            // 
            // avPanel
            // 
            this.avPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.avPanel.Controls.Add(this.hideAvsBtn);
            this.avPanel.Controls.Add(this.avHitPointsTextBox);
            this.avPanel.Controls.Add(this.avIntelligenceTextBox);
            this.avPanel.Controls.Add(this.avDexterityTextBox);
            this.avPanel.Controls.Add(this.avStrengthTextBox);
            this.avPanel.Controls.Add(this.label25);
            this.avPanel.Controls.Add(this.label24);
            this.avPanel.Controls.Add(this.label23);
            this.avPanel.Controls.Add(this.label22);
            this.avPanel.Location = new System.Drawing.Point(558, 4);
            this.avPanel.Name = "avPanel";
            this.avPanel.Size = new System.Drawing.Size(310, 443);
            this.avPanel.TabIndex = 53;
            this.avPanel.Visible = false;
            // 
            // hideAvsBtn
            // 
            this.hideAvsBtn.Location = new System.Drawing.Point(151, 161);
            this.hideAvsBtn.Name = "hideAvsBtn";
            this.hideAvsBtn.Size = new System.Drawing.Size(130, 93);
            this.hideAvsBtn.TabIndex = 55;
            this.hideAvsBtn.Text = "Hide Averages";
            this.hideAvsBtn.UseVisualStyleBackColor = true;
            this.hideAvsBtn.Click += new System.EventHandler(this.hideAvsBtn_Click);
            // 
            // avHitPointsTextBox
            // 
            this.avHitPointsTextBox.Location = new System.Drawing.Point(181, 100);
            this.avHitPointsTextBox.Name = "avHitPointsTextBox";
            this.avHitPointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.avHitPointsTextBox.TabIndex = 7;
            // 
            // avIntelligenceTextBox
            // 
            this.avIntelligenceTextBox.Location = new System.Drawing.Point(181, 71);
            this.avIntelligenceTextBox.Name = "avIntelligenceTextBox";
            this.avIntelligenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.avIntelligenceTextBox.TabIndex = 6;
            // 
            // avDexterityTextBox
            // 
            this.avDexterityTextBox.Location = new System.Drawing.Point(181, 38);
            this.avDexterityTextBox.Name = "avDexterityTextBox";
            this.avDexterityTextBox.Size = new System.Drawing.Size(100, 20);
            this.avDexterityTextBox.TabIndex = 5;
            // 
            // avStrengthTextBox
            // 
            this.avStrengthTextBox.Location = new System.Drawing.Point(181, 7);
            this.avStrengthTextBox.Name = "avStrengthTextBox";
            this.avStrengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.avStrengthTextBox.TabIndex = 4;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(23, 103);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(137, 16);
            this.label25.TabIndex = 3;
            this.label25.Text = "Average Hit Points";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(9, 72);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(151, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "Average Intelligence";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(28, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(132, 16);
            this.label23.TabIndex = 1;
            this.label23.Text = "Average Dexterity";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(32, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Average Strength";
            // 
            // showAvsBtn
            // 
            this.showAvsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showAvsBtn.Location = new System.Drawing.Point(182, 272);
            this.showAvsBtn.Name = "showAvsBtn";
            this.showAvsBtn.Size = new System.Drawing.Size(97, 175);
            this.showAvsBtn.TabIndex = 54;
            this.showAvsBtn.Text = "Show Character Averages";
            this.showAvsBtn.UseVisualStyleBackColor = false;
            this.showAvsBtn.Click += new System.EventHandler(this.showAvsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.CharacterNameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.HitPointTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.StrengthTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.IntelligenceTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnDeleteC);
            this.panel1.Controls.Add(this.DexterityTextBox);
            this.panel1.Controls.Add(this.btnUpdateC);
            this.panel1.Controls.Add(this.btnInsertC);
            this.panel1.Location = new System.Drawing.Point(6, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 151);
            this.panel1.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnDeleteItem);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.AcquireDateTxtBox);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.StatusTxtBox);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.LossDateTxtBox);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.SlotTxtBox);
            this.panel2.Controls.Add(this.btnUpdateItem);
            this.panel2.Controls.Add(this.btnInsertItem);
            this.panel2.Location = new System.Drawing.Point(313, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 112);
            this.panel2.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.RarityTxtBox);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.EquipIDTxtBox);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.equipmentNameTxtBox);
            this.panel3.Controls.Add(this.SizeTxtBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.TypeTxtBox);
            this.panel3.Controls.Add(this.DeleteButton);
            this.panel3.Controls.Add(this.InsertButton);
            this.panel3.Controls.Add(this.UpdateButton);
            this.panel3.Location = new System.Drawing.Point(642, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 173);
            this.panel3.TabIndex = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DNDCharacterCreation.Properties.Resources.dnd_background;
            this.ClientSize = new System.Drawing.Size(871, 453);
            this.Controls.Add(this.avPanel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showAvsBtn);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstEquip);
            this.Controls.Add(this.ClassTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RaceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayerTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CharacterIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.avPanel.ResumeLayout(false);
            this.avPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HitPointTextBox;
        private System.Windows.Forms.TextBox CharacterIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PlayerTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RaceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClassTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StrengthTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IntelligenceTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DexterityTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstEquip;
        private System.Windows.Forms.TextBox TypeTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SizeTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EquipIDTxtBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RarityTxtBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SlotTxtBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox LossDateTxtBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox StatusTxtBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox AcquireDateTxtBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInsertC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnInsertItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnUpdateC;
        private System.Windows.Forms.Button btnDeleteC;
        private System.Windows.Forms.TextBox CharacterNameTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox equipmentNameTxtBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel avPanel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox avHitPointsTextBox;
        private System.Windows.Forms.TextBox avIntelligenceTextBox;
        private System.Windows.Forms.TextBox avDexterityTextBox;
        private System.Windows.Forms.TextBox avStrengthTextBox;
        private System.Windows.Forms.Button showAvsBtn;
        private System.Windows.Forms.Button hideAvsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

