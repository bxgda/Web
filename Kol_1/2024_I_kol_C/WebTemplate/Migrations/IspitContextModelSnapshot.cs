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

            modelBuilder.Entity("WebTemplate.Models.Akvarijum", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BrojJedinki")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumDodavanja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("P_RezervoarID")
                        .HasColumnType("int");

                    b.Property<int?>("P_RibaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("P_RezervoarID");

                    b.HasIndex("P_RibaID");

                    b.ToTable("Akvarijumi");
                });

            modelBuilder.Entity("WebTemplate.Models.Rezervoar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BrojTrenutnihRiba")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumPoslednjegCiscenja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FrekvencijaCiscenja")
                        .HasColumnType("int");

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int");

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<double>("Temperatura")
                        .HasColumnType("float");

                    b.Property<double>("Zapremina")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Rezervoari");
                });

            modelBuilder.Entity("WebTemplate.Models.Riba", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("GodineStarosti")
                        .HasColumnType("int");

                    b.Property<double?>("Masa")
                        .HasColumnType("float");

                    b.Property<string>("NazivVrste")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Ribe");
                });

            modelBuilder.Entity("WebTemplate.Models.Akvarijum", b =>
                {
                    b.HasOne("WebTemplate.Models.Rezervoar", "P_Rezervoar")
                        .WithMany()
                        .HasForeignKey("P_RezervoarID");

                    b.HasOne("WebTemplate.Models.Riba", "P_Riba")
                        .WithMany()
                        .HasForeignKey("P_RibaID");

                    b.Navigation("P_Rezervoar");

                    b.Navigation("P_Riba");
                });
#pragma warning restore 612, 618
        }
    }
}
