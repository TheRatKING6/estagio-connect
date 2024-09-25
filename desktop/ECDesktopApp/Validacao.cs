using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDesktopApp
{
    internal class Validacao
    {
        public static bool ValidarEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                return false;
            }
            else if(!(email.Contains("@") && email.Contains(".")))
            {
                return false;
            }
            else if(email.StartsWith("@") || email.EndsWith("@") || email.EndsWith("."))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        
        //public static bool ValidarCPF(string cpf)
        //{
        //    bool ativo = false;
        //    bool valido = false;

        //    if (ativo)
        //    {

        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}
