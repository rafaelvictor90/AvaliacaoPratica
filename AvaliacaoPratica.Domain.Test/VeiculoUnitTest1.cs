using AvaliacaoPratica.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace AvaliacaoPratica.Domain.Test
{
    public class VeiculoUnitTest1
    {
        [Fact]
        public void CreateVeiculo_WithValidParameters_ResultObjectValidState()
        { 
            Action action = () => new Veiculo(1, "000123456", "Range Rover Evoque", 2022, 2022, 0, 377950f, 1, 1, 1);
            action.Should()
                .NotThrow<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateVeiculo_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Veiculo(-1, "000123456", "Range Rover Evoque", 2022, 2022, 0, 377950f, 1, 1, 1);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Id inválido.");
        }

        [Fact]
        public void CreateVeiculo_NullRENAVAMValue_DomainExceptionInvalRENAVAM()
        {
            Action action = () => new Veiculo(1, null, "Range Rover Evoque", 2022, 2022, 0, 377950f, 1, 1, 1);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("RENAVAM inválido. RENAVAM é obrigatório!");
        }
        [Fact]

        public void CreateVeiculo_MissingRENAVAMValue_DomainExceptionInvalRENAVAM()
        {
            Action action = () => new Veiculo(1, "", "Range Rover Evoque", 2022, 2022, 0, 377950f, 1, 1, 1);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("RENAVAM inválido. RENAVAM é obrigatório!");
        }

        [Fact]
        public void CreateVeiculo_NullModeloValue_DomainExceptionInvalModelo()
        {
            Action action = () => new Veiculo(1, "000123456", null, 2022, 2022, 0, 377950f, 1, 1, 1);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Modelo inválido. Modelo é obrigatório!");
        }
        [Fact]

        public void CreateVeiculo_MissingModeloValue_DomainExceptionInvalModelo()
        {
            Action action = () => new Veiculo(1, "000123456", "", 2022, 2022, 0, 377950f, 1, 1, 1);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Modelo inválido. Modelo é obrigatório!");
        }

        [Fact]
        public void CreateVeiculo_NegativeAnoFrabricacaoValue_DomainExceptionInvalidAnoFrabricacao()
        {
            Action action = () => new Veiculo(1, "000123456", "Range Rover Evoque", -1, 2022, 0, 377950f, 1, 1, 1);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Ano fabricação inválido. Ano fabricação é obrigatório!");
        }

        [Fact]
        public void CreateVeiculo_NegativeAnoModeloValue_DomainExceptionInvalidAnoModelo()
        {
            Action action = () => new Veiculo(1, "000123456", "Range Rover Evoque", 2022, -1, 0, 377950f, 1, 1, 1);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Ano modelo inválido. Ano modelo é obrigatório!");
        }

        [Fact]
        public void CreateVeiculo_NegativeQuilometragemValue_DomainExceptionInvalidQuilometragem()
        {
            Action action = () => new Veiculo(1, "000123456", "Range Rover Evoque", 2022, 2022, -1, 377950f, 1, 1, 1);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Quilometragem inválida. Quilometragem é obrigatório!");
        }

        [Fact]
        public void CreateVeiculo_InvalidValorValue_DomainExceptionInvalidValor()
        {
            Action action = () => new Veiculo(1, "000123456", "Range Rover Evoque", 2022, 2022, 0, -1, 1, 1, 1);
            action.Should()
                .Throw<AvaliacaoPratica.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Valor inválida. Valor é obrigatório!");
        }
    }
}
