using SistemaApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaApi.Data.Dtos.Pedido
{
    public class ReadPedidoDto
    {
        public int Id { get; set; }
        public string TipoPedido { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
