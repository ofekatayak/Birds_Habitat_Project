namespace BirdsProj
{
    partial class FormBirdProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBirdProfile));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lable_serial_birdProfile = new Label();
            label_type_birdProfile = new Label();
            lable_gender_birdProfile = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            CB_cageNum_birdProfile = new ComboBox();
            LB_cage = new Label();
            LB_gender = new Label();
            LB_species = new Label();
            LB_dad = new Label();
            LB_mom = new Label();
            LB_sub = new Label();
            LB_date = new Label();
            label8 = new Label();
            LB_genderMsg = new Label();
            panel3 = new Panel();
            RB_female_birdProfile = new RadioButton();
            RB_male_birdProfile = new RadioButton();
            CB_species_birdProfile = new ComboBox();
            label7 = new Label();
            Date_date_birdProfile = new DateTimePicker();
            CB_subSpecies_birdProfile = new ComboBox();
            textTB_dadSerial_birdProfile = new TextBox();
            TB_momSerial_birdProfile = new TextBox();
            icon_delete_birdProfile = new PictureBox();
            BTTN_addSon_birdProfile = new Button();
            icon_save_birdProfile = new PictureBox();
            CB_cageNumber_birdProfile = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_delete_birdProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_save_birdProfile).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 147);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(449, 29);
            label2.Name = "label2";
            label2.Size = new Size(151, 32);
            label2.TabIndex = 15;
            label2.Text = "Bird Profile:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2023_05_24_at_00_041;
            pictureBox1.Location = new Point(460, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lable_serial_birdProfile
            // 
            lable_serial_birdProfile.AutoSize = true;
            lable_serial_birdProfile.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lable_serial_birdProfile.ForeColor = Color.FromArgb(40, 17, 88);
            lable_serial_birdProfile.Location = new Point(501, 230);
            lable_serial_birdProfile.Name = "lable_serial_birdProfile";
            lable_serial_birdProfile.Size = new Size(42, 32);
            lable_serial_birdProfile.TabIndex = 1;
            lable_serial_birdProfile.Text = "#1";
            // 
            // label_type_birdProfile
            // 
            label_type_birdProfile.AutoSize = true;
            label_type_birdProfile.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_type_birdProfile.ForeColor = Color.FromArgb(40, 17, 88);
            label_type_birdProfile.Location = new Point(125, 182);
            label_type_birdProfile.Name = "label_type_birdProfile";
            label_type_birdProfile.Size = new Size(83, 32);
            label_type_birdProfile.TabIndex = 2;
            label_type_birdProfile.Text = "label1";
            // 
            // lable_gender_birdProfile
            // 
            lable_gender_birdProfile.AutoSize = true;
            lable_gender_birdProfile.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lable_gender_birdProfile.ForeColor = Color.FromArgb(40, 17, 88);
            lable_gender_birdProfile.Location = new Point(830, 182);
            lable_gender_birdProfile.Name = "lable_gender_birdProfile";
            lable_gender_birdProfile.Size = new Size(83, 32);
            lable_gender_birdProfile.TabIndex = 3;
            lable_gender_birdProfile.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(238, 99, 132);
            label1.Location = new Point(86, 19);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 4;
            label1.Text = "Date Of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(238, 99, 132);
            label4.Location = new Point(88, 59);
            label4.Name = "label4";
            label4.Size = new Size(141, 30);
            label4.TabIndex = 6;
            label4.Text = "Sub Species:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(238, 99, 132);
            label3.Location = new Point(88, 103);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 8;
            label3.Text = "Mom Serial:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(238, 99, 132);
            label5.Location = new Point(88, 145);
            label5.Name = "label5";
            label5.Size = new Size(124, 30);
            label5.TabIndex = 10;
            label5.Text = "Dad Serial:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(238, 99, 132);
            label6.Location = new Point(88, 280);
            label6.Name = "label6";
            label6.Size = new Size(71, 30);
            label6.TabIndex = 12;
            label6.Text = "Cage:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(CB_cageNum_birdProfile);
            panel2.Controls.Add(LB_cage);
            panel2.Controls.Add(LB_gender);
            panel2.Controls.Add(LB_species);
            panel2.Controls.Add(LB_dad);
            panel2.Controls.Add(LB_mom);
            panel2.Controls.Add(LB_sub);
            panel2.Controls.Add(LB_date);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(LB_genderMsg);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(CB_species_birdProfile);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(Date_date_birdProfile);
            panel2.Controls.Add(CB_subSpecies_birdProfile);
            panel2.Controls.Add(textTB_dadSerial_birdProfile);
            panel2.Controls.Add(TB_momSerial_birdProfile);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(242, 285);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 333);
            panel2.TabIndex = 14;
            // 
            // CB_cageNum_birdProfile
            // 
            CB_cageNum_birdProfile.AutoCompleteCustomSource.AddRange(new string[] { "Amercian Goldian", "Europe Goldian", "Austrlian Goldian" });
            CB_cageNum_birdProfile.FormattingEnabled = true;
            CB_cageNum_birdProfile.Items.AddRange(new object[] { "Amercian Goldian", "Europe Goldian", "Austrlian Goldian" });
            CB_cageNum_birdProfile.Location = new Point(245, 282);
            CB_cageNum_birdProfile.Name = "CB_cageNum_birdProfile";
            CB_cageNum_birdProfile.Size = new Size(208, 28);
            CB_cageNum_birdProfile.TabIndex = 40;
            CB_cageNum_birdProfile.Click += CB_cageNum_addBird_Click;
            // 
            // LB_cage
            // 
            LB_cage.AutoSize = true;
            LB_cage.ForeColor = Color.Red;
            LB_cage.Location = new Point(92, 310);
            LB_cage.Name = "LB_cage";
            LB_cage.Size = new Size(0, 20);
            LB_cage.TabIndex = 39;
            // 
            // LB_gender
            // 
            LB_gender.AutoSize = true;
            LB_gender.ForeColor = Color.Red;
            LB_gender.Location = new Point(92, 260);
            LB_gender.Name = "LB_gender";
            LB_gender.Size = new Size(0, 20);
            LB_gender.TabIndex = 38;
            // 
            // LB_species
            // 
            LB_species.AutoSize = true;
            LB_species.ForeColor = Color.Red;
            LB_species.Location = new Point(92, 217);
            LB_species.Name = "LB_species";
            LB_species.Size = new Size(0, 20);
            LB_species.TabIndex = 37;
            // 
            // LB_dad
            // 
            LB_dad.AutoSize = true;
            LB_dad.ForeColor = Color.Red;
            LB_dad.Location = new Point(92, 171);
            LB_dad.Name = "LB_dad";
            LB_dad.Size = new Size(0, 20);
            LB_dad.TabIndex = 36;
            // 
            // LB_mom
            // 
            LB_mom.AutoSize = true;
            LB_mom.ForeColor = Color.Red;
            LB_mom.Location = new Point(92, 133);
            LB_mom.Name = "LB_mom";
            LB_mom.Size = new Size(0, 20);
            LB_mom.TabIndex = 35;
            // 
            // LB_sub
            // 
            LB_sub.AutoSize = true;
            LB_sub.ForeColor = Color.Red;
            LB_sub.Location = new Point(92, 89);
            LB_sub.Name = "LB_sub";
            LB_sub.Size = new Size(0, 20);
            LB_sub.TabIndex = 34;
            // 
            // LB_date
            // 
            LB_date.AutoSize = true;
            LB_date.ForeColor = Color.Red;
            LB_date.Location = new Point(92, 45);
            LB_date.Name = "LB_date";
            LB_date.Size = new Size(0, 20);
            LB_date.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(238, 99, 132);
            label8.Location = new Point(88, 234);
            label8.Name = "label8";
            label8.Size = new Size(96, 30);
            label8.TabIndex = 32;
            label8.Text = "Gender:";
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(RB_female_birdProfile);
            panel3.Controls.Add(RB_male_birdProfile);
            panel3.Location = new Point(245, 237);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 28);
            panel3.TabIndex = 30;
            // 
            // RB_female_birdProfile
            // 
            RB_female_birdProfile.AutoSize = true;
            RB_female_birdProfile.BackColor = Color.White;
            RB_female_birdProfile.Location = new Point(114, 2);
            RB_female_birdProfile.Margin = new Padding(2);
            RB_female_birdProfile.Name = "RB_female_birdProfile";
            RB_female_birdProfile.Size = new Size(78, 24);
            RB_female_birdProfile.TabIndex = 12;
            RB_female_birdProfile.TabStop = true;
            RB_female_birdProfile.Text = "Female";
            RB_female_birdProfile.UseVisualStyleBackColor = false;
            // 
            // RB_male_birdProfile
            // 
            RB_male_birdProfile.AutoSize = true;
            RB_male_birdProfile.BackColor = Color.White;
            RB_male_birdProfile.Location = new Point(30, 3);
            RB_male_birdProfile.Margin = new Padding(2);
            RB_male_birdProfile.Name = "RB_male_birdProfile";
            RB_male_birdProfile.Size = new Size(63, 24);
            RB_male_birdProfile.TabIndex = 10;
            RB_male_birdProfile.TabStop = true;
            RB_male_birdProfile.Text = "Male";
            RB_male_birdProfile.UseVisualStyleBackColor = false;
            // 
            // CB_species_birdProfile
            // 
            CB_species_birdProfile.AutoCompleteCustomSource.AddRange(new string[] { "Amercian Goldian", "Europe Goldian", "Austrlian Goldian" });
            CB_species_birdProfile.FormattingEnabled = true;
            CB_species_birdProfile.Items.AddRange(new object[] { "Amercian Goldian", "Europe Goldian", "Austrlian Goldian" });
            CB_species_birdProfile.Location = new Point(245, 192);
            CB_species_birdProfile.Name = "CB_species_birdProfile";
            CB_species_birdProfile.Size = new Size(208, 28);
            CB_species_birdProfile.TabIndex = 24;
            CB_species_birdProfile.SelectedIndexChanged += CB_species_birdProfile_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(238, 99, 132);
            label7.Location = new Point(88, 187);
            label7.Name = "label7";
            label7.Size = new Size(96, 30);
            label7.TabIndex = 23;
            label7.Text = "Species:";
            // 
            // Date_date_birdProfile
            // 
            Date_date_birdProfile.Location = new Point(245, 19);
            Date_date_birdProfile.Margin = new Padding(2);
            Date_date_birdProfile.Name = "Date_date_birdProfile";
            Date_date_birdProfile.Size = new Size(208, 27);
            Date_date_birdProfile.TabIndex = 22;
            // 
            // CB_subSpecies_birdProfile
            // 
            CB_subSpecies_birdProfile.FormattingEnabled = true;
            CB_subSpecies_birdProfile.Location = new Point(245, 64);
            CB_subSpecies_birdProfile.Name = "CB_subSpecies_birdProfile";
            CB_subSpecies_birdProfile.Size = new Size(208, 28);
            CB_subSpecies_birdProfile.TabIndex = 21;
            // 
            // textTB_dadSerial_birdProfile
            // 
            textTB_dadSerial_birdProfile.Location = new Point(245, 148);
            textTB_dadSerial_birdProfile.Name = "textTB_dadSerial_birdProfile";
            textTB_dadSerial_birdProfile.Size = new Size(208, 27);
            textTB_dadSerial_birdProfile.TabIndex = 19;
            // 
            // TB_momSerial_birdProfile
            // 
            TB_momSerial_birdProfile.Location = new Point(245, 106);
            TB_momSerial_birdProfile.Name = "TB_momSerial_birdProfile";
            TB_momSerial_birdProfile.Size = new Size(208, 27);
            TB_momSerial_birdProfile.TabIndex = 18;
            // 
            // icon_delete_birdProfile
            // 
            icon_delete_birdProfile.Image = Properties.Resources.WhatsApp_Image_2023_05_24_at_03_01_49;
            icon_delete_birdProfile.Location = new Point(661, 640);
            icon_delete_birdProfile.Name = "icon_delete_birdProfile";
            icon_delete_birdProfile.Size = new Size(50, 46);
            icon_delete_birdProfile.SizeMode = PictureBoxSizeMode.Zoom;
            icon_delete_birdProfile.TabIndex = 16;
            icon_delete_birdProfile.TabStop = false;
            icon_delete_birdProfile.Click += pictureBox2_Click;
            // 
            // BTTN_addSon_birdProfile
            // 
            BTTN_addSon_birdProfile.BackColor = Color.FromArgb(238, 99, 132);
            BTTN_addSon_birdProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTTN_addSon_birdProfile.ForeColor = Color.White;
            BTTN_addSon_birdProfile.Location = new Point(413, 640);
            BTTN_addSon_birdProfile.Margin = new Padding(2);
            BTTN_addSon_birdProfile.Name = "BTTN_addSon_birdProfile";
            BTTN_addSon_birdProfile.Size = new Size(243, 46);
            BTTN_addSon_birdProfile.TabIndex = 15;
            BTTN_addSon_birdProfile.Text = "Add son";
            BTTN_addSon_birdProfile.UseVisualStyleBackColor = false;
            BTTN_addSon_birdProfile.Click += BTTN_addSon_birdProfile_Click;
            // 
            // icon_save_birdProfile
            // 
            icon_save_birdProfile.Image = (Image)resources.GetObject("icon_save_birdProfile.Image");
            icon_save_birdProfile.Location = new Point(358, 640);
            icon_save_birdProfile.Name = "icon_save_birdProfile";
            icon_save_birdProfile.Size = new Size(50, 46);
            icon_save_birdProfile.SizeMode = PictureBoxSizeMode.Zoom;
            icon_save_birdProfile.TabIndex = 17;
            icon_save_birdProfile.TabStop = false;
            icon_save_birdProfile.Click += icon_save_birdProfile_Click;
            // 
            // CB_cageNumber_birdProfile
            // 
            CB_cageNumber_birdProfile.FormattingEnabled = true;
            CB_cageNumber_birdProfile.Location = new Point(245, 280);
            CB_cageNumber_birdProfile.Name = "CB_cageNumber_birdProfile";
            CB_cageNumber_birdProfile.Size = new Size(218, 28);
            CB_cageNumber_birdProfile.TabIndex = 32;
            CB_cageNumber_birdProfile.Click += CB_cageNumber_birdProfile_Click;
            // 
            // FormBirdProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 697);
            Controls.Add(icon_save_birdProfile);
            Controls.Add(BTTN_addSon_birdProfile);
            Controls.Add(panel2);
            Controls.Add(lable_gender_birdProfile);
            Controls.Add(label_type_birdProfile);
            Controls.Add(lable_serial_birdProfile);
            Controls.Add(icon_delete_birdProfile);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "FormBirdProfile";
            Text = "FormBirdProfile";
            Load += FormBirdProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_delete_birdProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_save_birdProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CB_cageNumber_birdProfile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lable_serial_birdProfile;
        private Label label_type_birdProfile;
        private Label lable_gender_birdProfile;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Label label2;
        private Button BTTN_addSon_birdProfile;
        private PictureBox icon_delete_birdProfile;
        private TextBox textTB_dadSerial_birdProfile;
        private TextBox TB_momSerial_birdProfile;
        private ComboBox CB_subSpecies_birdProfile;
        private DateTimePicker Date_date_birdProfile;
        private ComboBox CB_species_birdProfile;
        private Label label7;
        private Label label8;
        private Label LB_genderMsg;
        private Panel panel3;
        private RadioButton RB_female_birdProfile;
        private RadioButton RB_male_birdProfile;
        private PictureBox icon_save_birdProfile;
        private ComboBox CB_cageNumber_birdProfile;
        private Label LB_dad;
        private Label LB_cage;
        private Label LB_species;
        private Label LB_gender;
        private Label LB_sub;
        private Label LB_date;
        private Label LB_mom;
        private ComboBox CB_cageNum_birdProfile;
    }
}