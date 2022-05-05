using Newtonsoft.Json;
using SistemaBalcao.Modelos;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBalcao.Requests
{
    public class ComplementoRequest
    {
        public static List<Complemento> Complementos()
        {
            string url = "https://dragon-api.herokuapp.com/complemento";
            string json = (new System.Net.WebClient()).DownloadString(url);
            var lista = JsonConvert.DeserializeObject<List<Complemento>>(json);
            return lista;
        }

        public static async Task AdicionarComplemento(Complemento complemento)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            var content = ToRequest(complemento);
            var response = await httpClient.PostAsync(requestUri: "https://dragon-api.herokuapp.com/complemento", content);
        }

        public static async Task AtualizarComplemento(Complemento complemento)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            var content = ToRequest(complemento);
            var response = await httpClient.PutAsync(requestUri: $"https://dragon-api.herokuapp.com/complemento/{complemento.Id}", content);
        }

        public static async Task DeletarComplemento(Complemento complemento)
        {
            var httpClient = new HttpClient();
            var uri = $"https://dragon-api.herokuapp.com/complemento/{complemento.Id}";
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
