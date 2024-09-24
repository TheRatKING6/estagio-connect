using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDesktopApp
{
    internal class DAO_Conexao
    {
        public static MySqlConnection con;
        
        public static Boolean GetConexao(String local, String banco, String user, String senha)
        {
            Boolean retorno = false;

            try
            {
                con = new MySqlConnection("server=" + local + "; User ID=" + user + "; database=" + banco + "; password=" + senha + "; SslMode= none");

                retorno = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return retorno;
        }

        public static Boolean VerificaLogin(String userId, String password, int tipo)
        {
            bool login = false;

            try
            {
                con.Open();
                //Console.WriteLine(userId);
                userId = userId.Replace(",", ".");
                //Console.WriteLine(userId);

                //se for empresa
                if(tipo == 1)
                {
                    MySqlCommand busca = new MySqlCommand("select * from Connect_Empresa where CNPJ='" + userId + "' and senha='" + password + "'", con);
                    MySqlDataReader resultado = busca.ExecuteReader();

                    if(resultado.Read())
                    {
                        login = true;
                    }
                }
                //se for aluno
                else if(tipo == 0)
                {
                    MySqlCommand busca = new MySqlCommand("select * from Connect_Aluno where CPF='" + userId + "' and senha='" + password + "'", con);
                    MySqlDataReader resultado = busca.ExecuteReader();

                    if(resultado.Read())
                    {
                        login = true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                con.Close(); 
            }

            return login;

            //De algum jeito o login ta dando certo mesmo sem eu dar int.Parse() no userId (?????? vai entender)
        }
    }

    
}
