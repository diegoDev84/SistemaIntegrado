using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaApi.Data.Dtos.Pedido
{
    public class UpdatePedidoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public double ValorTotal { get; set; }
    }
}
