using AvaliacaoPratica.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace AvaliacaoPratica.Domain.Test
{
    public class ProprietarioUnitTest1
    {
        [Fact]
        public void CreateProprietario_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Proprietario(1, "Rafael", "12312312-12", "teste1@teste.com", "01310-200", true);
            action.Should()
                .NotThrow<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProprietario_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Proprietario(-1, "Rafael", "32132132-21", "teste1@teste.com", "08010-300", true);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Id inválido.");
        }

        [Fact]
        public void CreateProprietario_NullProprietarioValue_DomainExceptionInvalProprietario()
        {
            Action action = () => new Proprietario(1, null, "32132132-21", "teste1@teste.com", "08010-300", true);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Nome inválido. Nome é obrigatório!");
        }

        [Fact]
        public void CreateVeiculo_NullProprietarioValue_DomainExceptionInvalProprietario()
        {
            Action action = () => new Proprietario(1, "", "12312312-12", "teste1@teste.com", "01310-200", true);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Nome inválido. Nome é obrigatório!");
        }
    }
}
