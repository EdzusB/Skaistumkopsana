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
using System.Data;

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
            if (comboBox1.SelectedItem.ToString() == "Pedikīrs")
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
            else if (comboBox1.SelectedItem.ToString() == "Manikīrs")
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
            else if (comboBox1.SelectedItem.ToString() == "Matu_veidošana")
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
            else if (comboBox1.SelectedItem.ToString() == "Matu_krāsošana")
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
                if (textBox1.Text != "")
                {
                    SQLiteConnection sqlite_conn; 
                    sqlite_conn = CreateConnection();
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "DELETE FROM SK_Salons WHERE Pakalp_ID=" + textBox1.Text + ";";
                    sqlite_cmd.ExecuteNonQuery();
                textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Lūdzu ievadiet nosaukumu");
                }           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
