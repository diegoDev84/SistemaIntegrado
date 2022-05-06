using System.ComponentModel.DataAnnotations;

namespace SistemaApi.Data.Dtos.Empresa
{
    public class ReadEmpresaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
