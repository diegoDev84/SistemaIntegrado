﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaApi.Data;

namespace SistemaApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220517202742_adicionando forma de pgto")]
    partial class adicionandoformadepgto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("SistemaApi.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("SistemaApi.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Logradouro")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.Property<string>("UF")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SistemaApi.Models.Complemento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Custo")
                        .HasColumnType("double");

                    b.Property<double>("Lucro")
                        .HasColumnType("double");

                    b.Property<double>("Margem")
                        .HasColumnType("double");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Complementos");
                });

            modelBuilder.Entity("SistemaApi.Models.DadosEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .HasColumnType("text");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Endereco")
                        .HasColumnType("text");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("text");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.Property<string>("UF")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("SistemaApi.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime");

                    b.Property<string>("FormaPagamento")
                        .HasColumnType("text");

                    b.Property<string>("TipoPedido")
                        .HasColumnType("text");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClienteID");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("SistemaApi.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .HasColumnType("text");

                    b.Property<bool>("Complementos")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Custo")
                        .HasColumnType("double");

                    b.Property<double>("Lucro")
                        .HasColumnType("double");

                    b.Property<double>("Margem")
                        .HasColumnType("double");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("SistemaApi.Models.Pedido", b =>
                {
                    b.HasOne("SistemaApi.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("SistemaApi.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}