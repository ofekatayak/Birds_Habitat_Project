//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BirdsProj.classes;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BirdsProj
{
    public partial class US_addCage : UserControl
    {
        dataBase db;
        public US_addCage()
        {
            InitializeComponent();
            db = dataBase.getDataBase();
        }

        private void BTTN_addCage_US_Click(object sender, EventArgs e)
        {
            // take user input - cage detailes:
            string serialNum = TB_serialNum_addCage.Text;
            string len = TB_length_addCage.Text;
            string w = TB_width_addCage.Text;
            string h = TB_height_addCagex3.Text;
            string m = CB_matirial_addCage.Text;


            // create Cage
            Cage cage = new Cage(serialNum, len, h, w, m);
            //validate inputs:
            bool isValid = validateCageDetailes(cage);
            //validate cageNumber
            bool cageValid = validateCageNumber(serialNum);
            US_addBird b = new US_addBird();
            bool isSerialNotExist = !(db.isSerialExist(serialNum, "Cage serial number already exists", "CageTable", TB_serialNum_addCage.Text));
            //add to db
            if (isValid && cageValid && isSerialNotExist)
            {
                db.addCageToDataBase(cage);
                MessageBox.Show("Cage added sucssesfuly");
            }


        }

        public bool validateCageDetailes(Cage cage)
        {
            int num;
            //ecmpty field
            if (cage.serialNUmber != "" && cage.width != "" && cage.height != ""
                && cage.length != "" && cage.matirial != "")
            {
                if (!(int.TryParse(cage.length, out num)))
                {
                    label_len_addCage.Text = "only digits required!";
                    return false;
                }
                if (!(int.TryParse(cage.height, out num)))
                {
                    label_height_addCage.Text = "only digits required!";
                    return false;
                }
                if (!(int.TryParse(cage.width, out num)))
                {
                    label_width_addCage.Text = "only digits required!";
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Fill ALL the fields pls!");
                return false;
            }

            return true;

        }
        public bool validateCageNumber(String cageNumber)
        {
            // Regular expression pattern to match only letters and digits
            string pattern = "^[a-zA-Z0-9]+$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Match method to check if the username matches the pattern
            Match match = regex.Match(cageNumber);

            // Return true if there is a match, indicating that the username contains only letters and digits
            if (!match.Success)
            {
                LB_cageMsg.Text = "Cage serial number contain only digits and letters!";
            }
            return match.Success;
        }
    }
}
