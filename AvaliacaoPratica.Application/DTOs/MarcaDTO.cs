using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AvaliacaoPratica.Application.DTOs
{
    public class MarcaDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(1)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Status")]
        public bool Status { get; set; }
    }
}
