using Microsoft.Data.SqlClient;
//using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BirdsProj.classes
{
    internal class dataBase
    {
        private readonly string connectionString;
        private readonly SqlConnection sqlConnection;
        private static dataBase db;

        protected dataBase(string conn) {
            this.connectionString = conn;
            this.sqlConnection = new SqlConnection(connectionString);
        }

        public static dataBase getDataBase()
        {
            if (db == null)
                db = new dataBase(constants.dbConnString);

            return db;
        }

        public void showTableData(DataGridView dataGV, string table)
        {
            SqlCommand cmd = new SqlCommand("select * from " + table + " ORDER BY SerialNumber", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTa = new DataTable();
            da.Fill(dataTa);
            dataGV.DataSource = dataTa;

        }

        public void addCageToDataBase(Cage cage)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into CageTable values (@SERIALNUMBER,@LENGTH,@WIDTH,@HEIGHT,@MATIRIAL)", sqlConnection);

            cmd.Parameters.AddWithValue("@SERIALNUMBER", cage.serialNUmber);
            cmd.Parameters.AddWithValue("@LENGTH", float.Parse(cage.length));
            cmd.Parameters.AddWithValue("@WIDTH", float.Parse(cage.width));
            cmd.Parameters.AddWithValue("@HEIGHT", float.Parse(cage.height));
            cmd.Parameters.AddWithValue("@MATIRIAL", cage.matirial);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void showCagesByOption(DataGridView dataGV, string table, string option, string type)
        {
            SqlCommand cmd = new SqlCommand("select * from " + table, sqlConnection);

            if (type == "matirial")
            {
                cmd = new SqlCommand("select * from " + table + " where matirial = '" + option + "'", sqlConnection);
            }
            if (type == "SerialNumber")
            {
                cmd = new SqlCommand("select * from " + table + " where SerialNumber = '" + option + "'", sqlConnection);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTa = new DataTable();
            da.Fill(dataTa);
            dataGV.DataSource = dataTa;
        }

        public void addBirdToDataBase(Bird bird)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into BirdTable values (@SERIALNUMBER,@SPECIES,@SUBSPECIES,@DATEOFBIRTH,@GENDER,@CAGENUMBER,@DADSERIALNUMBER,@MOMSERIALNUMBER)", sqlConnection);
            cmd.Parameters.AddWithValue("@SERIALNUMBER", bird.serialNumber);
            cmd.Parameters.AddWithValue("@SPECIES", bird.species);
            cmd.Parameters.AddWithValue("@SUBSPECIES", bird.subSpecies);
            cmd.Parameters.AddWithValue("@DATEOFBIRTH", bird.dateOfBirth);
            cmd.Parameters.AddWithValue("@GENDER", bird.gender);
            cmd.Parameters.AddWithValue("@CAGENUMBER", bird.cageNumber);
            cmd.Parameters.AddWithValue("@DADSERIALNUMBER", bird.dadSerialNumber);
            cmd.Parameters.AddWithValue("@MOMSERIALNUMBER", bird.momSerialNumber);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void delete(string table, string serial)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM " + table + " WHERE [SerialNumber] = @SerialNumber", sqlConnection);
            cmd.Parameters.AddWithValue("@SerialNumber", serial);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public void showBirdsByOption(DataGridView dataGV, string table, string SerialNumber, string Gender, string Species, DateTime t)
        {
            SqlCommand cmd = new SqlCommand("select * from " + table + " where 1=1 ", sqlConnection);
            if (SerialNumber != "")
            {
                cmd.CommandText += "and SerialNumber = " + SerialNumber + " ";
            }
            if (Gender != "")
            {
                cmd.CommandText += "and gender = '" + Gender + "' ";
            }
            if (Species != "")
            {
                cmd.CommandText += "and species = '" + Species + "' ";
            }
            if (t.Day != DateTime.Today.Day || t.Month != DateTime.Today.Month || t.Year != DateTime.Today.Year)
            {
                cmd.CommandText += "and [date of birth] = '" + (string)t.ToString("yyyy-MM-dd") + "' ";
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTa = new DataTable();
            da.Fill(dataTa);
            dataGV.DataSource = dataTa;
        }

        public void LoadDataFromTableToComboBox(string tableName, string columnName, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT [" + columnName + "] FROM " + tableName, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string serialNumber = reader[columnName].ToString();
                comboBox.Items.Add(serialNumber);
            }

            reader.Close();
            sqlConnection.Close();
        }

        public Bird getBirdFromTable(int serialNumber)
        {
            Bird obj = new Bird();
            using (SqlConnection connection = new SqlConnection(constants.dbConnString))
            {
                sqlConnection.Open();
                string sqlQuery = "SELECT * FROM BirdTable WHERE SerialNumber = @objectId";
                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("@objectId", serialNumber);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string inputDate = reader["date of birth"].ToString();
                    int index = inputDate.IndexOf(' ');
                    string date = inputDate.Substring(0, index);
                    obj.species = reader["species"].ToString();
                    obj.serialNumber = (int)reader["SerialNumber"];
                    obj.subSpecies = reader["SubSpecies"].ToString();
                    obj.dateOfBirth = DateOnly.Parse(date);
                    obj.cageNumber = reader["cage number"].ToString();
                    obj.dadSerialNumber = (int)reader["dad serial number"];
                    obj.momSerialNumber = (int)reader["mom serial  number"];
                    obj.gender = reader["gender"].ToString();
                }
            }
            sqlConnection.Close();
            return obj;
        }

        public void loadCageBirds(DataGridView dg, Cage cage)
        {
            sqlConnection.Open();

            string sqlQuery = "SELECT * FROM BirdTable WHERE [cage number] = @CageNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            command.Parameters.AddWithValue("@CageNumber", cage.serialNUmber);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dg.DataSource = dataTable;

            sqlConnection.Close();
        }

        public bool isSerialExist(string serial, string msg, string table, string serialLab = null)
        {
            if (serial != "")
            {
                sqlConnection.Open();

                // Construct the SQL query to check for the object's existence based on the parameter
                string query = "SELECT COUNT(*) FROM " + table + " WHERE SerialNumber = @ParameterValue";

                SqlCommand command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@ParameterValue", serial);

                // Execute the query and get the result
                int count = (int)command.ExecuteScalar();

                if (serial == serialLab)
                {
                    if (count > 0)
                        MessageBox.Show(msg);
                }
                else if (count == 0)
                    MessageBox.Show(msg);

                sqlConnection.Close();

                return count > 0;
            }
            return false;
        }

           
    }
}

 

