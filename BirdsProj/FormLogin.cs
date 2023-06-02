using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;

namespace BirdsProj
{
    public partial class FormLogin : Form
    {
         string filePatch = constants.filePatch;
        
        public FormLogin()
        {
            InitializeComponent();
            this.Text = "Bird Habitat Project";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormSignUp signUp = new FormSignUp();
            signUp.Show();
            this.Hide();

        }

        private void BTTN_login_Click(object sender, EventArgs e)
        {
            string userName = TB_userName_login.Text;
            string pass = TB_pass_login.Text;
            bool isUserExist = checkCredentials(userName, pass);
            if (isUserExist)
            {
                FormHome home = new FormHome();
                home.Show();
                this.Hide();
            }


        }

        public bool checkCredentials(string username, string password)
        {
            bool credentialsExist = false;
            bool wrongPass = false;

            //empty fields
            if (TB_userName_login.Text == "")
            {
                lable_userName_login.Text = "Required field!";
            }
            if (TB_pass_login.Text == "")
            {
                label_pass_login.Text = "Required field!";
            }

            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Open(filePatch);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;


            for (int row = 1; row <= range.Rows.Count; row++)
            {
                string rowUsername = ((Excel.Range)range.Cells[row, 1]).Text;
                string rowPassword = ((Excel.Range)range.Cells[row, 2]).Text;
                Console.WriteLine(rowUsername + " " + rowPassword);

                if (username == rowUsername && password == rowPassword)
                {
                    credentialsExist = true;
                    break;
                }
                if (username == rowUsername && password != rowPassword)
                {
                    
                    wrongPass = true;
                    TB_pass_login.Text = "";
                    label_pass_login.Text = "wrong password. try again";
                    break;
                }

            }
            if (credentialsExist == false && wrongPass == false)
                lable_userName_login.Text = "user not exist";

            workbook.Close(false);
            excel.Quit();

            return credentialsExist;
        }
    }
}