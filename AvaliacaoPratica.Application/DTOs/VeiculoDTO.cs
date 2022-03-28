using AvaliacaoPratica.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaliacaoPratica.Application.DTOs
{
    public class VeiculoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O RENAVAM é obrigatório")]
        [MinLength(1)]
        [MaxLength(100)]
        [DisplayName("RENAVAM")]
        public string Renavam { get; set; }

        [Required(ErrorMessage = "O Modelo é obrigatório")]
        [MinLength(1)]
        [MaxLength(100)]
        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [Column(TypeName = "number")]
        [DisplayName("Ano fabricação")]
        public int AnoFabricacao { get; set; }

        [Column(TypeName = "number")]
        [DisplayName("Ano modelo")]
        public int AnoModelo { get; set; }

        [Column(TypeName = "number")]
        [DisplayName("Quilometragem")]
        public int Quilometragem { get; set; }

        [Required(ErrorMessage = "O Valor é obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Preço")]
        public float Valor { get; set; }

        [DisplayName("Status")]
        public int StatusId { get; set; }
        public Status Status { get; set; }

        [DisplayName("Marca")]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }

        [DisplayName("Proprietario")]
        public int ProprietarioId { get; set; }
        public Proprietario Proprietario { get; set; }
    }
}
