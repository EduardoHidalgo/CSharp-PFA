using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace Personal_Finance_Assistance
{
    public static class Send_Mail
    {
        static string Program_Mail = "EDREI_PFA@hotmail.com";  //Correo para credenciales
        static string Password_Mail = "23DG/J4E";                   //Contraseña para credenciales

        public static void Send(string User, string Password, string User_Mail)  //Método para el envío de los datos de usuario a la persona respectiva
        {
            MailMessage Message = new MailMessage();
            Message.To.Add(User_Mail);    //Correo del destinatario
            Message.From = new MailAddress(Program_Mail, "Program Finance Assistant", Encoding.UTF8);  //Datos del remitente
            Message.Subject = "PFA - Recordatorio de usuario y contraseña";  //Asunto
            Message.SubjectEncoding = Encoding.UTF8;
            Message.Body = "Su usuario es: " + User + "\n Su Clave es: " + Password;     //Cuerpo del mensaje
            Message.BodyEncoding = Encoding.ASCII;
            SmtpClient Client = new SmtpClient();  //MÉTODOS PARA EL USO DE LOS PERMISOS Y CREDENCIALES
            Client.Credentials = new NetworkCredential(Program_Mail, Password_Mail);
            if (User_Mail.Contains("gmail") == true)   //Revisa si el correo del usuario es de Gmail (true) o de otro servicio (false)
            {
                Client.Host = "smtp.gmail.com";   //Host del correo
            }
            else if (User_Mail.Contains("hotmail") == true)
            {
                Client.Host = "smtp.live.com";   //Host del correo
            }
            else
            {
                Client.Host = "smtp.mail.yahoo.com";   //Host del correo
            }
            Client.Port = 587;
            Client.EnableSsl = true;    //Codificación segura del mensaje
            Client.Send(Message);  //Envía el mensaje
        }
    }
}
