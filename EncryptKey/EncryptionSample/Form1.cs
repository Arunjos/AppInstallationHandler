using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SQLite;
//using PasswordGenerator;

namespace EncryptionSample
{
    public partial class KEY : Form
    {
        public KEY()
        {
            InitializeComponent();
        }
        int rowsUpdated,count;
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
                if(i<add.Length)
                returnValue.Append(add[i].ToString());
                returnValue.Append(hashData[i].ToString());
             }

            // return hexadecimal string
         // return returnValue.ToString();
            string a = GetSHA1HashData(returnValue.ToString());
           return a.ToString();
           
        }

        /// <summary>
        /// take any string and encrypt it using SHA1 then
        /// return the encrypted data
        /// </summary>
        /// <param name="data">input text you will enterd to encrypt it</param>
        /// <returns>return the encrypted text as hexadecimal string</returns>
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
                if((i+1)%4 == 0 && i!=23)
                    result.Append("-");

            }

            return result.ToString();
        }
       
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //show encrypted data using SHA1 in textBox2
            // textBox2.Text = GetSHA1HashData(textBox1.Text);
            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                string cdkey = textBox4.Text;
                cdkey = cdkey.Replace(" ", "");
                string dbConnection;
                string inputFile = "database.s3db";
                dbConnection = String.Format("Data Source={0};Version=3;Password=KraQlin;", inputFile);

               /* SQLiteConnection cnn = new SQLiteConnection(dbConnection);
                cnn.Open();
                    string sql = "SELECT count(*) FROM details where cdkey='" + cdkey + "';";
                    SQLiteCommand mycommand = new SQLiteCommand(cnn);
                     mycommand.CommandText = sql;
                        int rowsUpdated = Convert.ToInt32(mycommand.ExecuteScalar());*/

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
                      
                      /*  string sqlq = "SELECT * FROM details where cdkey='" + cdkey + "';";
                        SQLiteCommand mycommand1 = new SQLiteCommand(cnn);
                        mycommand1.CommandText = sqlq;
                        SQLiteDataReader rowsUpdated1 = mycommand1.ExecuteReader();
                        rowsUpdated1.Read();
                        int count = Int32.Parse(rowsUpdated1["count"].ToString()); //for getting valuse in selection*/

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
                            
                           // SQLiteCommand mycommand2 = new SQLiteCommand(cnn);
                           // mycommand2.CommandText = sql1;
                           // MessageBox.Show("START");
                           // int rowsUpdated2 = mycommand2.ExecuteNonQuery();
                          //  MessageBox.Show("STOP");
                           /* count--;

                            SQLiteCommand mycommand3 = new SQLiteCommand(cnn);
                            string sqlqq = "update  details set  count ='" + count + "' where cdkey ='" + cdkey + "'";
                            mycommand3.CommandText = sqlqq;
                          int  rowsUpdated2 = mycommand3.ExecuteNonQuery();*/
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
            //uncomment the below line to show encrypted data using SHA1 in textBox2
            //textBox2.Text = GetSHA1HashData(textBox1.Text);
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PwdGenUI form2 = new PwdGenUI();
          //  form2.Tag = this;
           // form2.Show(this);
           // Hide();

            Form2 form2 = new Form2();
            form2.Location = this.Location;
            form2.Tag = this;
            form2.Show(this);
            Hide();

        }

        private void viewCdKeyStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Tag = this;
          //  form3.StartPosition = FormStartPosition.CenterParent;
            form3.Show(this);
            Hide();

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
