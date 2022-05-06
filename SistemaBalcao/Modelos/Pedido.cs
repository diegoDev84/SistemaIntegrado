using System;
using System.Collections.Generic;


namespace SistemaBalcao.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string TipoPedido { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataPedido { get; set; }
        
    }
}
