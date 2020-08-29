﻿// <auto-generated />
using System;
using AlbumFotos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumFotos.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200826235856_criacaoBD")]
    partial class criacaoBD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumFotos.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasMaxLength(52);

                    b.Property<DateTime>("Fim");

                    b.Property<string>("FotoTopo")
                        .IsRequired();

                    b.Property<DateTime>("Inicio");

                    b.HasKey("AlbumId");

                    b.ToTable("Albuns");
                });

            modelBuilder.Entity("AlbumFotos.Models.Imagem", b =>
                {
                    b.Property<int>("ImagemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("Link")
                        .IsRequired();

                    b.HasKey("ImagemId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Imagens");
                });

            modelBuilder.Entity("AlbumFotos.Models.Imagem", b =>
                {
                    b.HasOne("AlbumFotos.Models.Album", "Album")
                        .WithMany("Imagens")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
