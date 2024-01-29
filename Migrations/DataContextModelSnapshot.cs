﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api1;

#nullable disable

namespace api1.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api1.MCliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("api1.MConsumo", b =>
                {
                    b.Property<int>("ConsumoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsumoID"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataModificacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReservaID")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("ConsumoID");

                    b.HasIndex("ReservaID");

                    b.ToTable("Consumos");
                });

            modelBuilder.Entity("api1.MConsumoRestaurante", b =>
                {
                    b.Property<int>("ConsumoRestauranteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsumoRestauranteID"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataModificacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EntregueNoQuarto")
                        .HasColumnType("bit");

                    b.Property<int>("ReservaID")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("ConsumoRestauranteID");

                    b.HasIndex("ReservaID");

                    b.ToTable("ConsumosRestaurante");
                });

            modelBuilder.Entity("api1.MFilial", b =>
                {
                    b.Property<int>("FilialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilialID"));

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroQuartosCasal")
                        .HasColumnType("int");

                    b.Property<int>("NumeroQuartosFamilia")
                        .HasColumnType("int");

                    b.Property<int>("NumeroQuartosPresidencial")
                        .HasColumnType("int");

                    b.Property<int>("NumeroQuartosSolteiro")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeEstrelas")
                        .HasColumnType("int");

                    b.HasKey("FilialID");

                    b.ToTable("Filiais");
                });

            modelBuilder.Entity("api1.MFuncionario", b =>
                {
                    b.Property<int>("FuncionarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FuncionarioID"));

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuncionarioID");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("api1.MPagamento", b =>
                {
                    b.Property<int>("PagamentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PagamentoID"));

                    b.Property<DateTime>("DataModificacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("MetodoPagamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReservaID")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("PagamentoID");

                    b.HasIndex("ReservaID");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("api1.MQuarto", b =>
                {
                    b.Property<int>("QuartoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuartoID"));

                    b.Property<bool>("Adaptado")
                        .HasColumnType("bit");

                    b.Property<int>("CapacidadeMaxima")
                        .HasColumnType("int");

                    b.Property<float>("CapacidadeOpcional")
                        .HasColumnType("real");

                    b.Property<int>("FilialID")
                        .HasColumnType("int");

                    b.Property<int>("NumeroQuarto")
                        .HasColumnType("int");

                    b.Property<string>("TipoQuarto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuartoID");

                    b.HasIndex("FilialID");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("api1.MReserva", b =>
                {
                    b.Property<int>("ReservaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservaID"));

                    b.Property<bool>("Cancelada")
                        .HasColumnType("bit");

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataModificacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuartoID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservaID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("QuartoID");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("api1.MServicoLavanderia", b =>
                {
                    b.Property<int>("ServicoLavanderiaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicoLavanderiaID"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("ServicoLavanderiaID");

                    b.ToTable("ServicosLavanderia");
                });

            modelBuilder.Entity("api1.MTipoHotel", b =>
                {
                    b.Property<int>("TipoHotelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoHotelID"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoHotelID");

                    b.ToTable("TiposHotel");
                });

            modelBuilder.Entity("api1.MConsumo", b =>
                {
                    b.HasOne("api1.MReserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("api1.MConsumoRestaurante", b =>
                {
                    b.HasOne("api1.MReserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("api1.MPagamento", b =>
                {
                    b.HasOne("api1.MReserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("api1.MQuarto", b =>
                {
                    b.HasOne("api1.MFilial", "Filial")
                        .WithMany()
                        .HasForeignKey("FilialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("api1.MReserva", b =>
                {
                    b.HasOne("api1.MCliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api1.MQuarto", "Quarto")
                        .WithMany()
                        .HasForeignKey("QuartoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Quarto");
                });
#pragma warning restore 612, 618
        }
    }
}