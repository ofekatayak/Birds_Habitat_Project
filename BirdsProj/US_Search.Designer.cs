namespace BirdsProj
{
    partial class US_Search
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Search));
            label1 = new Label();
            TB_serialNum_searchCage = new TextBox();
            GP_searchCage_search = new GroupBox();
            refresh_CageTable = new PictureBox();
            bttn_searchCage_search = new PictureBox();
            label2 = new Label();
            CB_matirial_searchCage = new ComboBox();
            label6 = new Label();
            panel2 = new Panel();
            dataGV_cage_search = new DataGridView();
            dataGV_bird_search = new DataGridView();
            label_resTitle_search = new Label();
            panel1 = new Panel();
            RB_female_addBird = new RadioButton();
            RB_male_addBird = new RadioButton();
            Date_addBird = new DateTimePicker();
            CM_type_addBird = new ComboBox();
            TB_serialNum_addBird = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            bttn_searchBird_search = new PictureBox();
            GP_searchBird_search = new GroupBox();
            refresh_BirdTable = new PictureBox();
            GP_searchCage_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)refresh_CageTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bttn_searchCage_search).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGV_cage_search).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGV_bird_search).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttn_searchBird_search).BeginInit();
            GP_searchBird_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)refresh_BirdTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(430, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 41);
            label1.TabIndex = 4;
            label1.Text = "Search";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // TB_serialNum_searchCage
            // 
            TB_serialNum_searchCage.Location = new Point(23, 58);
            TB_serialNum_searchCage.Name = "TB_serialNum_searchCage";
            TB_serialNum_searchCage.Size = new Size(190, 27);
            TB_serialNum_searchCage.TabIndex = 5;
            // 
            // GP_searchCage_search
            // 
            GP_searchCage_search.Controls.Add(refresh_CageTable);
            GP_searchCage_search.Controls.Add(bttn_searchCage_search);
            GP_searchCage_search.Controls.Add(label2);
            GP_searchCage_search.Controls.Add(CB_matirial_searchCage);
            GP_searchCage_search.Controls.Add(label6);
            GP_searchCage_search.Controls.Add(TB_serialNum_searchCage);
            GP_searchCage_search.Location = new Point(28, 96);
            GP_searchCage_search.Name = "GP_searchCage_search";
            GP_searchCage_search.Size = new Size(359, 208);
            GP_searchCage_search.TabIndex = 6;
            GP_searchCage_search.TabStop = false;
            GP_searchCage_search.Text = "Search Cage";
            GP_searchCage_search.Enter += GP_searchCage_search_Enter;
            // 
            // refresh_CageTable
            // 
            refresh_CageTable.Image = (Image)resources.GetObject("refresh_CageTable.Image");
            refresh_CageTable.Location = new Point(241, 156);
            refresh_CageTable.Name = "refresh_CageTable";
            refresh_CageTable.Size = new Size(48, 31);
            refresh_CageTable.SizeMode = PictureBoxSizeMode.Zoom;
            refresh_CageTable.TabIndex = 24;
            refresh_CageTable.TabStop = false;
            refresh_CageTable.Click += pictureBox3_Click;
            // 
            // bttn_searchCage_search
            // 
            bttn_searchCage_search.Image = Properties.Resources.search;
            bttn_searchCage_search.Location = new Point(295, 140);
            bttn_searchCage_search.Name = "bttn_searchCage_search";
            bttn_searchCage_search.Size = new Size(48, 49);
            bttn_searchCage_search.SizeMode = PictureBoxSizeMode.Zoom;
            bttn_searchCage_search.TabIndex = 24;
            bttn_searchCage_search.TabStop = false;
            bttn_searchCage_search.Click += bttn_searchCage_search_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 12;
            label2.Text = "Serial Number :";
            // 
            // CB_matirial_searchCage
            // 
            CB_matirial_searchCage.FormattingEnabled = true;
            CB_matirial_searchCage.Items.AddRange(new object[] { "Wood", "Plastic", "Iron" });
            CB_matirial_searchCage.Location = new Point(23, 132);
            CB_matirial_searchCage.Margin = new Padding(2);
            CB_matirial_searchCage.Name = "CB_matirial_searchCage";
            CB_matirial_searchCage.Size = new Size(190, 28);
            CB_matirial_searchCage.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(23, 100);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 10;
            label6.Text = "Matirial :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(dataGV_cage_search);
            panel2.Location = new Point(196, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 352);
            panel2.TabIndex = 8;
            // 
            // dataGV_cage_search
            // 
            dataGV_cage_search.BackgroundColor = SystemColors.ButtonFace;
            dataGV_cage_search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGV_cage_search.Dock = DockStyle.Fill;
            dataGV_cage_search.GridColor = SystemColors.ButtonFace;
            dataGV_cage_search.Location = new Point(0, 0);
            dataGV_cage_search.Name = "dataGV_cage_search";
            dataGV_cage_search.RowHeadersWidth = 51;
            dataGV_cage_search.RowTemplate.Height = 29;
            dataGV_cage_search.Size = new Size(679, 352);
            dataGV_cage_search.TabIndex = 0;
            dataGV_cage_search.CellClick += dataGV_cage_search_CellClick;
            dataGV_cage_search.CellContentClick += dataGV_search_CellContentClick;
            // 
            // dataGV_bird_search
            // 
            dataGV_bird_search.BackgroundColor = SystemColors.ButtonFace;
            dataGV_bird_search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGV_bird_search.GridColor = SystemColors.ButtonFace;
            dataGV_bird_search.Location = new Point(0, 365);
            dataGV_bird_search.Name = "dataGV_bird_search";
            dataGV_bird_search.RowHeadersWidth = 51;
            dataGV_bird_search.RowTemplate.Height = 29;
            dataGV_bird_search.Size = new Size(1083, 352);
            dataGV_bird_search.TabIndex = 1;
            dataGV_bird_search.CellClick += dataGV_bird_search_CellClick;
            // 
            // label_resTitle_search
            // 
            label_resTitle_search.AutoSize = true;
            label_resTitle_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_resTitle_search.Location = new Point(451, 314);
            label_resTitle_search.Margin = new Padding(2, 0, 2, 0);
            label_resTitle_search.Name = "label_resTitle_search";
            label_resTitle_search.Size = new Size(76, 28);
            label_resTitle_search.TabIndex = 23;
            label_resTitle_search.Text = "Results:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(RB_female_addBird);
            panel1.Controls.Add(RB_male_addBird);
            panel1.Location = new Point(13, 161);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 28);
            panel1.TabIndex = 21;
            // 
            // RB_female_addBird
            // 
            RB_female_addBird.AutoSize = true;
            RB_female_addBird.BackColor = Color.White;
            RB_female_addBird.Location = new Point(114, 2);
            RB_female_addBird.Margin = new Padding(2);
            RB_female_addBird.Name = "RB_female_addBird";
            RB_female_addBird.Size = new Size(78, 24);
            RB_female_addBird.TabIndex = 12;
            RB_female_addBird.TabStop = true;
            RB_female_addBird.Text = "Female";
            RB_female_addBird.UseVisualStyleBackColor = false;
            // 
            // RB_male_addBird
            // 
            RB_male_addBird.AutoSize = true;
            RB_male_addBird.BackColor = Color.White;
            RB_male_addBird.Location = new Point(30, 3);
            RB_male_addBird.Margin = new Padding(2);
            RB_male_addBird.Name = "RB_male_addBird";
            RB_male_addBird.Size = new Size(63, 24);
            RB_male_addBird.TabIndex = 10;
            RB_male_addBird.TabStop = true;
            RB_male_addBird.Text = "Male";
            RB_male_addBird.UseVisualStyleBackColor = false;
            // 
            // Date_addBird
            // 
            Date_addBird.Location = new Point(15, 109);
            Date_addBird.Margin = new Padding(2);
            Date_addBird.Name = "Date_addBird";
            Date_addBird.Size = new Size(204, 27);
            Date_addBird.TabIndex = 18;
            // 
            // CM_type_addBird
            // 
            CM_type_addBird.FormattingEnabled = true;
            CM_type_addBird.Items.AddRange(new object[] { "Amercian Goldian", "Europe Goldian", "Austrlian Goldian" });
            CM_type_addBird.Location = new Point(185, 50);
            CM_type_addBird.Margin = new Padding(2);
            CM_type_addBird.Name = "CM_type_addBird";
            CM_type_addBird.Size = new Size(144, 28);
            CM_type_addBird.TabIndex = 17;
            CM_type_addBird.SelectedIndexChanged += CM_type_addBird_SelectedIndexChanged;
            // 
            // TB_serialNum_addBird
            // 
            TB_serialNum_addBird.Location = new Point(15, 51);
            TB_serialNum_addBird.Margin = new Padding(2);
            TB_serialNum_addBird.Name = "TB_serialNum_addBird";
            TB_serialNum_addBird.Size = new Size(144, 27);
            TB_serialNum_addBird.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 29);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 13;
            label8.Text = "Serial Number :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(185, 29);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 16;
            label9.Text = "BIrd Type";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 87);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 22;
            label10.Text = "Date:";
            // 
            // bttn_searchBird_search
            // 
            bttn_searchBird_search.Image = Properties.Resources.search;
            bttn_searchBird_search.Location = new Point(296, 140);
            bttn_searchBird_search.Name = "bttn_searchBird_search";
            bttn_searchBird_search.Size = new Size(48, 49);
            bttn_searchBird_search.SizeMode = PictureBoxSizeMode.Zoom;
            bttn_searchBird_search.TabIndex = 23;
            bttn_searchBird_search.TabStop = false;
            bttn_searchBird_search.Click += bttn_searchBird_search_Click;
            // 
            // GP_searchBird_search
            // 
            GP_searchBird_search.Controls.Add(refresh_BirdTable);
            GP_searchBird_search.Controls.Add(bttn_searchBird_search);
            GP_searchBird_search.Controls.Add(label10);
            GP_searchBird_search.Controls.Add(label9);
            GP_searchBird_search.Controls.Add(label8);
            GP_searchBird_search.Controls.Add(TB_serialNum_addBird);
            GP_searchBird_search.Controls.Add(CM_type_addBird);
            GP_searchBird_search.Controls.Add(Date_addBird);
            GP_searchBird_search.Controls.Add(panel1);
            GP_searchBird_search.Location = new Point(602, 96);
            GP_searchBird_search.Name = "GP_searchBird_search";
            GP_searchBird_search.Size = new Size(359, 208);
            GP_searchBird_search.TabIndex = 7;
            GP_searchBird_search.TabStop = false;
            GP_searchBird_search.Text = "Search Bird";
            GP_searchBird_search.Enter += groupBox2_Enter;
            // 
            // refresh_BirdTable
            // 
            refresh_BirdTable.Image = (Image)resources.GetObject("refresh_BirdTable.Image");
            refresh_BirdTable.Location = new Point(242, 158);
            refresh_BirdTable.Name = "refresh_BirdTable";
            refresh_BirdTable.Size = new Size(48, 31);
            refresh_BirdTable.SizeMode = PictureBoxSizeMode.Zoom;
            refresh_BirdTable.TabIndex = 25;
            refresh_BirdTable.TabStop = false;
            refresh_BirdTable.Click += refresh_BirdTable_Click;
            // 
            // US_Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGV_bird_search);
            Controls.Add(label_resTitle_search);
            Controls.Add(panel2);
            Controls.Add(GP_searchBird_search);
            Controls.Add(GP_searchCage_search);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "US_Search";
            Size = new Size(1083, 717);
            Load += US_Search_Load;
            GP_searchCage_search.ResumeLayout(false);
            GP_searchCage_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)refresh_CageTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)bttn_searchCage_search).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGV_cage_search).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGV_bird_search).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bttn_searchBird_search).EndInit();
            GP_searchBird_search.ResumeLayout(false);
            GP_searchBird_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)refresh_BirdTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TB_serialNum_searchCage;
        private GroupBox GP_searchCage_search;
        private Label label2;
        private ComboBox CB_matirial_searchCage;
        private Label label6;
        private Panel panel2;
        private Label label_resTitle_search;
        private PictureBox bttn_searchCage_search;
        private DataGridView dataGV_cage_search;
        private Panel panel1;
        private RadioButton RB_female_addBird;
        private RadioButton RB_male_addBird;
        private DateTimePicker Date_addBird;
        private ComboBox CM_type_addBird;
        private TextBox TB_serialNum_addBird;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox bttn_searchBird_search;
        private GroupBox GP_searchBird_search;
        private PictureBox refresh_CageTable;
        private PictureBox refresh_BirdTable;
        private DataGridView dataGV_bird_search;
    }
}
