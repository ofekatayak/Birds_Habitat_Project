using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdsProj
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            this.Text = "Bird Habitat Project";
        }

        private void LB_addBird_Home_Click(object sender, EventArgs e)
        {
            uS_addCage1.Hide();
            uS_Search1.Hide();
            uS_addBird1.Show();
            uS_addBird1.BringToFront();

        }

        private void LB_addCage_Home_Click(object sender, EventArgs e)
        {
            uS_addBird1.Hide();
            uS_Search1.Hide();
            uS_addCage1.Show();
            uS_addCage1.BringToFront();

        }

        private void LB_search_Home_Click(object sender, EventArgs e)
        {
            uS_addBird1.Hide();
            uS_addCage1.Hide();
            uS_Search1.Show();
            uS_Search1.BringToFront();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are u sure to log out?", "Confiration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                this.Hide();
                login.Show();
            }
            else return;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uS_Search1_Load(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }
    }
}
