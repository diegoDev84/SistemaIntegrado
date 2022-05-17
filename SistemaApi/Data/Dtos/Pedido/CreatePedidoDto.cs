using System;
using System.Collections.Generic;

namespace SistemaApi.Data.Dtos.Pedido
{
    public class CreatePedidoDto
    {
        public string TipoPedido { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataPedido { get; set; }
        public int ClienteID { get; set; }
    }
}
