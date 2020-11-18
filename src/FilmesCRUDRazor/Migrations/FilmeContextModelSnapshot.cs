﻿// <auto-generated />
using System;
using FilmesCRUDRazor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmesCRUDRazor.Migrations
{
    [DbContext(typeof(FilmeContext))]
    partial class FilmeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("FilmesCRUDRazor.Models.Filme", b =>
                {
                    b.Property<int>("FilmeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Preco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("FilmeId");

                    b.ToTable("Filme");
                });
#pragma warning restore 612, 618
        }
    }
}
