using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using RSAEncryptionLib;

namespace key_req
{
    public partial class Form2 : Form
    {
        public static string id;
        public static string id1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
       


        private void button3_Click(object sender, EventArgs e)
        {
            // Create a new instance of FolderBrowserDialog.
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            // A new folder button will display in FolderBrowserDialog.
            folderBrowserDlg.ShowNewFolderButton = true;
            //Show FolderBrowserDialog
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                //Show selected folder path in textbox1.
                textBox5.Text = folderBrowserDlg.SelectedPath;
                //Browsing start from root folder.
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }

        private void netConnectionAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Compose a string that consists of three lines.
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
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

     try
     {
        
        

            if (textBox5.Text != "")
            {
                RSAEncryption myRsa = new RSAEncryption();
                myRsa.LoadPrivateFromXml("privateKey.xml");
                byte[] message = Encoding.UTF8.GetBytes(textBox1.Text + "KraQlin" + textBox2.Text + textBox3.Text + textBox4.Text);
                byte[] encMessage = null;
                encMessage = myRsa.PublicEncryption(message);
                id1 = Convert.ToBase64String(encMessage);
                System.IO.StreamWriter file = new System.IO.StreamWriter(@textBox5.Text+"\\key-req.txt");
                file.WriteLine(id1);
               file.Close();
               MessageBox.Show("File created succefully in" + @textBox5.Text+"\\");
            }
            else
                MessageBox.Show("Please select any folder");
    }
              catch (Exception ex)
              {

                  MessageBox.Show("Please select any other folder");
              }
            }
            else
            {
        MessageBox.Show("Completely Fill data");

            }
        }
    }
}
