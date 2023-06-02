namespace BirdsProj
{
    partial class FormCageProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCageProfile));
            icon_save_cageProfile = new PictureBox();
            panel2 = new Panel();
            TB_widht_cageProfile = new TextBox();
            LB_genderMsg = new Label();
            CB_matirial_cageProfile = new ComboBox();
            TB_height_cageProfile = new TextBox();
            TB_length_cageProfile = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            lable_serial_cageProfile = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            GV_birdsinCage_cageProfilr = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)icon_save_cageProfile).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GV_birdsinCage_cageProfilr).BeginInit();
            SuspendLayout();
            // 
            // icon_save_cageProfile
            // 
            icon_save_cageProfile.Image = (Image)resources.GetObject("icon_save_cageProfile.Image");
            icon_save_cageProfile.Location = new Point(508, 165);
            icon_save_cageProfile.Name = "icon_save_cageProfile";
            icon_save_cageProfile.Size = new Size(50, 46);
            icon_save_cageProfile.SizeMode = PictureBoxSizeMode.Zoom;
            icon_save_cageProfile.TabIndex = 26;
            icon_save_cageProfile.TabStop = false;
            icon_save_cageProfile.Click += icon_save_birdProfile_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(icon_save_cageProfile);
            panel2.Controls.Add(TB_widht_cageProfile);
            panel2.Controls.Add(LB_genderMsg);
            panel2.Controls.Add(CB_matirial_cageProfile);
            panel2.Controls.Add(TB_height_cageProfile);
            panel2.Controls.Add(TB_length_cageProfile);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(241, 262);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 212);
            panel2.TabIndex = 23;
            // 
            // TB_widht_cageProfile
            // 
            TB_widht_cageProfile.Location = new Point(244, 62);
            TB_widht_cageProfile.Name = "TB_widht_cageProfile";
            TB_widht_cageProfile.Size = new Size(208, 27);
            TB_widht_cageProfile.TabIndex = 33;
            // 
            // LB_genderMsg
            // 
            LB_genderMsg.AutoSize = true;
            LB_genderMsg.ForeColor = Color.Red;
            LB_genderMsg.Location = new Point(171, 171);
            LB_genderMsg.Name = "LB_genderMsg";
            LB_genderMsg.Size = new Size(0, 20);
            LB_genderMsg.TabIndex = 31;
            // 
            // CB_matirial_cageProfile
            // 
            CB_matirial_cageProfile.AutoCompleteCustomSource.AddRange(new string[] { "Amercian Goldian", "Europe Goldian", "Austrlian Goldian" });
            CB_matirial_cageProfile.FormattingEnabled = true;
            CB_matirial_cageProfile.Items.AddRange(new object[] { "Wood", "Plastic", "Iron" });
            CB_matirial_cageProfile.Location = new Point(243, 150);
            CB_matirial_cageProfile.Name = "CB_matirial_cageProfile";
            CB_matirial_cageProfile.Size = new Size(208, 28);
            CB_matirial_cageProfile.TabIndex = 24;
            // 
            // TB_height_cageProfile
            // 
            TB_height_cageProfile.Location = new Point(243, 19);
            TB_height_cageProfile.Name = "TB_height_cageProfile";
            TB_height_cageProfile.Size = new Size(208, 27);
            TB_height_cageProfile.TabIndex = 20;
            // 
            // TB_length_cageProfile
            // 
            TB_length_cageProfile.Location = new Point(245, 106);
            TB_length_cageProfile.Name = "TB_length_cageProfile";
            TB_length_cageProfile.Size = new Size(208, 27);
            TB_length_cageProfile.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(238, 99, 132);
            label1.Location = new Point(86, 19);
            label1.Name = "label1";
            label1.Size = new Size(90, 30);
            label1.TabIndex = 4;
            label1.Text = "Height:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(238, 99, 132);
            label4.Location = new Point(88, 59);
            label4.Name = "label4";
            label4.Size = new Size(83, 30);
            label4.TabIndex = 6;
            label4.Text = "Widht:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(238, 99, 132);
            label5.Location = new Point(88, 145);
            label5.Name = "label5";
            label5.Size = new Size(100, 30);
            label5.TabIndex = 10;
            label5.Text = "Matirial:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(238, 99, 132);
            label3.Location = new Point(88, 103);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 8;
            label3.Text = "Length:";
            // 
            // lable_serial_cageProfile
            // 
            lable_serial_cageProfile.AutoSize = true;
            lable_serial_cageProfile.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lable_serial_cageProfile.ForeColor = Color.FromArgb(40, 17, 88);
            lable_serial_cageProfile.Location = new Point(507, 217);
            lable_serial_cageProfile.Name = "lable_serial_cageProfile";
            lable_serial_cageProfile.Size = new Size(42, 32);
            lable_serial_cageProfile.TabIndex = 20;
            lable_serial_cageProfile.Text = "#1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 147);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(449, 29);
            label2.Name = "label2";
            label2.Size = new Size(160, 32);
            label2.TabIndex = 15;
            label2.Text = "Cage Profile:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.WhatsApp_Image_2023_04_21_at_03_35_10;
            pictureBox2.Location = new Point(463, 101);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // GV_birdsinCage_cageProfilr
            // 
            GV_birdsinCage_cageProfilr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GV_birdsinCage_cageProfilr.Location = new Point(0, 516);
            GV_birdsinCage_cageProfilr.Name = "GV_birdsinCage_cageProfilr";
            GV_birdsinCage_cageProfilr.RowHeadersWidth = 51;
            GV_birdsinCage_cageProfilr.RowTemplate.Height = 29;
            GV_birdsinCage_cageProfilr.Size = new Size(1036, 165);
            GV_birdsinCage_cageProfilr.TabIndex = 28;
            GV_birdsinCage_cageProfilr.CellClick += GV_birdsinCage_cageProfilr_CellClick;
            GV_birdsinCage_cageProfilr.CellContentClick += GV_birdsinCage_cageProfilr_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(40, 17, 88);
            label6.Location = new Point(463, 490);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 16;
            label6.Text = "Birds In Cage:";
            // 
            // FormCageProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 697);
            Controls.Add(label6);
            Controls.Add(GV_birdsinCage_cageProfilr);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(lable_serial_cageProfile);
            Controls.Add(panel1);
            Name = "FormCageProfile";
            Text = "FormCageProfile";
            Load += FormCageProfile_Load;
            ((System.ComponentModel.ISupportInitialize)icon_save_cageProfile).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)GV_birdsinCage_cageProfilr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox icon_save_cageProfile;
        private Panel panel2;
        private Label LB_genderMsg;
        private ComboBox CB_matirial_cageProfile;
        private TextBox TB_height_cageProfile;
        private TextBox TB_length_cageProfile;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label lable_serial_cageProfile;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox TB_widht_cageProfile;
        private DataGridView GV_birdsinCage_cageProfilr;
        private Label label6;
    }
}