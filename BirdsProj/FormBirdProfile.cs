using BirdsProj.classes;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdsProj
{
    public partial class FormBirdProfile : Form
    {
        Bird bird;
        dataBase db;
        public FormBirdProfile(Bird b)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            this.bird = b;
            db = dataBase.getDataBase();
        }

        private void FormBirdProfile_Load(object sender, EventArgs e)
        {
            // init the prodile with the bird data
            initBirdData();
        }

        private void initBirdData()
        {
            lable_gender_birdProfile.Text = bird.gender;
            lable_serial_birdProfile.Text = "#" + bird.serialNumber.ToString();
            label_type_birdProfile.Text = bird.species;
            Date_date_birdProfile.Text = bird.dateOfBirth.ToString();
            TB_momSerial_birdProfile.Text = bird.momSerialNumber.ToString();
            textTB_dadSerial_birdProfile.Text = bird.dadSerialNumber.ToString();

            CB_subSpecies_birdProfile.Text = bird.subSpecies;
            CB_species_birdProfile.Text = bird.species;
            CB_cageNum_birdProfile.Text = bird.cageNumber;
            if (bird.gender == "Male")
            {
                RB_male_birdProfile.Checked = true;
            }
            else
            {
                RB_female_birdProfile.Checked = true;
            }
        }

        private void BTTN_addSon_birdProfile_Click(object sender, EventArgs e)
        {
            //open dialog for add son
            FormAddBirdSon addSon = new FormAddBirdSon(this.bird);
            addSon.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //delete bird from sql
            db.delete("BirdTable", bird.serialNumber.ToString());
            MessageBox.Show("Bird #" + bird.serialNumber + " deleted!");
            this.Hide();
        }

        private void icon_save_birdProfile_Click(object sender, EventArgs e)
        {
            US_addBird uS_AddBird = new US_addBird();
            int serialNumber = bird.serialNumber;
            string species = CB_species_birdProfile.Text;
            string subSpecies = CB_subSpecies_birdProfile.Text;
            DateOnly dateOfBirth = DateOnly.Parse(Date_date_birdProfile.Text);
            string cageNumber = CB_cageNum_birdProfile.Text;
            string dadSerialNum = textTB_dadSerial_birdProfile.Text;
            string momSerialNum = TB_momSerial_birdProfile.Text;
            string gender = "";
            if (RB_female_birdProfile.Checked)
                gender = "Female";
            else if (RB_male_birdProfile.Checked)
                gender = "Male";
            bool isValidDad = uS_AddBird.validateSerialNumber(dadSerialNum, LB_dad);
            bool isValidMom = uS_AddBird.validateSerialNumber(momSerialNum, LB_mom);
            bool isValidCage = uS_AddBird.validateCageNumber(cageNumber, LB_cage);
            bool isValidSpecies = uS_AddBird.validateCB(species, LB_species);
            bool isValidSubSpecies = uS_AddBird.validateCB(subSpecies, LB_sub);
            bool isValidGender = uS_AddBird.validateCB(gender, LB_genderMsg);
            bool validDadExists = db.isSerialExist(dadSerialNum, "Dad serial number dosen't exists", "BirdTable");
            if (!validDadExists)
            {
                dadSerialNum = "1111";
                validDadExists = true;
            }
            bool validMomExists = db.isSerialExist(momSerialNum, "Mom serial number dosen't exists", "BirdTable");
            if (!validMomExists)
            {
                momSerialNum = "2222";
                validMomExists = true;
            }
            if (validDadExists && validMomExists && isValidDad && isValidMom && isValidCage && isValidSpecies && isValidSubSpecies && isValidGender)
            {
                int serialNum = serialNumber;
                int dadSerial = int.Parse(dadSerialNum);
                int momSerial = int.Parse(momSerialNum);
                db.delete("BirdTable", bird.serialNumber.ToString());
                this.bird = new Bird(serialNum, species, subSpecies, dateOfBirth, cageNumber, dadSerial, momSerial, gender);
                db.addBirdToDataBase(this.bird);
                MessageBox.Show("Bird #" + bird.serialNumber + " Updated!");
                initBirdData();
            }
        }

        private void CB_species_birdProfile_SelectedIndexChanged(object sender, EventArgs e)
        {

            String[] comboBox2 = new String[] {"North America" , "Central America" , "South Amrica", "East Europe","West Europe",
                "Central Australia", "Beach Cities" };
            int selectedIndex = CB_species_birdProfile.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:

                    CB_subSpecies_birdProfile.Items.Clear();
                    CB_subSpecies_birdProfile.Items.Add(comboBox2[0]);
                    CB_subSpecies_birdProfile.Items.Add(comboBox2[1]);
                    CB_subSpecies_birdProfile.Items.Add(comboBox2[2]);

                    break;
                case 1:
                    CB_subSpecies_birdProfile.Items.Clear();
                    CB_subSpecies_birdProfile.Items.Add(comboBox2[3]);
                    CB_subSpecies_birdProfile.Items.Add(comboBox2[4]);

                    break;
                case 2:
                    CB_subSpecies_birdProfile.Items.Clear();
                    CB_subSpecies_birdProfile.Items.Add(comboBox2[5]);
                    CB_subSpecies_birdProfile.Items.Add(comboBox2[6]);

                    break;
            }
            CB_subSpecies_birdProfile.Text = "";
        }

        private void CB_cageNum_addBird_Click(object sender, EventArgs e)
        {
            db.LoadDataFromTableToComboBox("CageTable", "SerialNumber", CB_cageNum_birdProfile);
        }


    }


}
