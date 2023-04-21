﻿// <auto-generated />
using System;
using ME_Ejercicio_DosTablas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ME_Ejercicio_DosTablas.Migrations
{
    [DbContext(typeof(ME_DBContext))]
    partial class ME_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ME_Ejercicio_DosTablas.Models.Burger", b =>
                {
                    b.Property<int>("BurgerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BurgerId"), 1L, 1);

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int>("WithCheese")
                        .HasColumnType("int");

                    b.HasKey("BurgerId");

                    b.ToTable("Burger");
                });

            modelBuilder.Entity("ME_Ejercicio_DosTablas.Models.Promo", b =>
                {
                    b.Property<int>("PromoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PromoId"), 1L, 1);

                    b.Property<int>("BurgerId")
                        .HasColumnType("int");

                    b.Property<int>("Descripcion")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPromo")
                        .HasColumnType("datetime2");

                    b.HasKey("PromoId");

                    b.HasIndex("BurgerId");

                    b.ToTable("Promo");
                });

            modelBuilder.Entity("ME_Ejercicio_DosTablas.Models.Promo", b =>
                {
                    b.HasOne("ME_Ejercicio_DosTablas.Models.Burger", "Burger")
                        .WithMany("Promos")
                        .HasForeignKey("BurgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");
                });

            modelBuilder.Entity("ME_Ejercicio_DosTablas.Models.Burger", b =>
                {
                    b.Navigation("Promos");
                });
#pragma warning restore 612, 618
        }
    }
}
