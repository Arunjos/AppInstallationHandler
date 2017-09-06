using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using RSAEncryptionLib;
using System.Data.SQLite;

namespace EncryptionSample
{
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }
         int rowsUpdated,count;
        private void netconnectionAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
           KEY form2 = new KEY();
            form2.Location = this.Location;
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void netConnectionNotAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Location = this.Location;
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void viewCdKeyStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Location = this.Location;
            form3.Tag = this;
            form3.Show(this);
            Hide();
        }

        private string GetSHA1HashData(string data)
        {
            //create new instance of md5
            SHA1 sha1 = SHA1.Create();

            //convert the input text to array of bytes
            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));

            //create new instance of StringBuilder to save hashed data
            StringBuilder returnValue = new StringBuilder();

            //loop for each byte and add it to StringBuilder
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }
            StringBuilder result = new StringBuilder();

            // return hexadecimal string
            for (int i = 0; i < 24; i++)
            {
                result.Append(returnValue[i].ToString());
                if ((i + 1) % 4 == 0 && i != 23)
                    result.Append("-");

            }

            return result.ToString();
        }


        private string GetMD5HashData(string data)
        {
            //create new instance of md5 ..kraqlin12193117185192241182168491951532261051193897
            MD5 md5 = MD5.Create();

            //convert the input text to array of bytes
            byte[] hashData = md5.ComputeHash(Encoding.Default.GetBytes(data));

            //create new instance of StringBuilder to save hashed data
            StringBuilder returnValue = new StringBuilder();
            string add = ".KraQlinAroNzz.";

            //loop for each byte and add it to StringBuilder
            for (int i = 0; i < hashData.Length; i++)
            {
                if (i < add.Length)
                    returnValue.Append(add[i].ToString());
                returnValue.Append(hashData[i].ToString());
            }

            // return hexadecimal string
            // return returnValue.ToString();
            string a = GetSHA1HashData(returnValue.ToString());
            return a.ToString();

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
             
            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                string cdkey = textBox4.Text;
                cdkey = cdkey.Replace(" ", "");
                string dbConnection;
                string inputFile = "database.s3db";
                dbConnection = String.Format("Data Source={0};Version=3;Password=KraQlin;", inputFile);

              
                using (SQLiteConnection c = new SQLiteConnection(dbConnection))
{
    c.Open();
                    string sql = "SELECT count(*) FROM details where cdkey='" + cdkey + "';";
    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
    {
        rowsUpdated = Convert.ToInt32(cmd.ExecuteScalar());
        
    }
}

                      
                    if (rowsUpdated > 0)
                    {
                      
                     

                        using (SQLiteConnection c = new SQLiteConnection(dbConnection))
{
    c.Open(); string sqlq = "SELECT * FROM details where cdkey='" + cdkey + "';";
    using (SQLiteCommand cmd = new SQLiteCommand(sqlq, c))
    { 
        using (SQLiteDataReader rdr = cmd.ExecuteReader())
        {
            rdr.Read();
             count = Int32.Parse(rdr["count"].ToString());
        }
    }
}
  
                        if (count > 0)
                        {
                          
                            string str = textBox1.Text;
                            str = str.Replace(" ", "");
                            textBox2.Text = GetMD5HashData(str);

                          //  string sql1 = "insert into fulldetails (cdkey,hdd,phno,email,serialkey,date,name) values ('" + cdkey + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + DateTime.Today + "','" + textBox6.Text + "');";
                           // cnn.Close();
                        
                            using (SQLiteConnection c = new SQLiteConnection(dbConnection))
                            {
                                c.Open();
                                string sql1 = "insert into fulldetails (cdkey,hdd,phno,email,serialkey,date,name) values ('" + cdkey + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + DateTime.Today + "','" + textBox6.Text + "');";
                          
                                using (SQLiteCommand cmd = new SQLiteCommand(sql1, c))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            
                          
                            count--;
                             using (SQLiteConnection c = new SQLiteConnection(dbConnection))
                            {
                                c.Open(); string sqlqq = "update  details set  count ='" + count + "' where cdkey ='" + cdkey + "'";
                                using (SQLiteCommand cmd = new SQLiteCommand(sqlqq, c))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            
                        }
                        else { MessageBox.Show("CD KEY IS EXPIERD"); }
                        
                      //  cnn.Close();
                    }
                    else
                    { MessageBox.Show("CD KEY IS INVALID"); }
                   
            }
            else { MessageBox.Show("PLEASEFILL DATA"); }
           
        
        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        { openFileDialog1.Filter = "Text Files (TXT)|*.txt";
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                textBox7.Text = openFileDialog1.FileName;
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            StreamReader sr1 = new StreamReader(@textBox7.Text);
            string line1 = sr1.ReadLine(); string line2 = sr1.ReadLine(); string line3 = sr1.ReadLine(); string line4 = sr1.ReadLine(); string line5 = sr1.ReadLine();
            sr1.Close();
            RSAEncryption myRsa = new RSAEncryption();
            myRsa.LoadPrivateFromXml("PrivateKey.xml");
            byte[] msg = Convert.FromBase64String(line1); byte[] msg1 = Convert.FromBase64String(line2); byte[] msg2 = Convert.FromBase64String(line3);
            byte[] msg3 = Convert.FromBase64String(line4); byte[] msg4 = Convert.FromBase64String(line5);
            textBox1.Text = Encoding.UTF8.GetString(myRsa.PrivateDecryption(msg4)); textBox3.Text = Encoding.UTF8.GetString(myRsa.PrivateDecryption(msg3));
            textBox4.Text = Encoding.UTF8.GetString(myRsa.PrivateDecryption(msg2)); textBox5.Text = Encoding.UTF8.GetString(myRsa.PrivateDecryption(msg1));
            textBox6.Text = Encoding.UTF8.GetString(myRsa.PrivateDecryption(msg));
        }
    }
}
