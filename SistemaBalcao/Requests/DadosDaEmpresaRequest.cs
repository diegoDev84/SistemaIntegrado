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
    public class DadosDaEmpresaRequest
    {
        public static DadosDaEmpresa Empresa()
        {
            string url = "https://dragon-api.herokuapp.com/empresa/1";
            string json = (new System.Net.WebClient()).DownloadString(url);
            var lista = JsonConvert.DeserializeObject<DadosDaEmpresa>(json);
            return lista;
        }

        public static async Task AtualizarEmpresa(DadosDaEmpresa empresa)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            var content = ToRequest(empresa);
            var response = await httpClient.PutAsync(requestUri: $"https://dragon-api.herokuapp.com/empresa/1", content);
        }

        public static StringContent ToRequest(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            return data;
        }
    }
}
