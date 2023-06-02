namespace BirdsProj
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            panel4 = new Panel();
            BTTN_login = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TB_pass_login = new TextBox();
            TB_userName_login = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lable_title_Form1 = new Label();
            lable_userName_login = new Label();
            label_pass_login = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(89, 72);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 717);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label_pass_login);
            panel4.Controls.Add(lable_userName_login);
            panel4.Controls.Add(BTTN_login);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(TB_pass_login);
            panel4.Controls.Add(TB_userName_login);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(364, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(842, 717);
            panel4.TabIndex = 1;
            // 
            // BTTN_login
            // 
            BTTN_login.BackColor = Color.FromArgb(238, 99, 132);
            BTTN_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTTN_login.ForeColor = Color.White;
            BTTN_login.Location = new Point(302, 513);
            BTTN_login.Margin = new Padding(2);
            BTTN_login.Name = "BTTN_login";
            BTTN_login.Size = new Size(243, 46);
            BTTN_login.TabIndex = 9;
            BTTN_login.Text = "Login";
            BTTN_login.UseVisualStyleBackColor = false;
            BTTN_login.Click += BTTN_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._82ab58e1_6bca_42d5_bdc8_ca43502d594e_2;
            pictureBox1.Location = new Point(319, 41);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(40, 17, 88);
            label5.Location = new Point(383, 638);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 7;
            label5.Text = "SignUp";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ScrollBar;
            label4.Location = new Point(318, 606);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(216, 28);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account?";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(40, 17, 88);
            label3.Location = new Point(79, 408);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 35);
            label3.TabIndex = 5;
            label3.Text = "Password :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(40, 17, 88);
            label2.Location = new Point(79, 294);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 35);
            label2.TabIndex = 4;
            label2.Text = "User name : ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // TB_pass_login
            // 
            TB_pass_login.Location = new Point(279, 400);
            TB_pass_login.Margin = new Padding(2);
            TB_pass_login.Multiline = true;
            TB_pass_login.Name = "TB_pass_login";
            TB_pass_login.Size = new Size(308, 49);
            TB_pass_login.TabIndex = 3;
            TB_pass_login.TextChanged += textBox3_TextChanged;
            // 
            // TB_userName_login
            // 
            TB_userName_login.Location = new Point(279, 286);
            TB_userName_login.Margin = new Padding(2);
            TB_userName_login.Multiline = true;
            TB_userName_login.Name = "TB_userName_login";
            TB_userName_login.Size = new Size(308, 49);
            TB_userName_login.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(302, 188);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 40);
            label1.TabIndex = 0;
            label1.Text = "Welcome back!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 717);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 156);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(368, 404);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // lable_title_Form1
            // 
            lable_title_Form1.AutoSize = true;
            lable_title_Form1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lable_title_Form1.ForeColor = SystemColors.ButtonHighlight;
            lable_title_Form1.Location = new Point(671, 17);
            lable_title_Form1.Margin = new Padding(2, 0, 2, 0);
            lable_title_Form1.Name = "lable_title_Form1";
            lable_title_Form1.Size = new Size(89, 37);
            lable_title_Form1.TabIndex = 1;
            lable_title_Form1.Text = "Login";
            // 
            // lable_userName_login
            // 
            lable_userName_login.AutoSize = true;
            lable_userName_login.ForeColor = Color.FromArgb(238, 99, 132);
            lable_userName_login.Location = new Point(284, 338);
            lable_userName_login.Name = "lable_userName_login";
            lable_userName_login.Size = new Size(0, 20);
            lable_userName_login.TabIndex = 10;
            // 
            // label_pass_login
            // 
            label_pass_login.AutoSize = true;
            label_pass_login.ForeColor = Color.FromArgb(238, 99, 132);
            label_pass_login.Location = new Point(284, 451);
            label_pass_login.Name = "label_pass_login";
            label_pass_login.Size = new Size(0, 20);
            label_pass_login.TabIndex = 11;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1348, 831);
            Controls.Add(lable_title_Form1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FormLogin";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Label label1;
        private Label lable_title_Form1;
        private TextBox TB_pass_login;
        private TextBox TB_userName_login;
        private Button BTTN_login;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label_pass_login;
        private Label lable_userName_login;
    }
}