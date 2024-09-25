using MySqlX.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ECDesktopApp
{
    internal class Apis
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public async static Task<Endereco> getEnderecoFromCEP(string cep)
        {
            string cepFormat = cep.Replace("-", ""); //formata o cep


            string apiUrl = $"https://viacep.com.br/ws/{cep}/json/"; //link da api

            try
            {
                //faz o request e paga a resposta
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    //pega a resposta do request, transforma em string, des-serializa a string do Json em um obj Endereco pra ficar mais facil de pegar as propriedades individualmente
                    string responseData = await response.Content.ReadAsStringAsync();
                    Endereco endereco = JsonConvert.DeserializeObject<Endereco>(responseData);
                    return endereco;
                }
                else
                {
                    //se a resposta nao for um sucesso
                    Console.WriteLine(response.StatusCode);
                    return null;
                }
            }
            catch (Exception ex) //qualquer outra excessao
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            
        }
    }
}
