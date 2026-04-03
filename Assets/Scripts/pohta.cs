using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.UI;

public class pohta : MonoBehaviour
{




    [SerializeField] InputField field; // Ссылка на ваш InputField - указываем в инспекторе
    string input_text;

    // Получаем текст с помощью поля text в InputField:
   

    public void send()
    {
        input_text = field.text;

        MailMessage message = new MailMessage();
        message.Body = "" + input_text;
        message.From = new MailAddress("testtes19971@mail.ru");
        message.To.Add("testtes19972@gmail.com"); 
        message.BodyEncoding = System.Text.Encoding.UTF8;




        SmtpClient client = new SmtpClient();

        client.Host = "smtp.mail.ru";

        client.Port = 587;

        client.Credentials = new NetworkCredential(message.From.Address, "WDVuNAMGwp2BNAepzan4");


        client.EnableSsl = true;

        ServicePointManager.ServerCertificateValidationCallback =

         delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
{ return true; };


        client.Send(message);

        }
}
