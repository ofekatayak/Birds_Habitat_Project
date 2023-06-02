using BirdsProj.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdsProj
{
    public partial class US_Search : UserControl
    {
        dataBase db;
        public US_Search()
        {
            InitializeComponent();
            db = dataBase.getDataBase();

        }

        private void US_Search_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CM_type_addBird_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGV_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // show the cage Table , hide bird table,and refresh table
            label_resTitle_search.Text = "Cage results: ";
            db.showTableData(dataGV_cage_search, "CageTable");
            dataGV_cage_search.Refresh();
            dataGV_cage_search.Visible = true;
            dataGV_bird_search.Visible = false;
        }

        private void bttn_searchCage_search_Click(object sender, EventArgs e)
        {
            label_resTitle_search.Text = "Cage results: ";
            string serialnum = TB_serialNum_searchCage.Text;
            string matirial = CB_matirial_searchCage.Text.ToString();
            dataGV_cage_search.Visible = true;
            dataGV_bird_search.Visible = false;
            if (CheckSearchCageDetails(serialnum, matirial))
            {
                if (serialnum == "")
                {
                    db.showCagesByOption(dataGV_cage_search, "CageTable", matirial, "matirial");
                }
                else
                {
                    db.showCagesByOption(dataGV_cage_search, "CageTable", serialnum, "SerialNumber");
                }
            }
        }

        public bool CheckSearchCageDetails(string serialnum, string matirial)
        {
            // bool method: check only if there is only empty field 
            // true - at least one field is not empty.
            // false - all the field is empty.
            if (serialnum == "" && matirial == "")
            {
                MessageBox.Show("Please fill one of the fields first.");
                return false;
            }
            return true;
        }

        private void bttn_searchBird_search_Click(object sender, EventArgs e)
        {
            // showing the current table
            label_resTitle_search.Text = "Birds results: ";
            dataGV_cage_search.Visible = false;
            dataGV_bird_search.Visible = true;
            // define the all the current attributes.
            string serialNumber = TB_serialNum_addBird.Text;
            string birdType = CM_type_addBird.Text;
            string BirthDate = Date_addBird.Text;
            DateTime t = DateTime.Parse(BirthDate);
            string gender = "";
            if (RB_female_addBird.Checked)
            {
                gender = "Female";
            }
            if (RB_male_addBird.Checked)
            {
                gender = "Male";
            }

            // search the specific attr for searching 
            //validate the fields of bird search
            if (validateBirdDetails(serialNumber, birdType, t, gender))
            {
                db.showBirdsByOption(dataGV_bird_search, "BirdTable", serialNumber, gender, birdType, t);
            }
        }

        public bool validateBirdDetails(string serialnum, string birdType, DateTime t, string gender)
        {
            // bool method: check only if there is only empty field 
            // true - at least one field is not empty.
            // false - all the field is empty or the date presenting the current date (Today).
            if (serialnum == "" && birdType == "" && gender == "" && t.Day == DateTime.Today.Day && t.Month == DateTime.Today.Month && t.Year == DateTime.Today.Year)
            {
                MessageBox.Show("please fill one of the fields first.");
                return false;
            }
            return true;
        }

        public bool CheckSearchBirdDetails(string serialnum, string birdType, string BirthDate, string gender, DateTime t)
        {
            if (serialnum == "" && birdType == "" && gender == "" && t.Day == DateTime.Today.Day && t.Month == DateTime.Today.Month && t.Year == DateTime.Today.Year)
            {
                MessageBox.Show("please fill one of the fields first.");
                return false;
            }
            return true;
        }

        public void refresh_BirdTable_Click(object sender, EventArgs e)
        {
            label_resTitle_search.Text = "Birds results: ";
            dataGV_bird_search.Refresh();
            dataGV_cage_search.Visible = false;
            dataGV_bird_search.Visible = true;
            db.showTableData(dataGV_bird_search, "BirdTable");


            //TODO - search from birdTable
        }

        private void dataGV_cage_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV_cage_search.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGV_cage_search.CurrentRow.Selected = true;
                string serail = dataGV_cage_search.Rows[e.RowIndex].Cells["SerialNumber"].FormattedValue.ToString();
                string height = dataGV_cage_search.Rows[e.RowIndex].Cells["height"].FormattedValue.ToString();
                string width = dataGV_cage_search.Rows[e.RowIndex].Cells["widht"].FormattedValue.ToString();
                string length = dataGV_cage_search.Rows[e.RowIndex].Cells["length"].FormattedValue.ToString();
                string matirial = dataGV_cage_search.Rows[e.RowIndex].Cells["matirial"].FormattedValue.ToString();

                Cage c = new Cage(serail, length, height, width, matirial);
                FormCageProfile formCageProfile = new FormCageProfile(c);
                formCageProfile.ShowDialog();

            }
        }

        private void dataGV_bird_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV_bird_search.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGV_bird_search.CurrentRow.Selected = true;
                string serail = dataGV_bird_search.Rows[e.RowIndex].Cells["SerialNumber"].FormattedValue.ToString();
                string type = dataGV_bird_search.Rows[e.RowIndex].Cells["species"].FormattedValue.ToString();
                string subType = dataGV_bird_search.Rows[e.RowIndex].Cells["SubSpecies"].FormattedValue.ToString();
                string date = dataGV_bird_search.Rows[e.RowIndex].Cells["date of birth"].FormattedValue.ToString();
                string gender = dataGV_bird_search.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString();
                string cageNUmber = dataGV_bird_search.Rows[e.RowIndex].Cells["cage number"].FormattedValue.ToString();
                string momSerial = dataGV_bird_search.Rows[e.RowIndex].Cells["mom serial  number"].FormattedValue.ToString();
                string dadSerial = dataGV_bird_search.Rows[e.RowIndex].Cells["dad serial number"].FormattedValue.ToString();

                Bird bird = new Bird(int.Parse(serail), type, subType, DateOnly.Parse(date), cageNUmber, int.Parse(dadSerial), int.Parse(momSerial), gender);
                FormBirdProfile birdProfile = new FormBirdProfile(bird);

                birdProfile.ShowDialog();


            }
        }

        private void GP_searchCage_search_Enter(object sender, EventArgs e)
        {
            //adfas
        }
       
    }
}
