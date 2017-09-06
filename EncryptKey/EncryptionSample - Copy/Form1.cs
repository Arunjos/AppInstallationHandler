using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace EncryptionSample
{
    public partial class KEY : Form
    {
        public KEY()
        {
            InitializeComponent();
        }
        /// <summary>
        /// take any string and encrypt it using MD5 then
        /// return the encrypted data 
        /// </summary>
        /// <param name="data">input text you will enterd to encrypt it</param>
        /// <returns>return the encrypted text as hexadecimal string</returns>
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
            string str = textBox1.Text;
str = str.Replace(" ", "");

            if (str.Length > 0)
            textBox2.Text = GetMD5HashData(str);
            else
                MessageBox.Show("PLEASE ENTER A HDD NO.");
            //uncomment the below line to show encrypted data using SHA1 in textBox2
            //textBox2.Text = GetSHA1HashData(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


       

    }
}
