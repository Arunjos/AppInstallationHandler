using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Management;

namespace welcome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string id;
        private string GetMD5HashData(string data)
        {

            MD5 md5 = MD5.Create();


            byte[] hashData = md5.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder returnValue = new StringBuilder();
            string add = ".KraQlinAroNzz.";

            for (int i = 0; i < hashData.Length; i++)
            {
                if (i < add.Length)
                    returnValue.Append(add[i].ToString());
                returnValue.Append(hashData[i].ToString());
            }

        
            string a = GetSHA1HashData(returnValue.ToString());
            return a.ToString();

        }

        private string GetSHA1HashData(string data)
        {

            SHA1 sha1 = SHA1.Create();

            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder returnValue = new StringBuilder();

         
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }
            StringBuilder result = new StringBuilder();

          
            for (int i = 0; i < 24; i++)
            {
                result.Append(returnValue[i].ToString());
                if ((i + 1) % 4 == 0 && i != 23)
                    result.Append("-");

            }

            return result.ToString();
        }
       
        
        
        
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher("Select * from Win32_DiskDrive ");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                if (moDisk["Name"].ToString() == "\\\\.\\PHYSICALDRIVE0")
                {
                 id = moDisk["SerialNumber"].ToString();

                    break;
                }
            }
            
            id = id.Replace(" ", "");
         string s = GetMD5HashData(id);
            if(s==textBox1.Text)
                MessageBox.Show("WELCOME");
            else
                MessageBox.Show("INVALID SERIAL NO.");


        }
    }
}
