using System;
using System.Collections.Generic;


namespace SistemaBalcao.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }
        public string? TipoPedido { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataPedido { get; set; }
        public int ClienteID { get; set; }
        public virtual Cliente? Cliente { get; set; }

    }
}
