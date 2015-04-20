using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSU_Mod_Edit
{
    public partial class FrmSendReports : Form
    {
        public FrmSendReports()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
           

  
            message.To.Add("coreyshellenberger@hotmail.com");
            message.Subject = txtSubject.ToString();
            message.From = new System.Net.Mail.MailAddress(txtEmail.ToString());
            message.Body=txtMsg.ToString();
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("Smtp.live.com");
            smtp.UseDefaultCredentials = true;
            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
