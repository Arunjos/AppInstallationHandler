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


namespace EncryptionSample
{

    public partial class Form2 : Form
    {
        public string cdkey;
        int count;

        public Form2()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            this.Minimum = DefaultMinimum;
            this.Maximum = DefaultMaximum;
            this.ConsecutiveCharacters = false;
            this.RepeatCharacters = true;
            this.ExcludeSymbols = false;
            this.Exclusions = null;

            rng = new RNGCryptoServiceProvider();

            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void netconnectionAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // var form1 = (KEY)Tag;
           // form1.Show();
            //Close();
            KEY form1 = new KEY();
           // form1.Tag = this;
            form1.Show(this);
            Hide();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
            
      	
		
        protected int GetCryptographicRandomNumber(int lBound, int uBound)
        {   
            // Assumes lBound >= 0 && lBound < uBound
            // returns an int >= lBound and < uBound
            uint urndnum;   
            byte[] rndnum = new Byte[4];   
            if (lBound == uBound-1)  
            {
                // test for degenerate case where only lBound can be returned   
                return lBound;
            }
                                                              
            uint xcludeRndBase = (uint.MaxValue - (uint.MaxValue%(uint)(uBound-lBound)));   
            
            do 
            {      
                rng.GetBytes(rndnum);      
                urndnum = System.BitConverter.ToUInt32(rndnum,0);      
            } while (urndnum >= xcludeRndBase);   
            
            return (int)(urndnum % (uBound-lBound)) + lBound;
        }

        protected char GetRandomCharacter()
        {            
            int upperBound = pwdCharArray.GetUpperBound(0);

            if ( true == this.ExcludeSymbols )
            {
                upperBound = Form2.UBoundDigit;
            }

            int randomCharPosition = GetCryptographicRandomNumber(pwdCharArray.GetLowerBound(0), upperBound);

            char randomChar = pwdCharArray[randomCharPosition];

            return randomChar;
        }
        
        public string Generate()
        {
            // Pick random length between minimum and maximum   
            int pwdLength = GetCryptographicRandomNumber(this.Minimum, this.Maximum);

            StringBuilder pwdBuffer = new StringBuilder();
            pwdBuffer.Capacity = this.Maximum;

            // Generate random characters
            char lastCharacter, nextCharacter;

            // Initial dummy character flag
            lastCharacter = nextCharacter = '\n';

            for ( int i = 0; i < pwdLength; i++ )
            {
                nextCharacter = GetRandomCharacter();

                if ( false == this.ConsecutiveCharacters )
                {
                    while ( lastCharacter == nextCharacter )
                    {
                        nextCharacter = GetRandomCharacter();
                    }
                }

                if ( false == this.RepeatCharacters )
                {
                    string temp = pwdBuffer.ToString();
                    int duplicateIndex = temp.IndexOf(nextCharacter);
                    while ( -1 != duplicateIndex )
                    {
                        nextCharacter = GetRandomCharacter();
                        duplicateIndex = temp.IndexOf(nextCharacter);
                    }
                }

                if ( ( null != this.Exclusions ) )
                {
                    while ( -1 != this.Exclusions.IndexOf(nextCharacter) )
                    {
                        nextCharacter = GetRandomCharacter();
                    }
                }

                pwdBuffer.Append(nextCharacter);
                lastCharacter = nextCharacter;
            }

            if ( null != pwdBuffer )
            {
                return pwdBuffer.ToString();
            }
            else
            {
                return String.Empty;
            }	
        }
            
        public string Exclusions
        {
            get { return this.exclusionSet;  }
            set { this.exclusionSet = value; }
        }

        public int Minimum
        {
            get { return this.minSize; }
            set	
            { 
                this.minSize = value;
                if (Form2.DefaultMinimum > this.minSize)
                {
                    this.minSize = Form2.DefaultMinimum;
                }
            }
        }

        public int Maximum
        {
            get { return this.maxSize; }
            set	
            { 
                this.maxSize = value;
                if ( this.minSize >= this.maxSize )
                {
                    this.maxSize = Form2.DefaultMaximum;
                }
            }
        }

        public bool ExcludeSymbols
        {
            get { return this.hasSymbols; }
            set	{ this.hasSymbols = value;}
        }

        public bool RepeatCharacters
        {
            get { return this.hasRepeating; }
            set	{ this.hasRepeating = value;}
        }

        public bool ConsecutiveCharacters
        {
            get { return this.hasConsecutive; }
            set	{ this.hasConsecutive = value;}
        }

        private const int DefaultMinimum = 9;
        private const int DefaultMaximum = 10;
        private const int UBoundDigit    = 61;

        private RNGCryptoServiceProvider    rng;
        private int 			minSize;
        private int 			maxSize;
        private bool			hasRepeating;
        private bool			hasConsecutive;
        private bool            hasSymbols;
        private string          exclusionSet;
        private char[] pwdCharArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
           cdkey = Generate();
           string dbConnection;
            string inputFile = "database.s3db";
            dbConnection = String.Format("Data Source={0};Version=3;Password=KraQlin;", inputFile);
          //  string sql = "CREATE TABLE fulldetails (id integer primary key, cdkey varchar(1000), hdd varchar(1000),name varchar(1000), email varchar(1000), phno varchar(1000),date varchar(1000),serialkey varchar(1000));";//table syntax
            //string sql = "CREATE TABLE details (id integer primary key, cdkey varchar(1000),count integer(1000),max integer(1000));";//table syntax
                  
            SQLiteConnection cnn = new SQLiteConnection(dbConnection);
            cnn.Open();
          string sql = "SELECT count(*) FROM details where cdkey='"+cdkey+"';";

           // string sql = " DROP Table 'details';";
            SQLiteCommand mycommand = new SQLiteCommand(cnn);
            mycommand.CommandText = sql;
          // int rowsUpdated = mycommand.ExecuteNonQuery();
           int rowsUpdated = Convert.ToInt32(mycommand.ExecuteScalar());
            if (rowsUpdated > 0)
            { MessageBox.Show("UNFORTUNATELY GENERATED CD KEY SAME AS PREVIOUS TRY ANOTHER ONE "); }
            else
            {
                textBox4.Text = cdkey;
                textBox1.Enabled = true;
            }
            cnn.Close(); 
        
        }

        private void viewCdKeyStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Tag = this;
            
            form3.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cdkey != null && textBox1.Text != "")
            {
                try
                {
                     count = Int32.Parse(textBox1.Text);
                }
                catch (Exception ex)
                { MessageBox.Show("Enter a valid \"KEY VALIDITY NUMBER\"");
                return;
                }
                string dbConnection;
                string inputFile = "database.s3db";
                dbConnection = String.Format("Data Source={0};Version=3;Password=KraQlin;", inputFile);
                SQLiteConnection cnn = new SQLiteConnection(dbConnection);
                cnn.Open();
                string sql1 = "insert into details (cdkey,count,max) values ('" + cdkey + "','" + count + "','" + count + "');";
                SQLiteCommand mycommand1 = new SQLiteCommand(cnn);
                mycommand1.CommandText = sql1;
                int rowsUpdated1 = mycommand1.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("SAVED SUCCESFULLY "); 
                textBox1.Text="";
                textBox4.Text = "";
                textBox1.Enabled = false;
            }
            else
            { MessageBox.Show("PLEASE COMPLETE FILL DATA "); }
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
