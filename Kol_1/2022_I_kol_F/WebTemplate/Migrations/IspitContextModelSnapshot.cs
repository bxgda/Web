﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTemplate.Models;

#nullable disable

namespace WebTemplate.Migrations
{
    [DbContext(typeof(IspitContext))]
    partial class IspitContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebTemplate.Models.Kuvar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("StrucnaSprema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kuvari");
                });

            modelBuilder.Entity("WebTemplate.Models.Restoran", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaksBrojGostiju")
                        .HasColumnType("int");

                    b.Property<int>("MaksBrojKuvara")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Restorani");
                });

            modelBuilder.Entity("WebTemplate.Models.Zaposlenje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DatumZaposljenja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KuvarID")
                        .HasColumnType("int");

                    b.Property<long>("Plata")
                        .HasColumnType("bigint");

                    b.Property<string>("Pozicija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestoranID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KuvarID");

                    b.HasIndex("RestoranID");

                    b.ToTable("Zaposlenja");
                });

            modelBuilder.Entity("WebTemplate.Models.Zaposlenje", b =>
                {
                    b.HasOne("WebTemplate.Models.Kuvar", "Kuvar")
                        .WithMany("Zaposlenja")
                        .HasForeignKey("KuvarID");

                    b.HasOne("WebTemplate.Models.Restoran", "Restoran")
                        .WithMany("Zaposlenja")
                        .HasForeignKey("RestoranID");

                    b.Navigation("Kuvar");

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("WebTemplate.Models.Kuvar", b =>
                {
                    b.Navigation("Zaposlenja");
                });

            modelBuilder.Entity("WebTemplate.Models.Restoran", b =>
                {
                    b.Navigation("Zaposlenja");
                });
#pragma warning restore 612, 618
        }
    }
}