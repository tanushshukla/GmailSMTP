using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GmailSMTPClass;
namespace GMailSMTPInterface
{
    public partial class GmailUI : Form
    {
        public GmailUI()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string authMailAuthFrom = "tanushdroid@gmail.com";
            string authMailPassword = "youpassword";
            string mailBody = "";
            string mailSubject = "";
            string mailFrom = "";
            string mailTo = "";
            
            try
            {
                authMailAuthFrom = txtAuthEmail.Text;
                authMailPassword = txtAuthPass.Text;
                mailBody = txtBody.Text;
                mailSubject = txtMailSubject.Text;
                mailFrom = txtMailFrom.Text;
                mailTo = txtMailTo.Text;

                SMTPClass SendMail = new SMTPClass();
                SendMail.Push(mailFrom, mailTo, authMailAuthFrom, authMailPassword, mailSubject, mailBody);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
