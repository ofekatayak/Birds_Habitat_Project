using BirdsProj.classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdsProj
{
    public partial class FormAddBirdSon : Form
    {
        Bird bird;
        dataBase db;
        public FormAddBirdSon(Bird b)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            this.bird = b;
            db = dataBase.getDataBase();
        }

        private void BTTN_addSon_Click(object sender, EventArgs e)
        {
            US_addBird validObject = new US_addBird();
            string serialNumber = TB_serial_addSon.Text;
            string species = bird.species;
            string subSpecies = bird.subSpecies;
            DateOnly dateOfBirth = DateOnly.Parse(Date_addSon.Text);
            string cageNumber = bird.cageNumber;
            string momSerialNum = "";
            string dadSerialNum = "";
            bool validateOtherParent = db.isSerialExist(TB_ParentSerial_addSon.Text, "Other parent serial number dosen't exists", "BirdTable");
            Bird otherParendObj = new Bird();

            if (validateOtherParent)
            {
                otherParendObj = db.getBirdFromTable(int.Parse(TB_ParentSerial_addSon.Text));
            }
            bool validateOppositeGender = true;
            if (bird.gender == "Female" && otherParendObj.gender == "Male")
            {
                momSerialNum = bird.serialNumber.ToString();
                dadSerialNum = TB_ParentSerial_addSon.Text;
            }
            else if (bird.gender == "Male" && otherParendObj.gender == "Female")
            {
                dadSerialNum = bird.serialNumber.ToString();
                momSerialNum = TB_ParentSerial_addSon.Text;
            }
            else
            {
                validateOppositeGender = false;
            }
            string gender = "";
            if (RB_female_addSon.Checked)
                gender = "Female";
            else if (RB_male_addSon.Checked)
                gender = "Male";
            bool isValidSerial = validObject.validateSerialNumber(serialNumber, LB_serialMsg);
            bool isValidDad = validObject.validateSerialNumber(dadSerialNum, LB_ParentMsg);
            bool isValidMom = validObject.validateSerialNumber(momSerialNum, LB_ParentMsg);
            if (TB_ParentSerial_addSon.Text != "" && validateOtherParent && !validateOppositeGender)
            {
                LB_ParentMsg.Text = "";
                MessageBox.Show("Parents must be opposite genders! , try another parent!");
            }

            bool isValidGender = validObject.validateCB(gender, LB_genderMsg);
            bool isValidDate = checkDateSon(dateOfBirth, bird.dateOfBirth, otherParendObj.dateOfBirth);
            bool sameCageValid = validateSameCage(bird.cageNumber, otherParendObj.cageNumber);
            bool validSerialNotExists = !(db.isSerialExist(serialNumber, "serial number already exists", "BirdTable", TB_serial_addSon.Text));
            if (!validSerialNotExists)
            {
                LB_ParentMsg.Text = "Required field!";

            }
            bool validDadExists = db.isSerialExist(dadSerialNum, "Dad serial number dosen't exists", "BirdTable");
            if (!validDadExists)
            {
                dadSerialNum = "1111";
                validDadExists = true;
            }
            bool validMomExists = db.isSerialExist(momSerialNum, "Mom serial number dosen't exists", "BirdTable");
            if (!validMomExists)
            {
                momSerialNum = "1111";
                validMomExists = true;
            }
            if (sameCageValid && isValidDate && validDadExists && validMomExists && validSerialNotExists && isValidSerial && isValidDad && isValidMom && isValidGender)
            {
                int serialNum = int.Parse(serialNumber);
                int dadSerial = int.Parse(dadSerialNum);
                int momSerial = int.Parse(momSerialNum);
                Bird bird = new Bird(serialNum, species, subSpecies, dateOfBirth, cageNumber, dadSerial, momSerial, gender);
                db.addBirdToDataBase(bird);
                MessageBox.Show("Bird added sucssesfuly");
            }
        }

        private bool checkDateSon(DateOnly dateSon, DateOnly dateParent, DateOnly dateOtherParent)
        {
            if (dateSon.CompareTo(dateParent) < 0 || dateSon.CompareTo(dateParent) == 0 || dateSon.CompareTo(dateOtherParent) < 0 || dateSon.CompareTo(dateOtherParent) == 0)
            {
                MessageBox.Show("Son must be burn after his parents!");
                return false;
            }
            return true;
        }

        private bool validateSameCage(string p1Serial, string p2Serial)
        {
            if (p1Serial == p2Serial) return true;
            MessageBox.Show("Parents must be in the same cage!");
            return false;
        }
    }
}
