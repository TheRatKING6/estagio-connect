using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDesktopApp
{
    internal class Aluno
    {
        private string cpf;
        private string matricula;
        private string nome;
        private string nascimento;
        private string email;
        private string telefone;
        private string especialidade;
        private byte foto;
        private byte curriculo;
        private string descricao;
        private string rua;
        private int numero;
        private string bairro;
        private string complemento;
        private string cidade;
        private string estado;
        private string cep;
        private string status;
        private int ano;
        private string escola;
        private string senha;

        public Aluno() { }

        public Aluno(string cpf)
        {
            this.cpf = cpf;
        }

        public Aluno(string cpf, string senha)
        {
            this.cpf = cpf;
            this.senha = senha;
        }

        public Aluno(string cpf, string matricula, string nome, string nascimento, string email, string telefone, string especialidade, string descricao,
            string rua, int numero, string bairro, string complemento, string cidade, string estado, string cep, string status, int ano, string escola, string senha)
        {
            this.cpf = cpf;
            this.matricula = matricula;
            this.nome = nome;
            this.nascimento = nascimento;
            this.email = email;
            this.telefone = telefone;
            this.especialidade = especialidade;
            this.descricao = descricao;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.status = status;
            this.ano = ano;
            this.escola = escola;
            this.senha = senha;
        }

        public Aluno(string cpf, string matricula, string nome, string nascimento, string email, string telefone, string especialidade, byte foto, byte curriculo, string descricao, 
            string rua, int numero, string bairro, string complemento, string cidade, string estado, string cep, string status, int ano, string escola, string senha)
        {
            this.cpf = cpf;
            this.matricula = matricula;
            this.nome = nome;
            this.nascimento = nascimento;
            this.email = email;
            this.telefone = telefone;
            this.especialidade = especialidade;
            this.foto = foto;
            this.curriculo = curriculo;
            this.descricao = descricao;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.status = status;
            this.ano = ano;
            this.escola = escola;
            this.senha = senha;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }
        public byte Foto { get => foto; set => foto = value; }
        public byte Curriculo { get => curriculo; set => curriculo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Status { get => status; set => status = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Escola { get => escola; set => escola = value; }
        public string Senha { get => senha; set => senha = value; }


        /************************************* metodos *************************************/

        public bool cadastrarAluno()
        {
            bool cadastrado = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insert = new MySqlCommand("insert into Connect_Aluno (CPF, Matricula, Nome, Nascimento, Email, Telefone, Especialidade, Descricao, Rua, " +
                    "Numero, Bairro, Complemento, Cidade, Estado, CEP, Status, Ano_Letivo, Escola, Senha) values('" + cpf + "', '" + matricula + "', '" + nome + "', '" + nascimento+ "'," +
                    " '" + email + "', '" + telefone + "', '" + especialidade + "', '" + descricao + "', '" + rua + "', " + numero + ", '" + bairro + "', '" + complemento + "', '" + cidade + "', '" + estado + "', " +
                    "'" + cep + "', '" + status + "', " + ano + ", '" + escola + "', '" + senha + "')", DAO_Conexao.con);

                insert.ExecuteNonQuery();

                cadastrado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cadastrado;
        }

        public bool verificaCpfCadastrado()
        {
            bool existe = false;
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Connect_Aluno where CPF='" + cpf + "'", DAO_Conexao.con);

                reader = select.ExecuteReader();

                if(reader.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return existe;
        }
    }
}
