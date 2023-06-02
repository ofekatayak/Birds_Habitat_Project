namespace BirdsProj
{
    partial class US_addBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_addBird));
            label1 = new Label();
            GB_gender = new GroupBox();
            CB_fatherSerial_addBird = new ComboBox();
            CB_motherSerial_addBird = new ComboBox();
            CB_cageNumber_addBird = new ComboBox();
            LB_subSpeciesMsg = new Label();
            LB_genderMsg = new Label();
            LB_speciesMsg = new Label();
            LB_cageMsg = new Label();
            LB_momMsg = new Label();
            LB_fatherMsg = new Label();
            LB_serialMsg = new Label();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            Date_addBird = new DateTimePicker();
            CM_subType_addBird = new ComboBox();
            label4 = new Label();
            CM_type_addBird = new ComboBox();
            label3 = new Label();
            TB_serialNum_addBird = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            RB_female_addBird = new RadioButton();
            RB_male_addBird = new RadioButton();
            BTTN_addBird_addBird = new Button();
            GB_gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(387, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 41);
            label1.TabIndex = 0;
            label1.Text = "Add Bird";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // GB_gender
            // 
            GB_gender.Controls.Add(CB_fatherSerial_addBird);
            GB_gender.Controls.Add(CB_motherSerial_addBird);
            GB_gender.Controls.Add(CB_cageNumber_addBird);
            GB_gender.Controls.Add(LB_subSpeciesMsg);
            GB_gender.Controls.Add(LB_genderMsg);
            GB_gender.Controls.Add(LB_speciesMsg);
            GB_gender.Controls.Add(LB_cageMsg);
            GB_gender.Controls.Add(LB_momMsg);
            GB_gender.Controls.Add(LB_fatherMsg);
            GB_gender.Controls.Add(LB_serialMsg);
            GB_gender.Controls.Add(pictureBox4);
            GB_gender.Controls.Add(label9);
            GB_gender.Controls.Add(label8);
            GB_gender.Controls.Add(label7);
            GB_gender.Controls.Add(label6);
            GB_gender.Controls.Add(label5);
            GB_gender.Controls.Add(Date_addBird);
            GB_gender.Controls.Add(CM_subType_addBird);
            GB_gender.Controls.Add(label4);
            GB_gender.Controls.Add(CM_type_addBird);
            GB_gender.Controls.Add(label3);
            GB_gender.Controls.Add(TB_serialNum_addBird);
            GB_gender.Controls.Add(label2);
            GB_gender.Controls.Add(panel1);
            GB_gender.Location = new Point(41, 118);
            GB_gender.Margin = new Padding(2);
            GB_gender.Name = "GB_gender";
            GB_gender.Padding = new Padding(2);
            GB_gender.Size = new Size(786, 472);
            GB_gender.TabIndex = 1;
            GB_gender.TabStop = false;
            GB_gender.Text = "Bird detailes:";
            // 
            // CB_fatherSerial_addBird
            // 
            CB_fatherSerial_addBird.FormattingEnabled = true;
            CB_fatherSerial_addBird.Location = new Point(32, 283);
            CB_fatherSerial_addBird.Margin = new Padding(2);
            CB_fatherSerial_addBird.Name = "CB_fatherSerial_addBird";
            CB_fatherSerial_addBird.Size = new Size(219, 28);
            CB_fatherSerial_addBird.TabIndex = 33;
            CB_fatherSerial_addBird.Click += CB_fatherSerial_addBird_Click;
            // 
            // CB_motherSerial_addBird
            // 
            CB_motherSerial_addBird.FormattingEnabled = true;
            CB_motherSerial_addBird.Location = new Point(294, 283);
            CB_motherSerial_addBird.Margin = new Padding(2);
            CB_motherSerial_addBird.Name = "CB_motherSerial_addBird";
            CB_motherSerial_addBird.Size = new Size(219, 28);
            CB_motherSerial_addBird.TabIndex = 32;
            CB_motherSerial_addBird.Click += CB_motherSerial_addBird_Click;
            // 
            // CB_cageNumber_addBird
            // 
            CB_cageNumber_addBird.FormattingEnabled = true;
            CB_cageNumber_addBird.Location = new Point(32, 376);
            CB_cageNumber_addBird.Name = "CB_cageNumber_addBird";
            CB_cageNumber_addBird.Size = new Size(218, 28);
            CB_cageNumber_addBird.TabIndex = 31;
            CB_cageNumber_addBird.Click += CB_cageNumber_addBird_Click;
            // 
            // LB_subSpeciesMsg
            // 
            LB_subSpeciesMsg.AutoSize = true;
            LB_subSpeciesMsg.ForeColor = Color.Red;
            LB_subSpeciesMsg.Location = new Point(296, 406);
            LB_subSpeciesMsg.Name = "LB_subSpeciesMsg";
            LB_subSpeciesMsg.Size = new Size(0, 20);
            LB_subSpeciesMsg.TabIndex = 30;
            // 
            // LB_genderMsg
            // 
            LB_genderMsg.AutoSize = true;
            LB_genderMsg.ForeColor = Color.Red;
            LB_genderMsg.Location = new Point(296, 216);
            LB_genderMsg.Name = "LB_genderMsg";
            LB_genderMsg.Size = new Size(0, 20);
            LB_genderMsg.TabIndex = 29;
            // 
            // LB_speciesMsg
            // 
            LB_speciesMsg.AutoSize = true;
            LB_speciesMsg.ForeColor = Color.Red;
            LB_speciesMsg.Location = new Point(296, 130);
            LB_speciesMsg.Name = "LB_speciesMsg";
            LB_speciesMsg.Size = new Size(0, 20);
            LB_speciesMsg.TabIndex = 28;
            // 
            // LB_cageMsg
            // 
            LB_cageMsg.AutoSize = true;
            LB_cageMsg.ForeColor = Color.Red;
            LB_cageMsg.Location = new Point(32, 406);
            LB_cageMsg.Name = "LB_cageMsg";
            LB_cageMsg.Size = new Size(0, 20);
            LB_cageMsg.TabIndex = 27;
            // 
            // LB_momMsg
            // 
            LB_momMsg.AutoSize = true;
            LB_momMsg.ForeColor = Color.Red;
            LB_momMsg.Location = new Point(302, 316);
            LB_momMsg.Name = "LB_momMsg";
            LB_momMsg.Size = new Size(0, 20);
            LB_momMsg.TabIndex = 26;
            // 
            // LB_fatherMsg
            // 
            LB_fatherMsg.AutoSize = true;
            LB_fatherMsg.ForeColor = Color.Red;
            LB_fatherMsg.Location = new Point(39, 316);
            LB_fatherMsg.Name = "LB_fatherMsg";
            LB_fatherMsg.Size = new Size(0, 20);
            LB_fatherMsg.TabIndex = 25;
            // 
            // LB_serialMsg
            // 
            LB_serialMsg.AutoSize = true;
            LB_serialMsg.ForeColor = Color.Red;
            LB_serialMsg.Location = new Point(32, 130);
            LB_serialMsg.Name = "LB_serialMsg";
            LB_serialMsg.Size = new Size(0, 20);
            LB_serialMsg.TabIndex = 24;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(526, 58);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(237, 411);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(295, 241);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 25);
            label9.TabIndex = 18;
            label9.Text = "Mother serial :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(32, 241);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(123, 25);
            label8.TabIndex = 16;
            label8.Text = "Father serial :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(28, 336);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(135, 25);
            label7.TabIndex = 14;
            label7.Text = "Cage number :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(295, 149);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 11;
            label6.Text = "Gender :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 150);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 9;
            label5.Text = "Date :";
            // 
            // Date_addBird
            // 
            Date_addBird.Location = new Point(32, 186);
            Date_addBird.Margin = new Padding(2);
            Date_addBird.Name = "Date_addBird";
            Date_addBird.Size = new Size(218, 27);
            Date_addBird.TabIndex = 8;
            // 
            // CM_subType_addBird
            // 
            CM_subType_addBird.FormattingEnabled = true;
            CM_subType_addBird.Location = new Point(295, 376);
            CM_subType_addBird.Margin = new Padding(2);
            CM_subType_addBird.Name = "CM_subType_addBird";
            CM_subType_addBird.Size = new Size(219, 28);
            CM_subType_addBird.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(295, 349);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 6;
            label4.Text = "Bird sub Type:";
            // 
            // CM_type_addBird
            // 
            CM_type_addBird.AutoCompleteSource = AutoCompleteSource.FileSystem;
            CM_type_addBird.FormattingEnabled = true;
            CM_type_addBird.Items.AddRange(new object[] { "Amercian Goldian", "Europe Goldian", "Austrlian Goldian" });
            CM_type_addBird.Location = new Point(295, 100);
            CM_type_addBird.Margin = new Padding(2);
            CM_type_addBird.Name = "CM_type_addBird";
            CM_type_addBird.Size = new Size(219, 28);
            CM_type_addBird.TabIndex = 5;
            CM_type_addBird.SelectedIndexChanged += CM_type_addBird_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(295, 58);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 4;
            label3.Text = "Bird Type:";
            // 
            // TB_serialNum_addBird
            // 
            TB_serialNum_addBird.Location = new Point(32, 101);
            TB_serialNum_addBird.Margin = new Padding(2);
            TB_serialNum_addBird.Name = "TB_serialNum_addBird";
            TB_serialNum_addBird.Size = new Size(218, 27);
            TB_serialNum_addBird.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 2;
            label2.Text = "Serial Number :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(RB_female_addBird);
            panel1.Controls.Add(RB_male_addBird);
            panel1.Location = new Point(295, 186);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 28);
            panel1.TabIndex = 13;
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
            // BTTN_addBird_addBird
            // 
            BTTN_addBird_addBird.BackColor = Color.FromArgb(238, 99, 132);
            BTTN_addBird_addBird.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTTN_addBird_addBird.ForeColor = Color.White;
            BTTN_addBird_addBird.Location = new Point(263, 621);
            BTTN_addBird_addBird.Margin = new Padding(2);
            BTTN_addBird_addBird.Name = "BTTN_addBird_addBird";
            BTTN_addBird_addBird.Size = new Size(358, 38);
            BTTN_addBird_addBird.TabIndex = 2;
            BTTN_addBird_addBird.Text = "Add";
            BTTN_addBird_addBird.UseVisualStyleBackColor = false;
            BTTN_addBird_addBird.Click += BTTN_addBird_addBird_Click;
            // 
            // US_addBird
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(BTTN_addBird_addBird);
            Controls.Add(GB_gender);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "US_addBird";
            Size = new Size(908, 712);
            GB_gender.ResumeLayout(false);
            GB_gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CB_cageNumber_addBird_Click(object sender, EventArgs e)
        {
            db.LoadDataFromTableToComboBox("CageTable", "SerialNumber", CB_cageNumber_addBird);
        }

        #endregion

        private Label label1;
        private GroupBox GB_gender;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker Date_addBird;
        private ComboBox CM_subType_addBird;
        private Label label4;
        private ComboBox CM_type_addBird;
        private Label label3;
        private TextBox TB_serialNum_addBird;
        private Label label2;
        private Panel panel1;
        private RadioButton RB_female_addBird;
        private RadioButton RB_male_addBird;
        private PictureBox pictureBox4;
        private Button BTTN_addBird_addBird;
        private Label LB_serialMsg;
        private Label LB_cageMsg;
        private Label LB_momMsg;
        private Label LB_fatherMsg;
        private Label LB_subSpeciesMsg;
        private Label LB_genderMsg;
        private Label LB_speciesMsg;
        private ComboBox CB_cageNumber_addBird;
        private ComboBox CB_fatherSerial_addBird;
        private ComboBox CB_motherSerial_addBird;
    }
}
