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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public int ru;
        public string cdkey;
        private void cdToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Location = this.Location;
            form2.Tag = this;
            form2.Show(this);
            Hide();

        }

        private void netconnectionAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KEY form1 = new KEY();
            form1.Tag = this;
            form1.Show(this);
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            string inputFile = "database.s3db";
            string dbConnection = String.Format("Data Source={0};Version=3;Password=KraQlin;", inputFile);


            using (SQLiteConnection c = new SQLiteConnection(dbConnection))
            {
                c.Open();
                string sql = "SELECT * FROM details;";
                SQLiteCommand cmd = new SQLiteCommand(sql, c);

                SQLiteDataAdapter sa = new SQLiteDataAdapter(cmd);
                DataSet sds = new DataSet();
                sa.Fill(sds, "details");
                dataGridView1.DataSource = sds.Tables["details"];
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                         string inputFile = "database.s3db";
           string dbConnection = String.Format("Data Source={0};Version=3;Password=KraQlin;", inputFile);


           using (SQLiteConnection c = new SQLiteConnection(dbConnection))
           {
               c.Open();
               string sql = "SELECT count(*) FROM details where id='" + textBox1.Text + "';";
               using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
               {
                    ru = Convert.ToInt32(cmd.ExecuteScalar());
               }
           }
                   if (ru != 0)
                   {
                       using (SQLiteConnection c = new SQLiteConnection(dbConnection))
                       {
                           c.Open(); string sqlq = "SELECT * FROM details where id ='" + textBox1.Text + "';";
                           using (SQLiteCommand cmd = new SQLiteCommand(sqlq, c))
                           {
                               using (SQLiteDataReader rdr = cmd.ExecuteReader())
                               {
                                   rdr.Read();
                                   cdkey = rdr["cdkey"].ToString();
                               }
                           }
                       }

                       Form5 a = new Form5(cdkey);
                       a.ShowDialog();
                   
                   }
                   else
                   {

                       MessageBox.Show("invalid id");

                   }
            }
            else { MessageBox.Show("please enter a id"); }
                
               }

        private void netConnectionNotAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Tag = this;
            form4.Show(this);
            Hide();
        }

       
    }
}
