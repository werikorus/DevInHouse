﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_codefirst.Context;

namespace api_codefirst.Migrations
{
    [DbContext(typeof(Sqlcontext))]
    [Migration("20220420001644_ManutencaoTabelas")]
    partial class ManutencaoTabelas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImovelProprietario", b =>
                {
                    b.Property<int>("ImoveisId")
                        .HasColumnType("int");

                    b.Property<int>("ProprietariosId")
                        .HasColumnType("int");

                    b.HasKey("ImoveisId", "ProprietariosId");

                    b.HasIndex("ProprietariosId");

                    b.ToTable("ImovelProprietario");
                });

            modelBuilder.Entity("api_codefirst.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProprietarioId")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("api_codefirst.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("bairro");

                    b.Property<int>("Cep")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("complemento");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("numero");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("referencia");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("rua");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("uf");

                    b.HasKey("Id");

                    b.ToTable("enderecos_sistema");
                });

            modelBuilder.Entity("api_codefirst.Models.Imovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Area")
                        .HasColumnType("real");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescricaoCurta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoLonga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<float>("Preco")
                        .HasColumnType("real");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ValorCondominio")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Imoveis");
                });

            modelBuilder.Entity("api_codefirst.Models.Proprietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proprietario");
                });

            modelBuilder.Entity("ImovelProprietario", b =>
                {
                    b.HasOne("api_codefirst.Models.Imovel", null)
                        .WithMany()
                        .HasForeignKey("ImoveisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_codefirst.Models.Proprietario", null)
                        .WithMany()
                        .HasForeignKey("ProprietariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api_codefirst.Models.Contato", b =>
                {
                    b.HasOne("api_codefirst.Models.Proprietario", null)
                        .WithMany("Contatos")
                        .HasForeignKey("ProprietarioId");
                });

            modelBuilder.Entity("api_codefirst.Models.Imovel", b =>
                {
                    b.HasOne("api_codefirst.Models.Endereco", "Endereco")
                        .WithMany("Imoveis")
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("api_codefirst.Models.Endereco", b =>
                {
                    b.Navigation("Imoveis");
                });

            modelBuilder.Entity("api_codefirst.Models.Proprietario", b =>
                {
                    b.Navigation("Contatos");
                });
#pragma warning restore 612, 618
        }
    }
}