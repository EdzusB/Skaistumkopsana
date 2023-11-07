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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateConnection();
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * From Prece";

            DataTable sTable;
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
            using (sTable = new DataTable())
            {
                sqlda.Fill(sTable);
                Prece.DataSource = sTable;
            }
        }
    }
}
