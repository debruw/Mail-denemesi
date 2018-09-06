using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            string kime = textBox1.Text;
            string konu = textBox2.Text;
            string icerik = textBox3.Text;

            sc.Credentials = new NetworkCredential("debruwc@gmail.com", "********");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("debruwc@gmail.com", "Ebru Ç.");
            mail.To.Add(kime);

            mail.Subject = konu;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            sc.Send(mail);
        }
    }
}
