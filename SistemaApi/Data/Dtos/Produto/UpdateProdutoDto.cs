using System.ComponentModel.DataAnnotations;

namespace SistemaApi.Data.Dtos.Produto
{
    public class UpdateProdutoDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }
        public bool Complementos { get; set; }
        public double Custo { get; set; }
        public double Margem { get; set; }
        public double Lucro { get; set; }
    }
}
