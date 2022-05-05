using Newtonsoft.Json;
using SistemaBalcao.Modelos;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBalcao.Requests
{
    public class CategoriaRequest
    {
        public static List<Categoria> Categorias()
        {
            string url = "https://dragon-api.herokuapp.com/categoria";
            string json = (new System.Net.WebClient()).DownloadString(url);
            var lista = JsonConvert.DeserializeObject<List<Categoria>>(json);
            return lista;
        }

        public static async Task AdicionarCategoria(Categoria categoria)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            var content = ToRequest(categoria);
            var response = await httpClient.PostAsync(requestUri: "https://dragon-api.herokuapp.com/categoria", content);
        }

        public static async Task AtualizarCategoria(Categoria categoria)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            var content = ToRequest(categoria);
            var response = await httpClient.PutAsync(requestUri: $"https://dragon-api.herokuapp.com/categoria/{categoria.Id}", content);
        }

        public static async Task DeletarCategoria(Categoria categoria)
        {
            var httpClient = new HttpClient();
            var uri = $"https://dragon-api.herokuapp.com/categoria/{categoria.Id}";
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
