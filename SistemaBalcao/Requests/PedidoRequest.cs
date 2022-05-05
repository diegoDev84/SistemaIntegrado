using Newtonsoft.Json;
using SistemaBalcao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBalcao.Requests
{
    public class PedidoRequest
    {
        public static List<Pedido>pedidos()
        {
            string url = "https://dragon-api.herokuapp.com/pedido";
            string json = (new System.Net.WebClient()).DownloadString(url);
            var lista = JsonConvert.DeserializeObject<List<Pedido>>(json);
            return lista;
        }

        public static async Task NovoPedido(Pedido pedido)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            var content = ToRequest(pedido);
            var response = await httpClient.PostAsync(requestUri: "https://dragon-api.herokuapp.com/pedido", content);
        }

        public static async Task AtualizarPedido(Pedido pedido)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            var content = ToRequest(pedido);
            var response = await httpClient.PutAsync(requestUri: $"https://dragon-api.herokuapp.com/pedido/{pedido.Id}", content);
        }

        public static async Task DeletarPedido(Pedido pedido)
        {
            var httpClient = new HttpClient();
            var uri = $"https://dragon-api.herokuapp.com/pedido/{pedido.Id}";
            var response = await httpClient.DeleteAsync(uri);
        }

        public static StringContent ToRequest(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            return data;
        }
    }
}