namespace BirdsProj
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            lable_title_Form1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            lable_passMsg_signUp = new Label();
            lable_userNameMsg_signUp = new Label();
            lable_idMsg_signUp = new Label();
            label6 = new Label();
            label1 = new Label();
            TB_id_signUp = new TextBox();
            BTTN_signUp = new Button();
            pictureBox1 = new PictureBox();
            label_login = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TB_password_signUp = new TextBox();
            TB_userName_signUp = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lable_title_Form1
            // 
            lable_title_Form1.AutoSize = true;
            lable_title_Form1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lable_title_Form1.ForeColor = SystemColors.ButtonHighlight;
            lable_title_Form1.Location = new Point(669, 24);
            lable_title_Form1.Margin = new Padding(2, 0, 2, 0);
            lable_title_Form1.Name = "lable_title_Form1";
            lable_title_Form1.Size = new Size(110, 37);
            lable_title_Form1.TabIndex = 3;
            lable_title_Form1.Text = "SignUp";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(87, 79);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 717);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lable_passMsg_signUp);
            panel4.Controls.Add(lable_userNameMsg_signUp);
            panel4.Controls.Add(lable_idMsg_signUp);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(TB_id_signUp);
            panel4.Controls.Add(BTTN_signUp);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label_login);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(TB_password_signUp);
            panel4.Controls.Add(TB_userName_signUp);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(364, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(842, 717);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // lable_passMsg_signUp
            // 
            lable_passMsg_signUp.AutoSize = true;
            lable_passMsg_signUp.ForeColor = Color.FromArgb(238, 99, 132);
            lable_passMsg_signUp.Location = new Point(279, 455);
            lable_passMsg_signUp.Name = "lable_passMsg_signUp";
            lable_passMsg_signUp.Size = new Size(0, 20);
            lable_passMsg_signUp.TabIndex = 15;
            // 
            // lable_userNameMsg_signUp
            // 
            lable_userNameMsg_signUp.AutoSize = true;
            lable_userNameMsg_signUp.ForeColor = Color.FromArgb(238, 99, 132);
            lable_userNameMsg_signUp.Location = new Point(279, 362);
            lable_userNameMsg_signUp.Name = "lable_userNameMsg_signUp";
            lable_userNameMsg_signUp.Size = new Size(0, 20);
            lable_userNameMsg_signUp.TabIndex = 14;
            // 
            // lable_idMsg_signUp
            // 
            lable_idMsg_signUp.AutoSize = true;
            lable_idMsg_signUp.ForeColor = Color.FromArgb(238, 99, 132);
            lable_idMsg_signUp.Location = new Point(279, 272);
            lable_idMsg_signUp.Name = "lable_idMsg_signUp";
            lable_idMsg_signUp.Size = new Size(0, 20);
            lable_idMsg_signUp.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(40, 17, 88);
            label6.Location = new Point(390, 151);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 32);
            label6.TabIndex = 12;
            label6.Text = "iBird";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(40, 17, 88);
            label1.Location = new Point(73, 230);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 30);
            label1.TabIndex = 11;
            label1.Text = "ID :";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // TB_id_signUp
            // 
            TB_id_signUp.Location = new Point(273, 221);
            TB_id_signUp.Margin = new Padding(2);
            TB_id_signUp.Multiline = true;
            TB_id_signUp.Name = "TB_id_signUp";
            TB_id_signUp.Size = new Size(308, 49);
            TB_id_signUp.TabIndex = 10;
            TB_id_signUp.TextChanged += TB_id_signUp_TextChanged;
            // 
            // BTTN_signUp
            // 
            BTTN_signUp.BackColor = Color.FromArgb(238, 99, 132);
            BTTN_signUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTTN_signUp.ForeColor = Color.White;
            BTTN_signUp.Location = new Point(302, 513);
            BTTN_signUp.Margin = new Padding(2);
            BTTN_signUp.Name = "BTTN_signUp";
            BTTN_signUp.Size = new Size(243, 46);
            BTTN_signUp.TabIndex = 9;
            BTTN_signUp.Text = "SignUp";
            BTTN_signUp.UseVisualStyleBackColor = false;
            BTTN_signUp.Click += BTTN_signUp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._82ab58e1_6bca_42d5_bdc8_ca43502d594e_2;
            pictureBox1.Location = new Point(334, 29);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label_login.ForeColor = Color.FromArgb(40, 17, 88);
            label_login.Location = new Point(393, 638);
            label_login.Margin = new Padding(2, 0, 2, 0);
            label_login.Name = "label_login";
            label_login.Size = new Size(55, 23);
            label_login.TabIndex = 7;
            label_login.Text = "Login";
            label_login.TextAlign = ContentAlignment.TopCenter;
            label_login.Click += label_login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ScrollBar;
            label4.Location = new Point(343, 606);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 6;
            label4.Text = "Have an account?";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(40, 17, 88);
            label3.Location = new Point(73, 412);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 30);
            label3.TabIndex = 5;
            label3.Text = "Password :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(40, 17, 88);
            label2.Location = new Point(73, 319);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 4;
            label2.Text = "User name : ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // TB_password_signUp
            // 
            TB_password_signUp.Location = new Point(273, 404);
            TB_password_signUp.Margin = new Padding(2);
            TB_password_signUp.Multiline = true;
            TB_password_signUp.Name = "TB_password_signUp";
            TB_password_signUp.Size = new Size(308, 49);
            TB_password_signUp.TabIndex = 3;
            // 
            // TB_userName_signUp
            // 
            TB_userName_signUp.Location = new Point(273, 311);
            TB_userName_signUp.Margin = new Padding(2);
            TB_userName_signUp.Multiline = true;
            TB_userName_signUp.Name = "TB_userName_signUp";
            TB_userName_signUp.Size = new Size(308, 49);
            TB_userName_signUp.TabIndex = 1;
            //TB_userName_signUp.TextChanged += TB_userName_signUp_TextChanged;
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
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1400, 844);
            Controls.Add(lable_title_Form1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FormSignUp";
            Text = "SignUp";
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

        private Label lable_title_Form1;
        private Panel panel1;
        private Panel panel4;
        private Label label6;
        private Label label1;
        private TextBox TB_id_signUp;
        private Button BTTN_signUp;
        private PictureBox pictureBox1;
        private Label label_login;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TB_password_signUp;
        private TextBox TB_userName_signUp;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label lable_passMsg_signUp;
        private Label lable_userNameMsg_signUp;
        private Label lable_idMsg_signUp;
    }
}