using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBalcao.Requests
{
    public class ClienteRequest
    {
        public static List<Cliente> Clientes()
        {
            string url = "https://dragon-api.herokuapp.com/cliente";
            string json = (new System.Net.WebClient()).DownloadString(url);
            var lista = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lista;
        }

        public static async Task AdicionarCliente(Cliente cliente)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            var content = ToRequest(cliente);
            var response = await httpClient.PostAsync(requestUri: "https://dragon-api.herokuapp.com/cliente", content);
        }

        public static async Task AtualizarCliente(Cliente cliente)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            var content = ToRequest(cliente);
            var response = await httpClient.PutAsync(requestUri: $"https://dragon-api.herokuapp.com/cliente/{cliente.Id}", content);
        }

        public static async Task DeletarCliente(Cliente cliente)
        {
            var httpClient = new HttpClient();
            var uri = $"https://dragon-api.herokuapp.com/cliente/{cliente.Id}";
            var responde = await httpClient.DeleteAsync(uri);
        }

        public static StringContent ToRequest(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            return data;
        }
    }
}
