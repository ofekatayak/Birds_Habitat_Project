using Azure;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BirdsProj
{
    public partial class US_addBird : UserControl
    {
        dataBase db;
        public US_addBird()
        {
            InitializeComponent();
            db = dataBase.getDataBase();
        }

        private void CM_type_addBird_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] comboBox2 = new String[] {"North America" , "Central America" , "South Amrica", "East Europe","West Europe",
                "Central Australia", "Beach Cities" };
            int selectedIndex = CM_type_addBird.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    CM_subType_addBird.Text = "";
                    CM_subType_addBird.Items.Clear();
                    CM_subType_addBird.Items.Add(comboBox2[0]);
                    CM_subType_addBird.Items.Add(comboBox2[1]);
                    CM_subType_addBird.Items.Add(comboBox2[2]);
                    break;
                case 1:
                    CM_subType_addBird.Text = "";
                    CM_subType_addBird.Items.Clear();
                    CM_subType_addBird.Items.Add(comboBox2[3]);
                    CM_subType_addBird.Items.Add(comboBox2[4]);
                    break;
                case 2:
                    CM_subType_addBird.Text = "";
                    CM_subType_addBird.Items.Clear();
                    CM_subType_addBird.Items.Add(comboBox2[5]);
                    CM_subType_addBird.Items.Add(comboBox2[6]);
                    break;
            }

        }

        private void BTTN_addBird_addBird_Click(object sender, EventArgs e)
        {
            string serialNumber = TB_serialNum_addBird.Text;
            string species = CM_type_addBird.Text;
            string subSpecies = CM_subType_addBird.Text;
            DateOnly dateOfBirth = DateOnly.Parse(Date_addBird.Text);
            string cageNumber = CB_cageNumber_addBird.Text;
            string dadSerialNum = CB_fatherSerial_addBird.Text;
            string momSerialNum = CB_motherSerial_addBird.Text;
            string gender = "";
            if (RB_female_addBird.Checked)
                gender = "Female";
            else if (RB_male_addBird.Checked)
                gender = "Male";
            bool isValidSerial = validateSerialNumber(serialNumber, LB_serialMsg);
            bool isValidDad = validateSerialNumber(dadSerialNum, LB_momMsg);
            bool isValidMom = validateSerialNumber(momSerialNum, LB_fatherMsg);
            bool isValidCage = validateCageNumber(cageNumber, LB_cageMsg);
            bool isValidSpecies = validateCB(species, LB_speciesMsg);
            bool isValidSubSpecies = validateCB(subSpecies, LB_subSpeciesMsg);
            bool isValidGender = validateCB(gender, LB_genderMsg);
            bool validSerialNotExists = !db.isSerialExist(serialNumber, "serial number already exists", "BirdTable", TB_serialNum_addBird.Text);
            bool validDadExists = db.isSerialExist(dadSerialNum, "Dad serial number dosen't exists", "BirdTable");
            if (!validDadExists)
            {
                dadSerialNum = "2222";
                validDadExists = true;
            }
            bool validMomExists = db.isSerialExist(momSerialNum, "Mom serial number dosen't exists", "BirdTable");
            if (!validMomExists)
            {
                momSerialNum = "1111";
                validMomExists = true;
            }
            if (validDadExists && validMomExists && validSerialNotExists && isValidSerial && isValidDad && isValidMom && isValidCage && isValidSpecies && isValidSubSpecies && isValidGender)
            {
                int serialNum = int.Parse(serialNumber);
                int dadSerial = int.Parse(dadSerialNum);
                int momSerial = int.Parse(momSerialNum);
                Bird bird = new Bird(serialNum, species, subSpecies, dateOfBirth, cageNumber, dadSerial, momSerial, gender);
                db.addBirdToDataBase(bird);
                MessageBox.Show("Bird added sucssesfuly");
            }
        }

        public bool validateSerialNumber(String serialNumber, Label lbName)
        {
            int num;

            //ecmpty field
            if (serialNumber == "")
            {
                lbName.Text = "Required field!";
                return false;
            }

            if (int.TryParse(serialNumber, out num))
                return true;

            lbName.Text = "Serial Number contain only digits";
            return false;
        }
        public bool validateCageNumber(String cageNumber, Label lb)
        {
            if (cageNumber == "")
            {
                lb.Text = "Required field!";
                return false;
            }
            foreach (char c in cageNumber)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    lb.Text = "Serial Number contain only digits";
                    return false;
                }
            }
            using (SqlConnection connection = new SqlConnection(constants.dbConnString))
            {
                connection.Open();
                string sqlQuery = "SELECT COUNT(*) FROM CageTable WHERE SerialNumber = @ParameterValue";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@ParameterValue", cageNumber);
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Cage dosen't exists");
                    }
                    return count > 0;
                }
            }


        }
        public bool validateCB(string CB, Label lb)
        {
            if (CB == "")
            {
                lb.Text = "Required field!";
                return false;
            }
            return true;
        }
 
        private void CB_motherSerial_addBird_Click(object sender, EventArgs e)
        {
            db.LoadDataFromTableToComboBox("BirdTable", "mom serial  number", CB_motherSerial_addBird);
        }

        private void CB_fatherSerial_addBird_Click(object sender, EventArgs e)
        {
            db.LoadDataFromTableToComboBox("BirdTable", "dad serial number", CB_fatherSerial_addBird);
        }
    }


}
