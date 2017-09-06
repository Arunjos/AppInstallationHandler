using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EncryptionSample
{
    public partial class Form5 : Form
    { public string cdkey1;
        public Form5(string cdkey)
        {
            InitializeComponent();
            cdkey1 = cdkey;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string inputFile = "database.s3db";
            string dbConnection = String.Format("Data Source={0};Version=3;Password=KraQlin;", inputFile);


            using (SQLiteConnection c = new SQLiteConnection(dbConnection))
            {
                c.Open();
                string sql = "SELECT * FROM fulldetails where cdkey='" + cdkey1 + "';";
                SQLiteCommand cmd = new SQLiteCommand(sql, c);

                SQLiteDataAdapter sa = new SQLiteDataAdapter(cmd);
                DataSet sds = new DataSet();
                sa.Fill(sds, "details");
                dataGridView1.DataSource = sds.Tables["details"];
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
        }
    }
}
