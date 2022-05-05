using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaApi.Data.Dtos.Pedido
{
    public class UpdatePedidoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string TipoPedido { get; set; }
        public double ValorTotal { get; set; }
    }
}
