using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.IO;


namespace key_req
{
    public partial class Form1 : Form
    {
        public static string id;
        public static string id1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
            label6.Text = "Sending..";
            
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher("Select * from Win32_DiskDrive ");
           
            foreach (ManagementObject moDisk in mosDisks.Get())
            {
             if (moDisk["Name"].ToString() == "\\\\.\\PHYSICALDRIVE0")
                   {
                        id = moDisk["SerialNumber"].ToString();
                   
                    break;
                   }
            }

     /*       foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    id1 = nic.GetPhysicalAddress().ToString();
                }
            } */

    
    
    try
    {
        
             MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("aronz0server@gmail.com");
                mail.To.Add("josemoncfrancis@gmail.com");
                mail.Subject = "KEY GETTING REQUST";
                mail.Body = "HDD NUMBER:" + id + "\nName:" + textBox1.Text + "\nCD SerialNO.::" + textBox2.Text + "\nEmail:" + textBox3.Text + "\nTelephone:" + textBox5.Text + "\nMessage:" + textBox4.Text + "\n";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("aronz0server@gmail.com", "arunjos007");
                SmtpServer.EnableSsl = true;
                 SmtpServer.Send(mail);
                 label6.Text = "";
        
                MessageBox.Show("mail Send");
        
}
            catch (Exception ex)
    { label6.Text = "";
   MessageBox.Show("Sending Failed Check your internet connection"+ex);
            }
              
                    }
                else
{
    label6.Text = "";
                    
                    MessageBox.Show( "Completely Fill data");

                    }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void netConnectionNotAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        

     /*var form1 = (Form1)Tag;
            form1.Show();
            Close();*/

       

       
    }
}
