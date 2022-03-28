using AvaliacaoPratica.Domain.Validation;
using System.Collections.Generic;

namespace AvaliacaoPratica.Domain.Entities
{
    public sealed class Proprietario: Entity
    {
        public string Nome { get; private set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public bool Status { get; private set; }

        public ICollection<Veiculo> Veiculos { get; private set; }

        public Proprietario(string nome, string documento, string email, string cep, bool status)
        {
            ValidationDomain(nome, documento, email, cep);
            Status = status;
        }

        public Proprietario(int id, string nome, string documento, string email, string cep, bool status)
        {
            DomainExceptionValidation.When(id < 0, "Id inválido.");
            Id = id;
            ValidationDomain(nome, documento, email, cep);
            Status = status;
        }

        public void Update(string nome, string documento, string email, string cep, bool status)
        {
            ValidationDomain(nome, documento, email, cep);
            Status = status;
        }

        private void ValidationDomain(string nome, string documento, string email, string cep)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome)
                , "Nome inválido. Nome é obrigatório!");
            DomainExceptionValidation.When(string.IsNullOrEmpty(documento)
                , "Documento inválido. Documento é obrigatório!");
            DomainExceptionValidation.When(string.IsNullOrEmpty(email)
                , "Email inválido. Email é obrigatório!");
            DomainExceptionValidation.When(string.IsNullOrEmpty(cep)
                , "Cep inválido. Cep é obrigatório!");

            Nome = nome;
            Documento = documento;
            Email = email;
            Cep = cep;
        }
    }
}
