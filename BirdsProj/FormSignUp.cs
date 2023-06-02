using OfficeOpenXml;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
using BirdsProj.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BirdsProj
{
    public partial class FormSignUp : Form
    {
        string filePatch = "C:\\Users\\moshe\\OneDrive\\Documents\\users_birds.xlsx";
        public FormSignUp()
        {
            InitializeComponent();
            this.Text = "Bird Habitat Project";
        }

        private void label_login_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void BTTN_signUp_Click(object sender, EventArgs e)
        {

            // takes the user input
            String id = TB_id_signUp.Text;
            String userName = TB_userName_signUp.Text;
            String pass = TB_password_signUp.Text;

            //validate the inputs
            bool isValid = validateSignUp(id, userName, pass);
            if (isValid)
            {
                ////create newUser
                User user = new User(userName, pass, id);
                //insert to excel
                SaveDataToExcel(filePatch, user);
                // move to home screen
                FormHome home = new FormHome();
                home.Show();
                this.Hide();
            }



        }

        private void TB_id_signUp_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validateUserName(String userName)
        {
            int numDigits = userName.Count(c => Char.IsDigit(c));
            int numLetters = userName.Length - numDigits;

            //empty field
            if (TB_userName_signUp.Text == "")
            {
                lable_userNameMsg_signUp.Text = "Required field!";
                return false;
            }
            //6-8 chars and 2 digits at most:
            if ((userName.Length >= 6 && userName.Length <= 8) && (numDigits <= 2 && numLetters == userName.Length - numDigits))
            {
                return true;
            }
            else
            {
                if (userName.Length < 6 || userName.Length > 8)
                {
                    lable_userNameMsg_signUp.Text =
                    "user name should be 6-8 chars";
                }
                if ((numDigits <= 2 && numLetters == userName.Length - numDigits) == false)
                {
                    lable_userNameMsg_signUp.Text =
                     "the user name should contain at mosr 2 digits, and the rest letters";
                }


                return false;
            }
        }
        private bool validatePass(String pass)
        {
            int numDigits = pass.Count(c => Char.IsDigit(c));
            int numLetters = pass.Count(l => Char.IsLetter(l));
            int numSpecial = numDigits + numLetters;

            //empty field
            if (TB_password_signUp.Text == "")
            {
                lable_passMsg_signUp.Text = "Required field!";
                return false;
            }
            if (pass.Length >= 8 && pass.Length <= 10)
            {
                if (numDigits < 1 || numLetters < 1 || numSpecial == pass.Length)
                {
                    lable_passMsg_signUp.Text =
                    "password unvalid. should contain at least 1 digit,1 letter,1 special char";
                    return false;
                }
                else return true;
            }
            else
            {
                lable_passMsg_signUp.Text =
                "pass should between 8 - 10 chars";
                return false;
            }
        }

        private bool validateId(String id)
        {
            int num;

            //ecmpty field
            if (TB_id_signUp.Text == "")
            {
                lable_idMsg_signUp.Text = "Required field!";
                return false;
            }
            if (int.TryParse(id, out num))
                return true;

            lable_idMsg_signUp.Text = "id contain only digits";
            return false;
        }
        public bool validateSignUp(string id, string userName, string pass)
        {
            bool isIdValid = validateId(id);
            bool isUserNameIsValid = validateUserName(userName);
            bool isPassValid = validatePass(pass);

            return isIdValid && isUserNameIsValid && isPassValid;
        }

        public static void SaveDataToExcel(string fileName, User userData)
        {
            Excel.Application excelApp = new Excel.Application();
            var workbook = excelApp.Workbooks.Open(fileName);
            var worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            int newRow = lastRow + 1;

            worksheet.Cells[newRow, 1] = userData.userName;
            worksheet.Cells[newRow, 2] = userData.password;
            worksheet.Cells[newRow, 3] = userData.id;

            //workbook.SaveAs("C:\\Users\\moshe\\OneDrive\\Documents\\users_birds.xlsx");
            workbook.Save();
            workbook.Close();
            excelApp.Quit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
