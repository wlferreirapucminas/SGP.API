﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SgpApi.Models;

namespace Gem.Api.Migrations
{
    [DbContext(typeof(SgpDbContext))]
    partial class SgpDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SgpApi.Models.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int>("IdDisciplina");

                    b.Property<int>("IdMateria");

                    b.Property<int>("IdProfessor");

                    b.HasKey("Id");

                    b.ToTable("Avaliacao");
                });

            modelBuilder.Entity("SgpApi.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Disciplina");
                });

            modelBuilder.Entity("SgpApi.Models.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("SgpApi.Models.OpcaoAvaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int>("IdQuestao");

                    b.Property<bool>("Verdadeira");

                    b.HasKey("Id");

                    b.ToTable("OpcaoAvaliacao");
                });

            modelBuilder.Entity("SgpApi.Models.OpcaoProva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdOpcaoAvaliacao");

                    b.Property<int>("IdQuestaoProva");

                    b.Property<bool>("Resposta");

                    b.HasKey("Id");

                    b.ToTable("OpcaoProva");
                });

            modelBuilder.Entity("SgpApi.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Curso");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int>("IdTurma");

                    b.Property<string>("Login");

                    b.Property<string>("Nome");

                    b.Property<string>("Origem");

                    b.Property<string>("Senha");

                    b.Property<string>("Sexo");

                    b.Property<bool>("Status");

                    b.Property<string>("Telefone");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("SgpApi.Models.Prova", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataProva");

                    b.Property<int>("IdAluno");

                    b.Property<int>("IdAvaliacao");

                    b.Property<int>("NotaObtida");

                    b.HasKey("Id");

                    b.ToTable("Prova");
                });

            modelBuilder.Entity("SgpApi.Models.Publicacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<DateTime>("DataPublicacao");

                    b.Property<int>("IdAvaliacao");

                    b.Property<int>("IdTurma");

                    b.Property<int>("ValorProva");

                    b.HasKey("Id");

                    b.ToTable("Publicacao");
                });

            modelBuilder.Entity("SgpApi.Models.Questao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Enunciado");

                    b.Property<int>("IdAvaliacao");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Questao");
                });

            modelBuilder.Entity("SgpApi.Models.QuestaoProva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdProva");

                    b.Property<int>("IdQuestao");

                    b.Property<int>("Nota");

                    b.HasKey("Id");

                    b.ToTable("QuestaoProva");
                });

            modelBuilder.Entity("SgpApi.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Turma");
                });
#pragma warning restore 612, 618
        }
    }
}
