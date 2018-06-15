using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This projetct 
/// </summary>
namespace EmailShooter
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                String CredentialEmailUser = "eu@email.com";
                String CredentialPasswordEmail = "123456";
                String mail1 = "suporte@outlook.com";
                String mail2 = "fnascimento @outlook.com.br";

              bool resposta = ShooterOutlook.ShooterEmail(CredentialEmailUser, CredentialPasswordEmail, mail1, mail2);
                if (resposta != false)
                {
                    Console.WriteLine("Email enviado com sucesso!");
                }
                else {
                    Console.WriteLine("Erro no envio!");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        

        }
    }
}
