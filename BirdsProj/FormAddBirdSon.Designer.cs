namespace BirdsProj
{
    partial class FormAddBirdSon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddBirdSon));
            TB_serial_addSon = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            RB_female_addSon = new RadioButton();
            RB_male_addSon = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            TB_ParentSerial_addSon = new TextBox();
            LB_serialMsg = new Label();
            label5 = new Label();
            Date_addSon = new DateTimePicker();
            BTTN_addSon = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            LB_dateMsg = new Label();
            LB_ParentMsg = new Label();
            LB_genderMsg = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TB_serial_addSon
            // 
            TB_serial_addSon.Location = new Point(21, 117);
            TB_serial_addSon.Name = "TB_serial_addSon";
            TB_serial_addSon.Size = new Size(143, 27);
            TB_serial_addSon.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(242, 163);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 14;
            label6.Text = "Gender :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(RB_female_addSon);
            panel1.Controls.Add(RB_male_addSon);
            panel1.Location = new Point(242, 196);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 28);
            panel1.TabIndex = 15;
            // 
            // RB_female_addSon
            // 
            RB_female_addSon.AutoSize = true;
            RB_female_addSon.BackColor = Color.White;
            RB_female_addSon.Location = new Point(114, 3);
            RB_female_addSon.Margin = new Padding(2, 3, 2, 3);
            RB_female_addSon.Name = "RB_female_addSon";
            RB_female_addSon.Size = new Size(78, 24);
            RB_female_addSon.TabIndex = 12;
            RB_female_addSon.TabStop = true;
            RB_female_addSon.Text = "Female";
            RB_female_addSon.UseVisualStyleBackColor = false;
            // 
            // RB_male_addSon
            // 
            RB_male_addSon.AutoSize = true;
            RB_male_addSon.BackColor = Color.White;
            RB_male_addSon.Location = new Point(23, 4);
            RB_male_addSon.Margin = new Padding(2, 3, 2, 3);
            RB_male_addSon.Name = "RB_male_addSon";
            RB_male_addSon.Size = new Size(63, 24);
            RB_male_addSon.TabIndex = 10;
            RB_male_addSon.TabStop = true;
            RB_male_addSon.Text = "Male";
            RB_male_addSon.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 77);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 16;
            label1.Text = "Serial number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 163);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 18;
            label2.Text = "Second Parent Serial:";
            // 
            // TB_ParentSerial_addSon
            // 
            TB_ParentSerial_addSon.Location = new Point(21, 196);
            TB_ParentSerial_addSon.Name = "TB_ParentSerial_addSon";
            TB_ParentSerial_addSon.Size = new Size(143, 27);
            TB_ParentSerial_addSon.TabIndex = 17;
            // 
            // LB_serialMsg
            // 
            LB_serialMsg.AutoSize = true;
            LB_serialMsg.ForeColor = Color.Red;
            LB_serialMsg.Location = new Point(21, 147);
            LB_serialMsg.Name = "LB_serialMsg";
            LB_serialMsg.Size = new Size(0, 20);
            LB_serialMsg.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(242, 77);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 26;
            label5.Text = "Date Of Birth:";
            // 
            // Date_addSon
            // 
            Date_addSon.Location = new Point(242, 115);
            Date_addSon.Margin = new Padding(2, 3, 2, 3);
            Date_addSon.Name = "Date_addSon";
            Date_addSon.Size = new Size(218, 27);
            Date_addSon.TabIndex = 25;
            // 
            // BTTN_addSon
            // 
            BTTN_addSon.BackColor = Color.FromArgb(238, 99, 132);
            BTTN_addSon.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BTTN_addSon.ForeColor = Color.White;
            BTTN_addSon.Location = new Point(213, 245);
            BTTN_addSon.Margin = new Padding(2, 3, 2, 3);
            BTTN_addSon.Name = "BTTN_addSon";
            BTTN_addSon.Size = new Size(138, 32);
            BTTN_addSon.TabIndex = 28;
            BTTN_addSon.Text = "Add";
            BTTN_addSon.UseVisualStyleBackColor = false;
            BTTN_addSon.Click += BTTN_addSon_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(485, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(40, 17, 88);
            label4.Location = new Point(226, 25);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 30);
            label4.TabIndex = 31;
            label4.Text = "Add Son:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(43, 144);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 32;
            // 
            // LB_dateMsg
            // 
            LB_dateMsg.AutoSize = true;
            LB_dateMsg.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LB_dateMsg.ForeColor = Color.Red;
            LB_dateMsg.Location = new Point(242, 145);
            LB_dateMsg.Name = "LB_dateMsg";
            LB_dateMsg.Size = new Size(0, 19);
            LB_dateMsg.TabIndex = 33;
            // 
            // LB_ParentMsg
            // 
            LB_ParentMsg.AutoSize = true;
            LB_ParentMsg.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LB_ParentMsg.ForeColor = Color.Red;
            LB_ParentMsg.Location = new Point(21, 226);
            LB_ParentMsg.Name = "LB_ParentMsg";
            LB_ParentMsg.Size = new Size(0, 19);
            LB_ParentMsg.TabIndex = 34;
            // 
            // LB_genderMsg
            // 
            LB_genderMsg.AutoSize = true;
            LB_genderMsg.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LB_genderMsg.ForeColor = Color.Red;
            LB_genderMsg.Location = new Point(242, 223);
            LB_genderMsg.Name = "LB_genderMsg";
            LB_genderMsg.Size = new Size(0, 19);
            LB_genderMsg.TabIndex = 35;
            // 
            // FormAddBirdSon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(633, 288);
            Controls.Add(LB_genderMsg);
            Controls.Add(LB_ParentMsg);
            Controls.Add(LB_dateMsg);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(BTTN_addSon);
            Controls.Add(LB_serialMsg);
            Controls.Add(label5);
            Controls.Add(Date_addSon);
            Controls.Add(label2);
            Controls.Add(TB_ParentSerial_addSon);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(TB_serial_addSon);
            Name = "FormAddBirdSon";
            Text = "FormAddBirdSon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_serial_addSon;
        private Label label6;
        private Panel panel1;
        private RadioButton RB_female_addSon;
        private RadioButton RB_male_addSon;
        private Label label1;
        private Label label2;
        private TextBox TB_ParentSerial_addSon;
        private Label LB_serialMsg;
        private Label label5;
        private DateTimePicker Date_addSon;
        private Button BTTN_addSon;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label LB_dateMsg;
        private Label LB_ParentMsg;
        private Label LB_genderMsg;
    }
}