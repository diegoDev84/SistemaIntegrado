using System.ComponentModel.DataAnnotations;

namespace SistemaApi.Data.Dtos.Categoria
{
    public class UpdateCategoriaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
    }
}
