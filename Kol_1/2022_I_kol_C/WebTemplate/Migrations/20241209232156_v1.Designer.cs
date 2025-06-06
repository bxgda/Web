﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTemplate.Models;

#nullable disable

namespace WebTemplate.Migrations
{
    [DbContext(typeof(IspitContext))]
    [Migration("20241209232156_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebTemplate.Models.Bolnica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BrojOdeljenja")
                        .HasColumnType("int");

                    b.Property<int>("BrojOsoblja")
                        .HasColumnType("int");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lokacija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Bolnice");
                });

            modelBuilder.Entity("WebTemplate.Models.Lekar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateOnly>("DatumDiplomiranja")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DatumDobijanjaLicence")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DatumRodjenja")
                        .HasColumnType("date");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Lekari");
                });

            modelBuilder.Entity("WebTemplate.Models.Ugovor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateOnly>("DatumPotpisivanja")
                        .HasColumnType("date");

                    b.Property<int>("IDBroj")
                        .HasColumnType("int");

                    b.Property<int?>("P_BolnicaID")
                        .HasColumnType("int");

                    b.Property<int?>("P_LekarID")
                        .HasColumnType("int");

                    b.Property<string>("Specijalnos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("P_BolnicaID");

                    b.HasIndex("P_LekarID");

                    b.ToTable("Ugovori");
                });

            modelBuilder.Entity("WebTemplate.Models.Ugovor", b =>
                {
                    b.HasOne("WebTemplate.Models.Bolnica", "P_Bolnica")
                        .WithMany()
                        .HasForeignKey("P_BolnicaID");

                    b.HasOne("WebTemplate.Models.Lekar", "P_Lekar")
                        .WithMany()
                        .HasForeignKey("P_LekarID");

                    b.Navigation("P_Bolnica");

                    b.Navigation("P_Lekar");
                });
#pragma warning restore 612, 618
        }
    }
}
