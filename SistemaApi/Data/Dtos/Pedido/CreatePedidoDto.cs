using System;
using System.Collections.Generic;

namespace SistemaApi.Data.Dtos.Pedido
{
    public class CreatePedidoDto
    {
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
