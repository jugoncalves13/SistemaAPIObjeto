﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaAPIObjeto.Models;

#nullable disable

namespace SistemaAPIObjeto.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaAPIObjeto.Models.Objeto", b =>
                {
                    b.Property<int>("ObjetoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ObjetoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObjetoId"));

                    b.Property<string>("ObjetoCor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoCor");

                    b.Property<DateTime>("ObjetoDtDesaparecimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObjetoDtDesaparecimento");

                    b.Property<DateTime>("ObjetoDtEncontro")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObjetoDtEncontro");

                    b.Property<string>("ObjetoFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoFoto");

                    b.Property<string>("ObjetoLocalDesaparecimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoLocalDesaparecimento");

                    b.Property<string>("ObjetoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoNome");

                    b.Property<string>("ObjetoObservacoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoObservacoes");

                    b.Property<byte>("ObjetoStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("ObjetoStatus");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ObjetoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Objeto");
                });

            modelBuilder.Entity("SistemaAPIObjeto.Models.Observacoes", b =>
                {
                    b.Property<int>("ObservacoesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ObservacoesId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObservacoesId"));

                    b.Property<int>("ObjetoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ObservacoesData")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObservacoesData");

                    b.Property<string>("ObservacoesDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacoesDescricao");

                    b.Property<string>("ObservacoesLocal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacoesLocal");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ObservacoesId");

                    b.HasIndex("ObjetoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Observacoes");
                });

            modelBuilder.Entity("SistemaAPIObjeto.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("UsuarioSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSenha");

                    b.Property<string>("UsuarioTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioTelefone");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SistemaAPIObjeto.Models.Objeto", b =>
                {
                    b.HasOne("SistemaAPIObjeto.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SistemaAPIObjeto.Models.Observacoes", b =>
                {
                    b.HasOne("SistemaAPIObjeto.Models.Objeto", "Objeto")
                        .WithMany()
                        .HasForeignKey("ObjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaAPIObjeto.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objeto");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
