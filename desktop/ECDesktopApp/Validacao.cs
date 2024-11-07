using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDesktopApp
{
    internal class Validacao
    {
        public static bool ATIVADO = true; //garante que certas validacoes so ocorram caso eu deixe-as ativadas
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

        public static bool ValidarCPF(string cpf)
        {
            if (ATIVADO)
            {


                cpf = new string(cpf.Where(char.IsDigit).ToArray());

                if (cpf.Length != 11 || cpf.All(c => c == cpf[0]))
                    return false;

                int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                string tempCpf = cpf.Substring(0, 9);
                int soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

                int resto = (soma * 10) % 11;
                if (resto == 10 || resto == 11)
                    resto = 0;

                string digito = resto.ToString();
                tempCpf += digito;
                soma = 0;

                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

                resto = (soma * 10) % 11;
                if (resto == 10 || resto == 11)
                    resto = 0;

                digito += resto.ToString();

                return cpf.EndsWith(digito);
            }
            else
            {
                return true;
            }
        }

        public static bool ValidarCNPJ(string cnpj)
        {
            if (ATIVADO)
            {


                cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

                if (cnpj.Length != 14 || cnpj.All(c => c == cnpj[0]))
                    return false;

                int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                string tempCnpj = cnpj.Substring(0, 12);
                int soma = 0;

                for (int i = 0; i < 12; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

                int resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                string digito = resto.ToString();
                tempCnpj += digito;
                soma = 0;

                for (int i = 0; i < 13; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito += resto.ToString();

                return cnpj.EndsWith(digito);
            }
            else
            {
                return true;
            }
        }
    }
}
