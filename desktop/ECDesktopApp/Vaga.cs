using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDesktopApp
{
    internal class Vaga
    {
        private int id_empresa;
        private string nome;
        private string descricao;
        private string area;
        private string requisitos;
        private string carga_horaria;

        public int Id_empresa { get => id_empresa; set => id_empresa = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Area { get => area; set => area = value; }
        public string Requisitos { get => requisitos; set => requisitos = value; }
        public string Carga_horaria { get => carga_horaria; set => carga_horaria = value; }

        public Vaga(int id_empresa, string nome, string descricao, string area, string requisitos, string carga_horaria)
        {
            this.Id_empresa = id_empresa;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Area = area;
            this.Requisitos = requisitos;
            this.Carga_horaria = carga_horaria;
        }
        public Vaga()
        {
        }

        public Vaga(int id_empresa)
        {
            this.Id_empresa = id_empresa;
        }

        public Vaga(string nome, string descricao, string area, string requisitos, string carga_horaria)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.area = area;
            this.requisitos = requisitos;
            this.carga_horaria = carga_horaria;
        }

        /* --------------------- METODOS --------------------- */

        public bool cadastrarVaga()
        {
            bool cadastrado = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insert = new MySqlCommand("insert into Connect_Vagas (idEmpresa, Nome, Descricao, Area, Requisitos, Carga_Horaria) " +
                    "values('" + id_empresa + "', '" + nome + "', '" + descricao + "', '" + area + "', '" + requisitos + "', '" + carga_horaria + "')", DAO_Conexao.con);

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
            //cria uma nova bvaga no banco de dados
        }

        public MySqlDataReader getVagas() //get de todas as vagas de emprego (se pa da pra filtrar dps)
        {
            MySqlDataReader vagas = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Connect_Vagas", DAO_Conexao.con);

                vagas = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return vagas;
        }

        public MySqlDataReader getVagaById(int id)
        {
            MySqlDataReader vaga = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Connect_Vagas where Codigo = " + id, DAO_Conexao.con);

                vaga = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return vaga;
        }

        public bool excluirVaga(int id)
        {
            bool excluir = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand delete = new MySqlCommand("delete from Connect_Vagas where Codigo = " + id, DAO_Conexao.con);

                delete.ExecuteNonQuery();

                excluir = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluir;
        }

        public bool editarVaga(int id)
        {
            bool editar = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand update = new MySqlCommand("update Connect_Vagas set Nome= '" + nome + "', Descricao= '" + descricao + "', Area= '" + area + "', " +
                    "Requisitos= '" + requisitos + "', Carga_Horaria= '" + carga_horaria + "' where Codigo = " + id, DAO_Conexao.con);

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

        public bool deleteAllVagasEmpresa()
        {
            bool excluir = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand delete = new MySqlCommand("delete from Connect_Vagas where idEmpresa= " + id_empresa, DAO_Conexao.con);

                delete.ExecuteNonQuery();

                excluir = true;
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluir;
        }

    }
}
