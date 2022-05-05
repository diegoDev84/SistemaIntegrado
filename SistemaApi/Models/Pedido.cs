using System.Collections.Generic;

namespace SistemaApi.Models
{
    public class Pedido
    {        
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public bool TeleEntrega { get; set; }
        public virtual List<Pedido> ListaPedido { get; set; }
    }
}
