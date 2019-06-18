using System.Net;
using System.Net.Mail;

namespace HomeWork23_06_19.Services
{
    public delegate void EmailSendDelegate(string toEmail, string header, string mainText);

    public class EmailSender
    {
        public EmailSendDelegate EmailSendDelegate = new EmailSendDelegate(SendEmail);

        private static void SendEmail(string toEmail, string header, string mainText)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("testtumbler34@gmail.com", "Bot");
            // кому отправляем
            MailAddress to = new MailAddress(toEmail);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = header;
            // текст письма
            m.Body = mainText;
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("testtumbler34@gmail.com", "awlisekudrjyftht2v");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
