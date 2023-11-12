using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;



namespace Skaistumkopsana_08_11_2023_EB_LL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=Skaistumkopsana.db; Version = 3; New = True; Compress = True; ");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void KONEKCIJA_Click(object sender, EventArgs e)
        {
            CreateConnection();
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * From Klients";

            DataTable sTable;
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
            using (sTable = new DataTable())
            {
                sqlda.Fill(sTable);
                Klients.DataSource = sTable;
            }
        }
        public void Tekstinators()
        {
            try
            {
                // Use StreamWriter with FileMode.Append to append text to the existing file
                using (TextWriter text1 = new StreamWriter(@"C:\visual\salon\Skaistumkopsana\Personas_dati.txt", true))
                {
                    text1.WriteLine("Personas ID ir: " + PersID.Text);
                }

                Console.WriteLine("Data successfully appended to the text file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        private void InsertBTN_Click_1(object sender, EventArgs e)
        {
            if (vards.Text != "" && uzvards.Text != "" && numurs.Text != "" && pers_kods.Text != "" && PersID.Text != "")
            {
                try
                {
                    using (SQLiteConnection sqlite_conn = CreateConnection())
                    {
                        using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                        {
                            sqlite_cmd.CommandText = "INSERT INTO Klients (Vards, Uzvards, Tel_num, P_K, ID) VALUES('" + vards.Text + "', '" + uzvards.Text + "', '" + numurs.Text + "', '" + pers_kods.Text + "', '" + PersID.Text + "');";
                            sqlite_cmd.ExecuteNonQuery();
                        }

                        Console.WriteLine("Data successfully inserted into the database.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Ludzu aizpildiet visus ievades laukus!!!");
            }

            Tekstinators();
        }


        private void nakama1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PersID_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
