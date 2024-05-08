using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDesktopApp
{
    internal class ManipulcaoData
    {
        public static DateTime getDataNascimento(string dataNascimento) //pega uma data em string e transforma ela em DateTime
        {
            DateTime nascimento = DateTime.Now; //o padrão (caso de erro) e a data atual
            //Console.WriteLine("\n\n\nInformado: " + dataNascimento + "\n\n\nAtual: "+nascimento+"\n\n\n");


            try
            {
                string data = dataNascimento.Trim();

                data = data.Replace("/", " "); //tira as '/' e troca por ' ' (meio inutil kk)

                int anoIndex = data.LastIndexOf(" "); //LastIndexOf(string busca, int indexDeComeco) e um metodo q anda pela string de tras para frente e acha a 'busca'
                int ano = int.Parse(data.Substring(anoIndex + 1)); //Substring(int comeco, int tamanho) e um metodo que pega uma substring comecando pelo 'comeco' e tendo um tamanho 'tamanho'

                int mesIndex = data.LastIndexOf(" ", anoIndex - 1);
                int mes = int.Parse(data.Substring(mesIndex + 1, 2));

                int dia = int.Parse(data.Substring(0, 2));

                //Console.WriteLine("\n\ndia: "+dia+"\nMes: "+mes+"\nAno: "+ano+"\n\n");

                nascimento = new DateTime(ano, mes, dia);
                //Console.WriteLine("\n\nConvertido: "+nascimento.ToString()+"\n\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            return nascimento;
        }

        //Verifica se o aluno tem ao menos 15 anos
        public static bool verificaMaiorIdade(DateTime selecionado)
        {
            bool menorIdade = false;

            DateTime atual = DateTime.Now; //pega a data selecionada e a data atual

            //transforma elas em um int na formata cao mostrado. ex: 01/10/2006 ficaria '20061001'
            int nascimento = int.Parse(selecionado.ToString("yyyyMMdd").Replace("/", ""));
            int hoje = int.Parse(atual.ToString("yyyyMMdd").Replace("/", ""));

            //subtrai a data de hj da data escolhida e se der menos de 150000 significa que o aluno tem menos de 15 anos
            if (hoje - nascimento < 150000)
            {
                menorIdade = true;
            }

            return menorIdade;
        }

        public static String formataData(string data) //pega uma data no formato dedata americano e transforma no formato de data normal
        {
            string nascimento = data.Substring(0, data.IndexOf(" "));
            //Console.WriteLine("\n\n" + nascimento + "\n\n");
            string ano = nascimento.Substring(nascimento.LastIndexOf("/")+1);
            string mes = nascimento.Substring(0, 2);
            //Console.WriteLine("\n\n" + nascimento + "\n\n");
            string dia = nascimento.Substring(nascimento.IndexOf("/")+1, 2);

            //Console.WriteLine("\n\nFormata data: \ndia: " + dia + "\nmes: " + mes + "\nano: " + ano + "\n\n");
                    
            nascimento = dia + "/" + mes + "/" + ano;

            return nascimento;
        }
    }
}
