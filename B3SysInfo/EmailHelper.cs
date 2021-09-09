using System;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace loading_screen
{
    /// <summary>
    /// Class for Email Methods
    /// </summary>
    public static class EmailHelper
    {
        public static string SendMessage(string strServer, int nPort, string strUsername, string strPwd, string strTo, string strFrom, string strTitle, string strBody)
        {
            //var fromAddress = new MailAddress(strFrom, strFrom);
            //var toAddress = new MailAddress(strTo, strTo);
            //string fromPassword = strPwd;
            //string subject = strTitle;
            //string body = strBody;

            //var smtp = new SmtpClient
            //{
            //    Host = strServer,
            //    Port = nPort,
            //    EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            //};
            //using (var message = new MailMessage(fromAddress, toAddress)
            //{
            //    Subject = subject,
            //    Body = body
            //})
            //{
            //    try
            //    {
            //        smtp.Send(message);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Exception caught in SendMessage(): {0}",
            //                    ex.ToString());
            //        return ex.Message;
            //    }
            //}


            return "ok";
        }

        public static string SendMessageViaMailKit(string strServer, int nPort, string strUsername, string strPwd, string strTo, string strFrom, string strTitle, string strBody)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(strFrom, strFrom));
            message.To.Add(new MailboxAddress(strTo, strTo));
            message.Subject = strTitle;

            message.Body = new TextPart("plain")
            {
                Text = strBody
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(strServer, nPort, false);

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate(strUsername, strPwd);

                    client.Send(message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught in SendMessage(): {0}",
                                ex.ToString());
                    return ex.Message;
                }
                client.Disconnect(true);
            }

            return "OK";
        }
    }
}
