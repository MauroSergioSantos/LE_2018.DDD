﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SGLE.ApplicationCore._2._1___Entities;
using SGLE.InfraStructure._3._1___Data;
using System;

namespace SGLE.InfraStructure.Migrations
{
    [DbContext(typeof(LigaContext))]
    [Migration("20180406010107_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SGLE.ApplicationCore._2._1___Entities.Arbitro", b =>
                {
                    b.Property<int>("ArbitroId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Altura");

                    b.Property<string>("CPF");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nacionalidade");

                    b.Property<string>("Naturalidade");

                    b.Property<string>("NomeArbitro");

                    b.Property<decimal>("Peso");

                    b.Property<string>("RG");

                    b.Property<int>("Tipo");

                    b.HasKey("ArbitroId");

                    b.ToTable("Arbitro");
                });

            modelBuilder.Entity("SGLE.ApplicationCore._2._1___Entities.Assistente", b =>
                {
                    b.Property<int>("AssistenteId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Altura");

                    b.Property<string>("CPF");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nacionalidade");

                    b.Property<string>("Naturalidade");

                    b.Property<string>("NomeAssistente");

                    b.Property<decimal>("Peso");

                    b.Property<string>("RG");

                    b.Property<int>("Tipo");

                    b.HasKey("AssistenteId");

                    b.ToTable("Assistente");
                });

            modelBuilder.Entity("SGLE.ApplicationCore._2._1___Entities.Atleta", b =>
                {
                    b.Property<int>("AtletaId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Altura");

                    b.Property<string>("CPF");

                    b.Property<int>("Categoria");

                    b.Property<DateTime>("DatadeNascimento");

                    b.Property<string>("Endereco");

                    b.Property<int?>("EquipeId");

                    b.Property<string>("Nacionalidade");

                    b.Property<string>("Naturalidade");

                    b.Property<string>("NomedoAtleta");

                    b.Property<decimal>("Peso");

                    b.Property<int>("Posicao");

                    b.Property<string>("RG");

                    b.HasKey("AtletaId");

                    b.HasIndex("EquipeId");

                    b.ToTable("Atleta");
                });

            modelBuilder.Entity("SGLE.ApplicationCore._2._1___Entities.Campeonato", b =>
                {
                    b.Property<int>("CampeonatoId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("NomedoCampeonato");

                    b.HasKey("CampeonatoId");

                    b.ToTable("Campeonato");
                });

            modelBuilder.Entity("SGLE.ApplicationCore._2._1___Entities.Equipe", b =>
                {
                    b.Property<int>("EquipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CampeonatoId");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Endereco");

                    b.Property<string>("NomeEquipe");

                    b.HasKey("EquipeId");

                    b.HasIndex("CampeonatoId");

                    b.ToTable("Equipe");
                });

            modelBuilder.Entity("SGLE.ApplicationCore._2._1___Entities.Atleta", b =>
                {
                    b.HasOne("SGLE.ApplicationCore._2._1___Entities.Equipe")
                        .WithMany("Atletas")
                        .HasForeignKey("EquipeId");
                });

            modelBuilder.Entity("SGLE.ApplicationCore._2._1___Entities.Equipe", b =>
                {
                    b.HasOne("SGLE.ApplicationCore._2._1___Entities.Campeonato", "Campeonato")
                        .WithMany("Equipes")
                        .HasForeignKey("CampeonatoId");
                });
#pragma warning restore 612, 618
        }
    }
}
