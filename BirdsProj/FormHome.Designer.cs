namespace BirdsProj
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            lable_title_Form1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            uS_addCage1 = new US_addCage();
            uS_addBird1 = new US_addBird();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            LB_search_Home = new Label();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            LB_addCage_Home = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            LB_addBird_Home = new Label();
            label1 = new Label();
            uS_Search1 = new US_Search();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lable_title_Form1
            // 
            lable_title_Form1.AutoSize = true;
            lable_title_Form1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lable_title_Form1.ForeColor = SystemColors.ButtonHighlight;
            lable_title_Form1.Location = new Point(91, 18);
            lable_title_Form1.Margin = new Padding(2, 0, 2, 0);
            lable_title_Form1.Name = "lable_title_Form1";
            lable_title_Form1.Size = new Size(95, 37);
            lable_title_Form1.TabIndex = 3;
            lable_title_Form1.Text = "Home";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(91, 86);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 717);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel8);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(293, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(913, 717);
            panel4.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(uS_addCage1);
            panel8.Controls.Add(uS_addBird1);
            panel8.Location = new Point(2, 2);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(908, 712);
            panel8.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Location = new Point(191, 220);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(340, 290);
            panel9.TabIndex = 4;
            // 
            // uS_addCage1
            // 
            uS_addCage1.BackColor = Color.White;
            uS_addCage1.Location = new Point(-2, -2);
            uS_addCage1.Margin = new Padding(1);
            uS_addCage1.Name = "uS_addCage1";
            uS_addCage1.Size = new Size(912, 717);
            uS_addCage1.TabIndex = 1;
            // 
            // uS_addBird1
            // 
            uS_addBird1.BackColor = Color.White;
            uS_addBird1.Location = new Point(-2, -2);
            uS_addBird1.Margin = new Padding(1);
            uS_addBird1.Name = "uS_addBird1";
            uS_addBird1.Size = new Size(912, 715);
            uS_addBird1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 247, 247);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 717);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._82ab58e1_6bca_42d5_bdc8_ca43502d594e_2;
            pictureBox2.Location = new Point(23, 18);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(238, 99, 132);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(55, 523);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(247, 61);
            panel7.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(72, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 35);
            label2.TabIndex = 14;
            label2.Text = "LogOut";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(LB_search_Home);
            panel6.Location = new Point(54, 356);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(246, 64);
            panel6.TabIndex = 16;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(4, 6);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // LB_search_Home
            // 
            LB_search_Home.AutoSize = true;
            LB_search_Home.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LB_search_Home.ForeColor = Color.FromArgb(40, 17, 88);
            LB_search_Home.Location = new Point(71, 14);
            LB_search_Home.Margin = new Padding(2, 0, 2, 0);
            LB_search_Home.Name = "LB_search_Home";
            LB_search_Home.Size = new Size(96, 35);
            LB_search_Home.TabIndex = 14;
            LB_search_Home.Text = "Search ";
            LB_search_Home.TextAlign = ContentAlignment.TopCenter;
            LB_search_Home.Click += LB_search_Home_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(LB_addCage_Home);
            panel5.Location = new Point(54, 257);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(246, 64);
            panel5.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2023_04_21_at_16_30_42;
            pictureBox1.Location = new Point(6, 4);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // LB_addCage_Home
            // 
            LB_addCage_Home.AutoSize = true;
            LB_addCage_Home.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LB_addCage_Home.ForeColor = Color.FromArgb(40, 17, 88);
            LB_addCage_Home.Location = new Point(71, 13);
            LB_addCage_Home.Margin = new Padding(2, 0, 2, 0);
            LB_addCage_Home.Name = "LB_addCage_Home";
            LB_addCage_Home.Size = new Size(124, 35);
            LB_addCage_Home.TabIndex = 14;
            LB_addCage_Home.Text = "Add Cage";
            LB_addCage_Home.TextAlign = ContentAlignment.TopCenter;
            LB_addCage_Home.Click += LB_addCage_Home_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(LB_addBird_Home);
            panel3.Location = new Point(54, 158);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 64);
            panel3.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1, 4);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // LB_addBird_Home
            // 
            LB_addBird_Home.AutoSize = true;
            LB_addBird_Home.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LB_addBird_Home.ForeColor = Color.FromArgb(40, 17, 88);
            LB_addBird_Home.Location = new Point(71, 13);
            LB_addBird_Home.Margin = new Padding(2, 0, 2, 0);
            LB_addBird_Home.Name = "LB_addBird_Home";
            LB_addBird_Home.Size = new Size(112, 35);
            LB_addBird_Home.TabIndex = 14;
            LB_addBird_Home.Text = "Add Bird";
            LB_addBird_Home.TextAlign = ContentAlignment.TopCenter;
            LB_addBird_Home.Click += LB_addBird_Home_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(137, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 37);
            label1.TabIndex = 4;
            label1.Text = "Menu";
            // 
            // uS_Search1
            // 
            uS_Search1.BackColor = Color.White;
            uS_Search1.Location = new Point(384, 86);
            uS_Search1.Margin = new Padding(1);
            uS_Search1.Name = "uS_Search1";
            uS_Search1.Size = new Size(1048, 716);
            uS_Search1.TabIndex = 2;
            uS_Search1.Load += uS_Search1_Load;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1516, 906);
            Controls.Add(uS_Search1);
            Controls.Add(lable_title_Form1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FormHome";
            Text = "FormHome";
            Load += FormHome_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lable_title_Form1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel7;
        private Label label2;
        private Panel panel6;
        private Label LB_search_Home;
        private Panel panel5;
        private Label LB_addCage_Home;
        private Panel panel3;
        private Label LB_addBird_Home;
        private Label label1;
        private Panel panel8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private US_addCage uS_addCage1;
        private US_addBird uS_addBird1;
        private US_Search uS_Search1;
        private Panel panel9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}