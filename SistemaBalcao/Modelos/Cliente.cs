
using SistemaBalcao.Modelos;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SistemaBalcao
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Logradouro { get; set; }
        public string? Bairro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string? CEP { get; set; }
        public string? Email { get; set; }
        [JsonIgnore]
        public virtual List<Pedido>? Pedidos { get; set; }
      
    }
}
