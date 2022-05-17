using Newtonsoft.Json;
using SistemaBalcao.Modelos;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBalcao.Requests
{
    public class ProdutoRequest
    {
        public static List<Produto>Produtos()
        {
            string url = "https://dragon-api.herokuapp.com/produto";
            string json = (new System.Net.WebClient()).DownloadString(url);
            var lista = JsonConvert.DeserializeObject<List<Produto>>(json);
            return lista;
        }

        public static async Task AdicionarProduto(Produto produto)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            var content = ToRequest(produto);
            var response = await httpClient.PostAsync(requestUri: "https://dragon-api.herokuapp.com/produto", content);
        }

        public static async Task AtualizarProduto(Produto produto)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            var content = ToRequest(produto);
            var response = await httpClient.PutAsync(requestUri: $"https://dragon-api.herokuapp.com/produto/{produto.Id}", content);
        }

        public static async Task DeletarProduto(Produto produto)
        {
            var httpClient = new HttpClient();
            var uri = $"https://dragon-api.herokuapp.com/produto/{produto.Id}";
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
