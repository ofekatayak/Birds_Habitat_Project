using BirdsProj.classes;
using Microsoft.Data.SqlClient;
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
    public partial class FormCageProfile : Form
    {
        Cage cage;
        dataBase db;
        public FormCageProfile(Cage c)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            this.cage = c;
            db = dataBase.getDataBase();
        }

        private void icon_save_birdProfile_Click(object sender, EventArgs e)
        {
            string serial = cage.serialNUmber;
            this.cage = new Cage(serial, TB_length_cageProfile.Text, TB_height_cageProfile.Text, TB_widht_cageProfile.Text, CB_matirial_cageProfile.Text);
            US_addCage formCage = new US_addCage();
            bool validCage = formCage.validateCageDetailes(cage);
            if (validCage)
            {
                db.delete("CageTable", serial);
                db.addCageToDataBase(this.cage);
                initCageData();
                MessageBox.Show("Cage #" + serial + " updated!");
            }
        }

        private void FormCageProfile_Load(object sender, EventArgs e)
        {
            initCageData();
            db.loadCageBirds(GV_birdsinCage_cageProfilr, cage);
        }



        private void initCageData()
        {
            lable_serial_cageProfile.Text = "#" + cage.serialNUmber;
            TB_height_cageProfile.Text = cage.height;
            TB_widht_cageProfile.Text = cage.width;
            TB_length_cageProfile.Text = cage.length;
            CB_matirial_cageProfile.Text = cage.matirial;
        }

        private void GV_birdsinCage_cageProfilr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GV_birdsinCage_cageProfilr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_birdsinCage_cageProfilr.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GV_birdsinCage_cageProfilr.CurrentRow.Selected = true;
                string serail = GV_birdsinCage_cageProfilr.Rows[e.RowIndex].Cells["SerialNumber"].FormattedValue.ToString();
                string type = GV_birdsinCage_cageProfilr.Rows[e.RowIndex].Cells["species"].FormattedValue.ToString();
                string subType = GV_birdsinCage_cageProfilr.Rows[e.RowIndex].Cells["SubSpecies"].FormattedValue.ToString();
                string date = GV_birdsinCage_cageProfilr.Rows[e.RowIndex].Cells["date of birth"].FormattedValue.ToString();
                string gender = GV_birdsinCage_cageProfilr.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString();
                string cageNUmber = GV_birdsinCage_cageProfilr.Rows[e.RowIndex].Cells["cage number"].FormattedValue.ToString();
                string momSerial = GV_birdsinCage_cageProfilr.Rows[e.RowIndex].Cells["mom serial  number"].FormattedValue.ToString();
                string dadSerial = GV_birdsinCage_cageProfilr.Rows[e.RowIndex].Cells["dad serial number"].FormattedValue.ToString();

                Bird bird = new Bird(int.Parse(serail), type, subType, DateOnly.Parse(date), cageNUmber, int.Parse(dadSerial), int.Parse(momSerial), gender);
                FormBirdProfile birdProfile = new FormBirdProfile(bird);

                birdProfile.ShowDialog();


            }
        }
    }
}
