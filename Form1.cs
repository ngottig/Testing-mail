using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Testing_mail
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

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress(txtDireccionMail.Text);

                // The important part -- configuring the SMTP client
                SmtpClient smtp = new SmtpClient();
                smtp.Port = Convert.ToInt32(txtPuerto.Text);   // [1] You can try with 465 also, I always used 587 and got success

                if (txtSSL.Text == "S") smtp.EnableSsl = true;
                else smtp.EnableSsl = false;

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // [2] Added this
                smtp.UseDefaultCredentials = false; // [3] Changed this
                smtp.Credentials = new NetworkCredential(txtDireccionMail.Text, txtClaveMail.Text);  // [4] Added this. Note, first parameter is NOT string.
                smtp.Host = txtServerMail.Text;

                //recipient address
                mail.To.Add(new MailAddress(txtDestinatario.Text));

                //Formatted mail body
                mail.IsBodyHtml = true;

                mail.Subject = txtAsunto.Text;
                mail.Body = txtTextoMail.Text;
                smtp.Send(mail);

                string box_msg = "Correcto";
                string box_title = "El mail se envió correctamente";
                MessageBox.Show(box_msg, box_title);
            }
            catch (Exception ex) {

                string box_title = "Error";
                string box_msg = "El mail no se envió, detalle del error: " + ex.ToString();
                MessageBox.Show(box_msg, box_title);
            }
        }
    }
}
