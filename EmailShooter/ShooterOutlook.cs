using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailShooter
{
    public class ShooterOutlook
    {

        public static bool ShooterEmail(String CredentialEmailUser, String CredentialPasswordEmail, String mail1, string mail2)
        {
            SmtpClient client = new SmtpClient("smtp.live.com");  // use smtp-mail.outlook.com in the case use smtp

            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credentials =
                new System.Net.NetworkCredential("ricardopulini@outlook.com", "minhasenha");
            client.EnableSsl = true;
            client.Credentials = credentials;

            try
            {
                //Aqui deve ser criado um metodo para tratar e copular uma lista de emails
                //var mail = new MailMessage("suporte@outlook.com", "fnascimento@outlook.com.br");
                var mail = new MailMessage("suporte@outlook.com", "fnascimento@outlook.com.br");

                mail.Subject = "Aviso de problema";
                mail.Body = "Ocorreu um problema no servidor verifique!";
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }

            return false;
        }


    }
   }
