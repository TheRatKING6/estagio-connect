﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        private byte foto;
        private string descricao;
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
            string telefone, string ramo, byte foto, string descricao, string senha)
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
        public byte Foto { get => foto; set => foto = value; }
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
                    "Ramo, Descricao, Senha) values('"+cnpj+"', '"+nome+"', '"+rua+"', "+numero+", '"+bairro+"', '"+complemento+"', '"+cidade+"', '"+estado+"'," +
                    " '"+cep+"', '"+email+"', '"+telefone+"', '"+ramo+"', '"+descricao+"', '"+senha+"')", DAO_Conexao.con); //insert SEM a Foto (ainda n sei como usar foto, priscila nunca ensinou)

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
    }

    
}
