﻿using System.ComponentModel.DataAnnotations;

namespace SistemaApi.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo de preço é obrigatório")]
        public double Preco { get; set; }
        public string Categoria { get; set; }
        public bool Complementos { get; set; }
        public double Custo { get; set; }
        public double Margem { get; set; }
        public double Lucro { get; set; }

    }
}
