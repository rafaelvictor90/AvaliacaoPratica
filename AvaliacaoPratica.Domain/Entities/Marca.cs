using AvaliacaoPratica.Domain.Validation;
using System.Collections.Generic;

namespace AvaliacaoPratica.Domain.Entities
{
    public sealed class Marca: Entity
    {
        public string Nome { get; private set; }
        public bool Status { get; private set; }

        public ICollection<Veiculo> Veiculos { get; set; }

        public Marca(string nome, bool status)
        {
            ValidateDomain(nome);
            Status = status;
        }

        public Marca(int id, string nome, bool status)
        {
            DomainExceptionValidation.When(id < 0, "Id inválido.");
            Id = id;
            ValidateDomain(nome);
            Status = status;
        }

        public void Update(string nome, bool status)
        {
            ValidateDomain(nome);
            Status = status;
        }

        private void ValidateDomain(string nome)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(nome), "Nome inválido.");

            Nome = nome;
        }
    }
}
