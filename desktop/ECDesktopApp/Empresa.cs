using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDesktopApp
{
    internal class Empresa
    {
        private string cnpj;
        private string nome;
        private string rua;
        private int numero;
        private string bairro;
        private string complemento;
        private string cidade;
        private string estado;
        private string cep;
        private string email;
        private string telefone;
        private string ramo;
        private string descricao;
        private byte[] foto;
        private string senha;

        public Empresa() { }

        public Empresa(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public Empresa(string cnpj, string senha)
        {
            this.cnpj= cnpj;
            this.senha = senha;
        }

        public Empresa(string cnpj, string nome, string ramo, string email, string cidade)
        {
            this.cnpj = cnpj;
            this.nome = nome;
            this.ramo = ramo;
            this.email = email;
            this.cidade = cidade;
        }

        public Empresa(string cnpj, string nome, string rua, int numero, string bairro, string complemento, string cidade, string estado, string cep, string email,
            string telefone, string ramo, string descricao, string senha)
        {
            this.cnpj = cnpj;
            this.nome = nome;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.email = email;
            this.telefone = telefone;
            this.ramo = ramo;
            this.descricao = descricao;
            this.senha = senha;
        }

        public Empresa(string cnpj, string nome, string rua, int numero, string bairro, string complemento, string cidade, string estado, string cep, string email, 
            string telefone, string ramo, byte[] foto, string descricao, string senha)
        {
            this.cnpj = cnpj;
            this.nome = nome;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.email = email;
            this.telefone = telefone;
            this.ramo = ramo;
            this.foto = foto;
            this.descricao = descricao;
            this.senha = senha;
        }

        public Empresa(string cnpj, string nome, string rua, int numero, string bairro, string complemento, string cidade, string estado, string cep, string email, string telefone, string ramo, string descricao)
        {
            this.cnpj = cnpj;
            this.nome = nome;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.email = email;
            this.telefone = telefone;
            this.ramo = ramo;
            this.descricao = descricao;
        }

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Ramo { get => ramo; set => ramo = value; }
        public byte[] Foto { get => foto; set => foto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Senha { get => senha; set => senha = value; }


        /********************************** metodos **********************************/

        public bool cadastrarEmpresa()
        {
            bool cadastro = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insert = new MySqlCommand("insert into Connect_Empresa (CNPJ, Nome, Rua, Numero, Bairro, Complemento, Cidade, Estado, CEP, Email, Telefone, " +
                    "Ramo, Descricao, Senha, Foto) values('" + cnpj + "', '" + nome + "', '" + rua + "', " + numero + ", '" + bairro + "', '" + complemento + "', '" + cidade + "', '" + estado + "'," +
                    " '" + cep + "', '" + email + "', '" + telefone + "', '" + ramo + "', '" + descricao + "', '" + senha + "', '" + foto + "')", DAO_Conexao.con); //insert SEM a Foto (ainda n sei como usar foto, priscila nunca ensinou)

                insert.ExecuteNonQuery();

                cadastro = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cadastro;
        }


        public bool verificaCadastroEmpresa()
        {
            bool verificacao = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Connect_Empresa where CNPJ='" + cnpj + "'", DAO_Conexao.con);

                MySqlDataReader result = select.ExecuteReader();

                if (result.Read())
                {
                    verificacao = true;
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine( ex.ToString()); 
            } 
            finally 
            { 
                DAO_Conexao.con.Close();
            }

            return verificacao;
        }

        public int getCodigo_Empresa()
        {
            int codigo = -1;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand select = new MySqlCommand("select idEmpresa from Connect_Empresa where CNPJ='" + cnpj + "'", DAO_Conexao.con);

                MySqlDataReader result = select.ExecuteReader();

                while(result.Read())
                {
                    codigo = result.GetInt32(0);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine( ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return codigo;
        }

        public MySqlDataReader getInfosEmpresa()
        {
            MySqlDataReader empresa = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Connect_Empresa where CNPJ='" + cnpj + "'", DAO_Conexao.con);

                empresa = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.ToString());
            }

            return empresa;
        }

        public bool deleteEmpresa()
        {
            bool excluir = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand delete = new MySqlCommand("delete from Connect_Empresa where CNPJ='" + cnpj + "'", DAO_Conexao.con);

                delete.ExecuteNonQuery();

                excluir = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluir;
        }

        public bool editarEmpresa()
        {
            bool editar = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand update = new MySqlCommand("update Connect_Empresa set Nome='" + nome + "', Rua='" + rua + "', Numero=" + numero + ", Bairro='" + bairro + "', " +
                    "Complemento='" + complemento + "', Cidade='" + cidade + "', Estado='" + estado + "', CEP='" + cep + "', Email='" + email + "', Telefone='" + telefone + "', " +
                    "Ramo='" + ramo + "', Descricao='" + descricao + "' where CNPJ='" + cnpj + "'", DAO_Conexao.con);

                update.ExecuteNonQuery();

                editar = true;
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return editar;
        }

        public MySqlDataReader getAllEmpresas()
        {
            MySqlDataReader empresa = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Connect_Empresa", DAO_Conexao.con);

                empresa = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return empresa;
        }

        public MySqlDataReader seearchEmpresas()
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                string query = "select * from Connect_Empresa where 1=1 ";

                if (!(String.IsNullOrEmpty(nome)))
                {
                    query += " and Nome like '%" + nome + "%' ";
                }
                if (!(String.IsNullOrEmpty(ramo)))
                {
                    query += " and Ramo like '%" + ramo + "%' ";
                }
                if (!(String.IsNullOrEmpty(email)))
                {
                    query += " and Email like '%" + email + "%' ";
                }
                if(!(String.IsNullOrEmpty(cidade)))
                {
                    query += " and Cidade like '%" + cidade + "%' ";
                }

                MySqlCommand select = new MySqlCommand(query, DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

        public string getCnpjById(int idEmpresa)
        {
            string cnpj = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Connect_Empresa where idEmpresa = " + idEmpresa, DAO_Conexao.con);

                MySqlDataReader reader = select.ExecuteReader();

                while (reader.Read())
                {
                    cnpj = reader["CNPJ"].ToString();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cnpj;
        }

    }

    
}
