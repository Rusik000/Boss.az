using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOSSAZ
{
    namespace Network
    {
        public static class MailHelper
        {
            public static readonly string MyEmail = "ruslanmustafayevaydin2000@gmail.com";
            public const int SMTPPort = 587;
            public const string host = "smtp.mail.ru";
            public static void SendEmail(in string to, in string body)
            {
                try
                {
                    string header = $"<h1 style = \"color:green;\"> Boss.az Header </h1>";
                    MailMessage message = new MailMessage(MyEmail, to, "Boss.az Coo inc ©", $"{header}{body}")
                    {
                        IsBodyHtml = true
                    };

                    SmtpClient smtpClient = new SmtpClient($"{host}", SMTPPort)
                    {
                        UseDefaultCredentials = true,
                        Credentials = new NetworkCredential("asoiuexam1920@gmail.com", "asoiuexam123"),
                        EnableSsl = true
                    };
                    smtpClient.Send(message);
                }
                catch (Exception caption)
                {
                    Console.Clear();
                    MessageBox.Show(caption.Message, "Boss.az Coo inc ©", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

