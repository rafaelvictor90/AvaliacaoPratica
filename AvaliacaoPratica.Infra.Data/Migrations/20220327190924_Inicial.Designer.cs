﻿// <auto-generated />
using AvaliacaoPratica.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AvaliacaoPratica.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220327190924_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AvaliacaoPratica.Domain.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("AvaliacaoPratica.Domain.Entities.Proprietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Documento")
                        .IsUnique();

                    b.ToTable("Proprietarios");
                });

            modelBuilder.Entity("AvaliacaoPratica.Domain.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Disponível"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Indisponível"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Vendido"
                        });
                });

            modelBuilder.Entity("AvaliacaoPratica.Domain.Entities.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("int");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProprietarioId")
                        .HasColumnType("int");

                    b.Property<int>("Quilometragem")
                        .HasColumnType("int");

                    b.Property<string>("Renavam")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ProprietarioId");

                    b.HasIndex("Renavam")
                        .IsUnique();

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("AvaliacaoPratica.Domain.Entities.Veiculo", b =>
                {
                    b.HasOne("AvaliacaoPratica.Domain.Entities.Marca", "Marca")
                        .WithMany("Veiculos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AvaliacaoPratica.Domain.Entities.Proprietario", "Proprietario")
                        .WithMany("Veiculos")
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");

                    b.Navigation("Proprietario");
                });

            modelBuilder.Entity("AvaliacaoPratica.Domain.Entities.Marca", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("AvaliacaoPratica.Domain.Entities.Proprietario", b =>
                {
                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
