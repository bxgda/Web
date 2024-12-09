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
    [Migration("20241209162217_v1")]
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

            modelBuilder.Entity("WebTemplate.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AutorAlbumaID")
                        .HasColumnType("int");

                    b.Property<int>("GodinaIzdavanja")
                        .HasColumnType("int");

                    b.Property<string>("IzdavackaKuca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NumeraAlbumaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AutorAlbumaID");

                    b.HasIndex("NumeraAlbumaID");

                    b.ToTable("Albumi");
                });

            modelBuilder.Entity("WebTemplate.Models.Autor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DatumPrvogAlbuma")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Autori");
                });

            modelBuilder.Entity("WebTemplate.Models.Numera", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BrojUmetnika")
                        .HasColumnType("int");

                    b.Property<double?>("Duzina")
                        .HasColumnType("float");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Zanr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Numere");
                });

            modelBuilder.Entity("WebTemplate.Models.Album", b =>
                {
                    b.HasOne("WebTemplate.Models.Autor", "AutorAlbuma")
                        .WithMany("IzdatiAlbumi")
                        .HasForeignKey("AutorAlbumaID");

                    b.HasOne("WebTemplate.Models.Numera", "NumeraAlbuma")
                        .WithMany()
                        .HasForeignKey("NumeraAlbumaID");

                    b.Navigation("AutorAlbuma");

                    b.Navigation("NumeraAlbuma");
                });

            modelBuilder.Entity("WebTemplate.Models.Autor", b =>
                {
                    b.Navigation("IzdatiAlbumi");
                });
#pragma warning restore 612, 618
        }
    }
}