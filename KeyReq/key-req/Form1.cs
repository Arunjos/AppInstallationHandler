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


namespace key_req
{
    public partial class Form1 : Form
    {
        public static string id;
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
 try
    {
        
               MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("arunjos007@gmail.com");
                mail.To.Add("josemoncfrancis@gmail.com");
                mail.Subject = "KEY GETTING REQUST";
                mail.Body = "HDD NUMBER:" + id + "\nName:" + textBox1.Text + "\nEmail:" + textBox2.Text + "\nTelephone:" + textBox3.Text + "\nMessage:" + textBox4.Text + "\n";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("arunjos007@gmail.com", "anthony13");
                SmtpServer.EnableSsl = true;
                 SmtpServer.Send(mail);
                 label6.Text = "";
                MessageBox.Show("mail Send");
        
}
            catch (Exception)
    { label6.Text = "";
                MessageBox.Show("Sending Failed Check your internet connection");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
