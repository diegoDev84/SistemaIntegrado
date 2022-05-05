using System.ComponentModel.DataAnnotations;

namespace SistemaApi.Data.Dtos.Categoria
{
    public class CreateCategoriaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

    }
}
