using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaApi.Models
{
    public class Pedido
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipoPedido { get; set; }
        public double ValorTotal { get; set; }
        public string FormaPagamento { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int ClienteID { get; set; }
        public DateTime DataPedido { get; set; }

    }
}
