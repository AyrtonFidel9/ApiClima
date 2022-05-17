﻿// <auto-generated />
using System;
using ApiClima.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiClima.Migrations
{
    [DbContext(typeof(ClimaContext))]
    [Migration("20220517150027_ApiMigrationsV1")]
    partial class ApiMigrationsV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiClima.Model.Clima", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Ciudad")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ciudad");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("descripcion");

                    b.Property<double?>("Humedad")
                        .HasColumnType("float")
                        .HasColumnName("humedad");

                    b.Property<string>("Pais")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("pais");

                    b.Property<double?>("ProbPrecipitaciones")
                        .HasColumnType("float")
                        .HasColumnName("probPrecipitaciones");

                    b.Property<int?>("Sensacion")
                        .HasColumnType("int")
                        .HasColumnName("sensacion");

                    b.Property<double?>("Viento")
                        .HasColumnType("float")
                        .HasColumnName("viento");

                    b.HasKey("Id");

                    b.ToTable("Climas");
                });
#pragma warning restore 612, 618
        }
    }
}
