﻿// <auto-generated />
using System;
using EFCore.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.Repo.Migrations
{
    [DbContext(typeof(HeroiContext))]
    [Migration("20210405162957_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.Domain.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeroiId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId");

                    b.ToTable("Armas");
                });

            modelBuilder.Entity("EFCore.Domain.Batalha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("DtFim");

                    b.Property<DateTime>("DtIncio");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Batalhas");
                });

            modelBuilder.Entity("EFCore.Domain.Heroi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Heroi");
                });

            modelBuilder.Entity("EFCore.Domain.HeroiBatalha", b =>
                {
                    b.Property<int>("BatalhaId");

                    b.Property<int>("HeroiId");

                    b.HasKey("BatalhaId", "HeroiId");

                    b.HasIndex("HeroiId");

                    b.ToTable("HeroiBatalha");
                });

            modelBuilder.Entity("EFCore.Domain.IdentidadeSecreta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeroiId");

                    b.Property<int>("NomeReal");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId")
                        .IsUnique();

                    b.ToTable("IdentidadesSecretas");
                });

            modelBuilder.Entity("EFCore.Domain.Arma", b =>
                {
                    b.HasOne("EFCore.Domain.Heroi", "Heroi")
                        .WithMany("Armas")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCore.Domain.HeroiBatalha", b =>
                {
                    b.HasOne("EFCore.Domain.Batalha", "Batalha")
                        .WithMany("HeroisBatalhas")
                        .HasForeignKey("BatalhaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFCore.Domain.Heroi", "Heroi")
                        .WithMany("HeroisBatalhas")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCore.Domain.IdentidadeSecreta", b =>
                {
                    b.HasOne("EFCore.Domain.Heroi", "Heroi")
                        .WithOne("Identidade")
                        .HasForeignKey("EFCore.Domain.IdentidadeSecreta", "HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
