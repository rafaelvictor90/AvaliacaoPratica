using AvaliacaoPratica.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace AvaliacaoPratica.Domain.Test
{
    public class MarcaUnitTest1
    {
        [Fact]
        public void CreateMarca_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Marca(1, "Chevrolet", true);
            action.Should()
                .NotThrow<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateMarca_WithNullNameValue_DomainExceptionInvalidName()
        {
            Action action = () => new Marca(1, null, true);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Nome inválido.");
        }

        [Fact]
        public void CreateMarca_WithMissingNameValue_DomainExceptionInvalidName()
        {
            Action action = () => new Marca(1, "", true);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Nome inválido.");
        }

        [Fact]
        public void CreateMarca_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Marca(-1, null, true);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Id inválido.");
        }
    }
}
