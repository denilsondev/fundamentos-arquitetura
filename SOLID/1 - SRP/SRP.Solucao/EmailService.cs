using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SOLID.SRP.Solucao
{
    public class EmailService
    {
        public static void Enviar(string de, string para, string assunto, string mensagem)
        {
            var mail = new MailMessage(de,para);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = assunto;
            mail.Body = mensagem;
            client.Send(mail);

        }
    }
}
