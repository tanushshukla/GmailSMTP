using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GmailSMTPClass
{
    public class SMTPClass
    {

        public void Push(string FromEmail, string ToEmail, string AuthenticationEmail, string AuthenticationEmailPassword, string Subject,string Body)
        {
            try
            {

                SmtpClient MailClient = new SmtpClient("aspmx.l.google.com", 25);
                MailClient.EnableSsl = true;
                MailClient.Credentials = new NetworkCredential(AuthenticationEmail, AuthenticationEmailPassword);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress(FromEmail);
                Msg.To.Add(new MailAddress(ToEmail));
                Msg.Subject = Subject;
                Msg.Body = Body;

                MailClient.Send(Msg);
                Console.WriteLine("Sent");




            }
            catch (Exception ex)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
