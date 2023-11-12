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
    public partial class Form3 : Form
    {
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
        public void Tekstinators()
        {
            try
            {
                // Use StreamWriter with FileMode.Append to append text to the existing file
                using (TextWriter text1 = new StreamWriter(@"C:\visual\salon\Skaistumkopsana\Personas_dati.txt", true))
                {
                    text1.WriteLine("Personas izvēlētais pakalpojuma veids ir: " + PakalpVeidi.SelectedItem );
                    text1.WriteLine("Pakalpojuma ID: " + kaste1.Text);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void iepriekseja2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void nakama3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PakalpVeidi.SelectedItem.ToString() == "Pedikīrs")
            {
                CreateConnection();
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM SK_Salons WHERE Pakalp_kategorija = 'Pedikīrs'";


                DataTable sTable;
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
                using (sTable = new DataTable())
                {
                    sqlda.Fill(sTable);
                    dataGridView1.DataSource = sTable;
                }
            }
            else if (PakalpVeidi.SelectedItem.ToString() == "Manikīrs")
            {
                CreateConnection();
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM SK_Salons WHERE Pakalp_kategorija = 'Manikīrs'";


                DataTable sTable;
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
                using (sTable = new DataTable())
                {
                    sqlda.Fill(sTable);
                    dataGridView1.DataSource = sTable;
                }
            }
            else if (PakalpVeidi.SelectedItem.ToString() == "Matu_veidošana")
            {
                CreateConnection();
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM SK_Salons WHERE Pakalp_kategorija = 'Matu_veidošana'";


                DataTable sTable;
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
                using (sTable = new DataTable())
                {
                    sqlda.Fill(sTable);
                    dataGridView1.DataSource = sTable;
                }
            }
            else if (PakalpVeidi.SelectedItem.ToString() == "Matu_krāsošana")
            {
                CreateConnection();
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM SK_Salons WHERE Pakalp_kategorija = 'Matu_krāsošana'";


                DataTable sTable;
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
                using (sTable = new DataTable())
                {
                    sqlda.Fill(sTable);
                    dataGridView1.DataSource = sTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (kaste1.Text != "")
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();

                // Check if Pakalp_pieejams is "Nē" before updating
                sqlite_cmd.CommandText = "SELECT Pakalp_pieejams FROM SK_Salons WHERE Pakalp_ID = @Pakalp_ID";
                sqlite_cmd.Parameters.AddWithValue("@Pakalp_ID", kaste1.Text);

                object result = sqlite_cmd.ExecuteScalar();

                if (result != null && result.ToString() == "Nē")
                {
                    MessageBox.Show("Izvēlētais pakalpojums jau ir aizņemts!");
                }
                else
                {
                    sqlite_cmd.Parameters.Clear();
                    sqlite_cmd.CommandText = "UPDATE SK_Salons SET Pakalp_pieejams = CASE WHEN Pakalp_pieejams = 'Jā' THEN 'Nē' ELSE 'Jā' END WHERE Pakalp_ID = @Pakalp_ID";
                    sqlite_cmd.Parameters.AddWithValue("@Pakalp_ID", kaste1.Text);

                    int rowsAffected = sqlite_cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pieraksts veiksmīgi veikts!");
                    }
                    else
                    {
                        MessageBox.Show("Nav atrastas atbilstošas ierakstu.");
                    }

                    sqlite_cmd.CommandText = "INSERT INTO Klienta_pakalp (Pakalp_ID) VALUES(@Pakalp_ID)";
                    sqlite_cmd.Parameters.AddWithValue("@Pakalp_ID", kaste1.Text);

                    sqlite_cmd.ExecuteNonQuery();
                }
                Tekstinators();
                kaste1.Clear();
            }
            else
            {
                MessageBox.Show("Lūdzu ievadiet nosaukumu");
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
