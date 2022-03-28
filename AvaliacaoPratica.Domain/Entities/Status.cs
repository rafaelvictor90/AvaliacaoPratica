
namespace AvaliacaoPratica.Domain.Entities
{
    public sealed class Status : Entity
    {
        public string Nome { get; private set; }

        public Status(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
