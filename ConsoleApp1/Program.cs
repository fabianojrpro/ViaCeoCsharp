using Newtonsoft.Json;
namespace ConsoleApp1
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Digite o CEP que você deseja consultar: ");
            string cep = Console.ReadLine();
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(json);

                    string logradouro = data.logradouro;
                    string bairro = data.bairro;
                    string localidade = data.localidade;
                    string uf = data.uf;

                    Endereco endereco = new Endereco(logradouro, bairro, localidade, uf);
                    Console.WriteLine(endereco);

                }
                else
                {
                    Console.WriteLine("Não foi possível obter as informações do CEP fornecido.");
                }
            }
        }
    }
}