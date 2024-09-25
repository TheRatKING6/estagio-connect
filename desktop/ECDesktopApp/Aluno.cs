using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
        //private byte[] foto;
        //private byte[] curriculo;
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

        //TESTE
        //------------------------------------------- CURRICULO E FOTO ---------------------------------------------
        public String caminhoCurriculo { get; set; }
        public String caminhoFoto { get; set; }
        public byte[] curriculo { get; set; }
        public byte[] foto { get; set; }

        public void PegarCurriculo(int idAluno, Aluno aluno)
        {
            var sql = "SELECT Curriculo from Connect_Aluno WHERE idAluno ='" + idAluno + "'";

            using (var con = DAO_Conexao.con)
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                aluno.curriculo = (byte[])dr["Curriculo"];
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        public void SalvarCurriculo()
        {
            byte[] curriculo = GetCurriculo(caminhoCurriculo);

            var sql = "UPDATE Connect_Aluno SET curriculo = @curriculo WHERE CPF ='" + cpf + "'";

            using (var con = DAO_Conexao.con)
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@curriculo", MySqlDbType.Blob).Value = curriculo;

                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private byte[] GetCurriculo(string caminhoCurriculo)
        {
            byte[] curriculo;
            using (var stream = new FileStream(caminhoCurriculo, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    curriculo = reader.ReadBytes((int)stream.Length);
                }
            }
            return curriculo;
        }



        public void PegarFoto(int idAluno, Aluno aluno)
        {
            var sql = "SELECT foto from Connect_Aluno WHERE idAluno ='" + idAluno + "'";

            using (var con = DAO_Conexao.con)
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                aluno.foto = (byte[])dr["Foto"];
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        public void SalvarFoto()
        {
            byte[] foto = GetFoto(caminhoFoto);

            var sql = "UPDATE Connect_Aluno SET foto = @foto WHERE CPF ='" + cpf + "'";

            using (var con = DAO_Conexao.con)
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@foto", MySqlDbType.Blob).Value = foto;

                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private byte[] GetFoto(string caminhoFoto)
        {
            byte[] foto;
            using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    foto = reader.ReadBytes((int)stream.Length);
                }
            }
            return foto;
        }

        //------------------------------------------- FIM CURRICULO E FOTO ---------------------------------------------


        public Aluno() { }

        public Aluno(string cpf)
        {
            this.cpf = cpf;
        }

        public Aluno(string cpf, string nome, string escola, string email, string cidade, string especialidade)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.escola = escola;
            this.email = email;
            this.cidade = cidade;
            this.especialidade = especialidade;
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

        public Aluno(string cpf, string matricula, string nome, string nascimento, string email, string telefone, string especialidade, byte[] foto, byte[] curriculo, string descricao, 
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
        public byte[] Foto { get => foto; set => foto = value; }
        public byte[] Curriculo { get => curriculo; set => curriculo = value; }
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

        public bool cadastrarAluno() //auto-explicativo
        {
            bool cadastrado = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insert = new MySqlCommand("insert into Connect_Aluno (CPF, Matricula, Nome, Nascimento, Email, Telefone, Especialidade, Descricao, Rua, " +
                    "Numero, Bairro, Complemento, Cidade, Estado, CEP, Status, Ano_Letivo, Escola, Senha, Foto, Curriculo) values('" + cpf + "', '" + matricula + "', '" + nome + "', '" + nascimento + "'," +
                    " '" + email + "', '" + telefone + "', '" + especialidade + "', '" + descricao + "', '" + rua + "', " + numero + ", '" + bairro + "', '" + complemento + "', '" + cidade + "', '" + estado + "', " +
                    "'" + cep + "', '" + status + "', " + ano + ", '" + escola + "', '" + senha + "', '" + foto + "', '" + curriculo + "')", DAO_Conexao.con);

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

        public bool verificaCpfCadastrado() //verifica se ja existe um aluno cadastrado com o cpf informado
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

        public MySqlDataReader getInfoAluno() //auto-explicativo
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Connect_Aluno where CPF='"+ cpf + "'", DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            return reader;
        }

        public int getIdAluno() //pega o id do aluno usando o cpf dele
        {
            int id = -1;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select idAluno from Connect_Aluno where CPF='" + cpf + "'", DAO_Conexao.con);

                MySqlDataReader reader = select.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader["idAluno"].ToString());
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

            return id;
        }

        public string getEspecializacaoAluno() //pega a area de especialidade do aluno
        {
            string area = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select Especialidade from Connect_Aluno where CPF='" + cpf + "'", DAO_Conexao.con);

                MySqlDataReader reader = select.ExecuteReader();

                while(reader.Read())
                {
                    area = reader["Especialidade"].ToString();
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

            return area;
        }

        public MySqlDataReader getVagasInteressantes(int idAluno) //pega o *id* de todas as vagas que o aluno esta interessado
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Connect_Aluno_Vaga where idAluno=" + idAluno, DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

        public string getCpfById(int id) //auto-explicativo
        {
            string cpf = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select CPF from Connect_Aluno where idAluno =" + id, DAO_Conexao.con);

                MySqlDataReader reader = select.ExecuteReader();

                while (reader.Read())
                {
                    cpf = reader["CPF"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close( );
            }

            return cpf;
        }

        public bool deleteAluno(int idAluno) //deleta tudo relacionado ao aluno da base de dados
        {
            bool excluido = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand deleteAluno = new MySqlCommand("delete from Connect_Aluno where CPF= '" + cpf + "'", DAO_Conexao.con);
                MySqlCommand deleteInteresses = new MySqlCommand("delete from Connect_Aluno_Vaga where idAluno="+idAluno, DAO_Conexao.con);
                MySqlCommand deleteInteressados = new MySqlCommand("delete from Connect_Vaga_Aluno where idAluno=" + idAluno, DAO_Conexao.con);

                deleteInteresses.ExecuteNonQuery();
                deleteInteressados.ExecuteNonQuery();
                deleteAluno.ExecuteNonQuery(); //apagar o aluno no Connect_Aluno tem que ser o ultimo a ser executado por causa das foreign key

                excluido = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluido;
        }

        public bool editarInfosAluno() //auto-explicativo
        {
            bool editar = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand update = new MySqlCommand("update Connect_Aluno set Matricula='" + matricula + "', Email='" + email + "', Telefone='" + telefone + "', Especialidade='" + especialidade + "'," +
                    " Descricao='" + descricao + "', Rua='" + rua + "', Numero=" + numero + ", Bairro='" + bairro + "', Complemento='" + complemento + "', Cidade='" + cidade + "', Estado='" + estado + "'," +
                    " CEP='" + cep + "', Status='" + status + "', Ano_Letivo='" + ano + "', Escola='" + escola + "' where CPF='" + cpf + "'", DAO_Conexao.con);

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

        public bool editarInfosById(int id)
        {
            bool editar = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand update = new MySqlCommand("update Connect_Aluno set CPF='" + cpf + "', Nome='" + nome + "', Nascimento='" + nascimento + "', " +
                    "Matricula='" + matricula + "', Email='" + email + "', Telefone='" + telefone + "', Especialidade='" + especialidade + "'," +
                    " Descricao='" + descricao + "', Rua='" + rua + "', Numero=" + numero + ", Bairro='" + bairro + "', Complemento='" + complemento + "', Cidade='" + cidade + "', Estado='" + estado + "'," +
                    " CEP='" + cep + "', Status='" + status + "', Ano_Letivo='" + ano + "', Escola='" + escola + "' where idAluno='" + id + "'", DAO_Conexao.con);

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

        public MySqlDataReader getInfosVagasInteressantes(int idAluno) //pega todas as informacoes sobre as vagas em que o aluno esta interessado, inclusive infos sobre a empresa que criou a vaga
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select *, Connect_Vagas.Nome as NomeVaga, Connect_Empresa.Nome as NomeEmpresa from Connect_Aluno_Vaga, Connect_Vagas, Connect_Empresa where " +
                    "Connect_Aluno_Vaga.idAluno=" + idAluno + " and Connect_Aluno_Vaga.Codigo_Vaga = Connect_Vagas.Codigo and Connect_Vagas.idEmpresa = Connect_Empresa.idEmpresa", DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

        public MySqlDataReader getInfosVagasInteressadas(int idAluno) //pega todas as infos sobre as vagas que estao interessadas no aluno, inclusive sobre a empresa por tras dela
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select *, Connect_Vagas.Nome as NomeVaga, Connect_Empresa.Nome as NomeEmpresa from Connect_Vaga_Aluno, Connect_Vagas, Connect_Empresa where " +
                    "Connect_Vaga_Aluno.idAluno=" + idAluno + " and Connect_Vaga_Aluno.Codigo_Vaga = Connect_Vagas.Codigo and Connect_Vagas.idEmpresa = Connect_Empresa.idEmpresa",
                    DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

        public MySqlDataReader searchAlunos()
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                string query = "select * from Connect_Aluno where 1=1 ";

                if (!(String.IsNullOrEmpty(nome)))
                {
                    query += " and Nome like '%" + nome + "%' ";
                }
                if(!(String.IsNullOrEmpty(especialidade))) 
                {
                    query += " and Especialidade = '" + especialidade + "' ";
                }
                if(!(String.IsNullOrEmpty(cidade)))
                {
                    query += " and Cidade like '%" + cidade + "%' ";
                }
                if (!(String.IsNullOrEmpty(escola)))
                {
                    query += " and Escola like '%" + escola + "%' ";
                }
                if(!(String.IsNullOrEmpty(email)))
                {
                    query += " and Email like '%" + email + "%' ";
                }

                //MySqlCommand select = new MySqlCommand("select * from Connect_Aluno where ('"+nome+"' is null or Nome = '"+nome+"') " +
                //    "and ('"+especialidade+"' is null or Especialidade = '"+especialidade+"') " +
                //    "and ('"+cidade+"' is null or Cidade = '"+cidade+"') " +
                //    "and ('"+escola+"' is null or Escola = '"+escola+"') " +
                //    "and ('"+email+"' is null or Email = '"+email+"')", DAO_Conexao.con);

                MySqlCommand select = new MySqlCommand(query, DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

        //public Image getFotoAluno()
        //{
        //    Image foto = null;

        //    try
        //    {
        //        DAO_Conexao.con.Open();
        //        byte[] getImg = new byte[0];
        //        MySqlCommand cmd = new MySqlCommand("select Foto from Connect_Aluno where CPF='" + cpf + "'", DAO_Conexao.con);

        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd);

        //        DataSet ds = new DataSet();

        //        da.Fill(ds, "Connect_Aluno");

        //        byte[] byteBlob = new byte[0];
        //        byteBlob = (byte[])(ds.Tables["Connect_Aluno"].Rows[ds.Tables["Connect_Aluno"].Rows.Count - 1]["Foto"]);

        //        MemoryStream strm = new MemoryStream(byteBlob.ToArray());

        //        foto = Image.FromStream(strm, true, false);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //    finally
        //    {
        //        DAO_Conexao.con.Close();
        //    }

        //    return foto;
        //}
    }
}
