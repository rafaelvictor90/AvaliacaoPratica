using AvaliacaoPratica.Domain.Validation;

namespace AvaliacaoPratica.Domain.Entities
{
    public sealed class Veiculo : Entity
    {
        public string Renavam { get; private set; }
        public string Modelo { get; private set; }
        public int AnoFabricacao { get; private set; }
        public int AnoModelo { get; private set; }
        public int Quilometragem { get; private set; }
        public float Valor { get; private set; }
        public int StatusId { get; private set; }
        public Status Status { get; set; }

        public int MarcaId { get; private set; }
        public Marca Marca { get; set; }

        public int ProprietarioId { get; private set; }
        public Proprietario Proprietario { get; set; }

        public Veiculo(string renavam, string modelo, int anoFabricacao
            , int anoModelo, int quilometragem, float valor, int statusId, int marcaId, int proprietarioId)
        {
            ValidationDomain(renavam, modelo, anoFabricacao, anoModelo, quilometragem, valor, statusId, marcaId, proprietarioId);
        }

        public Veiculo(int id, string renavam, string modelo, int anoFabricacao
            , int anoModelo, int quilometragem, float valor, int statusId, int marcaId, int proprietarioId)
        {
            DomainExceptionValidation.When(id < 0, "Id inválido.");
            Id = id;
            ValidationDomain(renavam, modelo, anoFabricacao, anoModelo, quilometragem, valor, statusId, marcaId, proprietarioId);
        }

        public void Update(string renavam, string modelo, int anoFabricacao
            , int anoModelo, int quilometragem, float valor, int statusId, int marcaId, int proprietarioId)
        {
            ValidationDomain(renavam, modelo, anoFabricacao, anoModelo, quilometragem, valor, statusId, marcaId, proprietarioId);
        }

        private void ValidationDomain(string renavam, string modelo, int anoFabricacao
            , int anoModelo, int quilometragem, float valor, int statusId, int marcaId, int proprietarioId)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(renavam)
                , "RENAVAM inválido. RENAVAM é obrigatório!");

            DomainExceptionValidation.When(renavam.Length > 11
                , "RENAVAM inválido. RENAVAM limitado a 11 caracteres!");

            DomainExceptionValidation.When(string.IsNullOrEmpty(modelo)
                , "Modelo inválido. Modelo é obrigatório!");

            DomainExceptionValidation.When(anoFabricacao < 0
                , "Ano fabricação inválido. Ano fabricação é obrigatório!");

            DomainExceptionValidation.When(anoModelo < 0
                , "Ano modelo inválido. Ano modelo é obrigatório!");

            DomainExceptionValidation.When(quilometragem < 0
                , "Quilometragem inválida. Quilometragem é obrigatório!");

            DomainExceptionValidation.When(valor < 0
                , "Valor inválida. Valor é obrigatório!");

            Renavam = renavam;
            Modelo = modelo; ;
            AnoFabricacao = anoFabricacao;
            AnoModelo = anoModelo;
            Quilometragem = quilometragem;
            Valor = valor;

            StatusId = statusId;
            MarcaId = marcaId;
            ProprietarioId = proprietarioId;
        }
    }
}
