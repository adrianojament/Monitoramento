﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Monitoramento.Infra.Data.Context;

#nullable disable

namespace Monitoramento.Infra.Data.Migrations
{
    [DbContext(typeof(MonitoramentoContexto))]
    [Migration("20220130194921_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Monitoramento.Domain.Models.Servidor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Criacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("IP_Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IP_Porta")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servidores");
                });
#pragma warning restore 612, 618
        }
    }
}
