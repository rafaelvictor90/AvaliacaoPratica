using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AvaliacaoPratica.Application.DTOs
{
    public class ProprietarioDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(1)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Documento é obrigatório")]
        [MinLength(1)]
        [MaxLength(100)]
        [DisplayName("Documento")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [MinLength(1)]
        [MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório")]
        [MinLength(1)]
        [MaxLength(9)]
        [DataType(DataType.PostalCode)]
        [DisplayName("CEP")]
        public string Cep { get; set; }

        [DisplayName("Status")]
        public bool Status { get; set; }
    }
}
