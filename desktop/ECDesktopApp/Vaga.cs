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

        public Vaga(string nome, string area, string carga_horaria)
        {
            this.nome = nome;
            this.area = area;
            this.carga_horaria = carga_horaria;
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

                //e preciso deletar as instancias dessa vaga nas outras tabelas antes de poder exclui se nao da problema na foreign key
                MySqlCommand delete = new MySqlCommand("delete from Connect_Aluno_Vaga where Codigo_Vaga = " + id + ";" +
                    "delete from Connect_Vaga_Aluno where Codigo_Vaga = " + id + ";" +
                    "delete from Connect_Vagas where Codigo = " + id, DAO_Conexao.con);

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

                //MySqlCommand delete = new MySqlCommand("delete from Connect_Vagas where idEmpresa= " + id_empresa, DAO_Conexao.con);

                //preguica de explicar, mas basicamente oq isso faz e q verifica todas as tabelas com foreign key pra deletar
                //os registros da empresa e dps deleta todas as vagas da empresa
                string query = "delete Connect_Aluno_Vaga, Connect_Vaga_Aluno from Connect_Vagas " +
                    "inner join Connect_Aluno_Vaga inner join Connect_Vaga_Aluno " +
                    "where Connect_Vagas.Codigo = Connect_Aluno_Vaga.Codigo_Vaga and Connect_Vagas.Codigo = Connect_Vaga_Aluno.Codigo_Vaga " +
                    "and Connect_Vagas.idEmpresa =" + id_empresa + ";" +
                    "delete from Connect_Vagas where idEmpresa= " + id_empresa;

                MySqlCommand delete = new MySqlCommand(query, DAO_Conexao.con);

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

        public MySqlDataReader getEmpresasVagas()
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select *, Connect_Empresa.Nome as NomeEmpresa from Connect_Vagas, Connect_Empresa where Connect_Vagas.idEmpresa = Connect_Empresa.idEmpresa", DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

        public MySqlDataReader getEmpresasVagasById(int id)
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select *, Connect_Empresa.Nome as NomeEmpresa, Connect_Empresa.Descricao as DescricaoEmpresa, " +
                    "Connect_Vagas.Descricao as DescricaoVaga from Connect_Vagas, Connect_Empresa where Connect_Vagas.idEmpresa = Connect_Empresa.idEmpresa " +
                    "and Connect_Vagas.Codigo = " + id, DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

        public bool insertAlunoInteressado(int idAluno, int idVaga)
        {
            bool cadastro = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insert = new MySqlCommand("insert into Connect_Aluno_Vaga (idAluno, Codigo_Vaga) values (" + idAluno + ", " + idVaga + ")", DAO_Conexao.con);

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

        public bool deleteAlunoInteressado(int idAluno, int idVaga)
        {
            bool excluido = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand delete = new MySqlCommand("delete from Connect_Aluno_Vaga where idAluno=" + idAluno + " and Codigo_Vaga=" + idVaga, DAO_Conexao.con);

                delete.ExecuteNonQuery();
                excluido = true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluido;
        }

        public MySqlDataReader getAlunosInteressados(int idVaga)
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand get = new MySqlCommand("select * from Connect_Aluno_Vaga, Connect_Aluno where Connect_Aluno_Vaga.idAluno = Connect_Aluno.idAluno " +
                    "and Connect_Aluno_Vaga.Codigo_Vaga=" + idVaga, DAO_Conexao.con);

                reader = get.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

        public bool setInteresseVaga(int idVaga, int idAluno)
        {
            bool interessado = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insert = new MySqlCommand("insert into Connect_Vaga_Aluno (Codigo_Vaga, idAluno) values (" + idVaga + ", " + idAluno + ")", DAO_Conexao.con);

                insert.ExecuteNonQuery();

                interessado = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return interessado;
        }

        public bool deleteInteresseVaga(int idVaga, int idAluno)
        {
            bool excluir = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand delete = new MySqlCommand("delete from Connect_Vaga_Aluno where Codigo_Vaga = " + idVaga + " and " +
                    "idAluno = " + idAluno, DAO_Conexao.con);

                delete.ExecuteNonQuery();

                excluir = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluir;
        }

        public MySqlDataReader getAlunosInteressantes(int idVaga)
        {
            MySqlDataReader alunos = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand get = new MySqlCommand("select * from Connect_Vaga_Aluno where Codigo_Vaga = " + idVaga, DAO_Conexao.con);

                alunos = get.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return alunos;
        }

        public bool connectCheck(int idVaga, int idAluno)
        {
            bool conectado = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Connect_Vaga_Aluno, Connect_Aluno_Vaga where " +
                    "Connect_Vaga_Aluno.idAluno = Connect_Aluno_Vaga.idAluno and " +
                    "Connect_Vaga_Aluno.Codigo_Vaga = Connect_Aluno_Vaga.Codigo_Vaga and Connect_Aluno_Vaga.idAluno = "+idAluno +
                    " and Connect_Aluno_Vaga.Codigo_Vaga = "+idVaga, DAO_Conexao.con);

                MySqlDataReader reader = select.ExecuteReader();

                if(reader.Read())
                {
                    conectado = true;
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

            return conectado;
        }

        public MySqlDataReader getConnects()
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select *, Connect_Vagas.Nome as NomeVaga, Connect_Empresa.Nome as NomeEmpresa, Connect_Empresa.Email as EmailEmpresa, " +
                    "Connect_Aluno.Nome as NomeAluno, Connect_Aluno.Email as EmailAluno" +
                    " from Connect_Aluno_Vaga, Connect_Vaga_Aluno, Connect_Aluno, Connect_Empresa, Connect_Vagas where " +
                    "Connect_Aluno_Vaga.idAluno = Connect_Vaga_Aluno.idAluno and Connect_Aluno_Vaga.Codigo_Vaga = Connect_Vaga_Aluno.Codigo_Vaga and " +
                    "Connect_Aluno_Vaga.idAluno = Connect_Aluno.idAluno and Connect_Aluno_Vaga.Codigo_Vaga = Connect_Vagas.Codigo and " +
                    "Connect_Vagas.idEmpresa = Connect_Empresa.idEmpresa", DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

        public MySqlDataReader getAllAlunosInteressados()
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select *, Connect_Aluno.Nome as NomeAluno, Connect_Vagas.Nome as NomeVaga " +
                    "from Connect_Vagas, Connect_Aluno_Vaga, Connect_Aluno where " +
                    "Connect_Vagas.Codigo = Connect_Aluno_Vaga.Codigo_Vaga and Connect_Aluno.idAluno = Connect_Aluno_Vaga.idAluno", DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

        public MySqlDataReader searchVagas(string nomeEmpresa)
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                string query = "select *, Connect_Vagas.Nome as NomeVaga, Connect_Empresa.Nome as NomeEmpresa" +
                    " from Connect_Vagas, Connect_Empresa where Connect_Vagas.idEmpresa = Connect_Empresa.idEmpresa ";

                if (!(String.IsNullOrEmpty(nome)))
                {
                    query += " and Connect_Vagas.Nome like '%" + nome + "%' ";
                }
                if (!(String.IsNullOrEmpty(area)))
                {
                    query += " and Connect_Vagas.Area = '" + area + "' ";
                }
                if(!(String.IsNullOrEmpty(carga_horaria)))
                {
                    query += " and Connect_Vagas.Carga_Horaria like '%" + carga_horaria + "%' ";
                }
                if (!(String.IsNullOrEmpty(nomeEmpresa)))
                {
                    query += " and Connect_Empresa.Nome like '%" + nomeEmpresa + "%' ";
                }

                MySqlCommand select = new MySqlCommand(query, DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch( Exception ex )
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

    }
}
