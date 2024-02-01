﻿// <auto-generated />
using System;
using HotelRate2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelRate2.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20231228120005_OtelResimEkle")]
    partial class OtelResimEkle
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelRate2.Models.Cevap", b =>
                {
                    b.Property<int>("CevapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CevapId"));

                    b.Property<string>("Cevabi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullanicilarId")
                        .HasColumnType("int");

                    b.Property<int>("OtelId")
                        .HasColumnType("int");

                    b.Property<int>("SoruId")
                        .HasColumnType("int");

                    b.HasKey("CevapId");

                    b.HasIndex("KullanicilarId");

                    b.HasIndex("OtelId");

                    b.HasIndex("SoruId");

                    b.ToTable("Cevaplar");
                });

            modelBuilder.Entity("HotelRate2.Models.Kullanicilar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DogumTarihi")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("HotelRate2.Models.Otel", b =>
                {
                    b.Property<int>("OtelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OtelId"));

                    b.Property<string>("OtelAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OtelId");

                    b.ToTable("Oteller");
                });

            modelBuilder.Entity("HotelRate2.Models.OtelResim", b =>
                {
                    b.Property<int>("OtelResimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OtelResimId"));

                    b.Property<int>("OtelId")
                        .HasColumnType("int");

                    b.Property<int>("OtelResimOtelId")
                        .HasColumnType("int");

                    b.Property<string>("OtelResimYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OtelResimId");

                    b.HasIndex("OtelId");

                    b.ToTable("Resimler");
                });

            modelBuilder.Entity("HotelRate2.Models.Soru", b =>
                {
                    b.Property<int>("SoruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SoruId"));

                    b.Property<string>("Konu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SoruId");

                    b.ToTable("Sorular");
                });

            modelBuilder.Entity("HotelRate2.Models.Cevap", b =>
                {
                    b.HasOne("HotelRate2.Models.Kullanicilar", "kullanicilar")
                        .WithMany()
                        .HasForeignKey("KullanicilarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelRate2.Models.Otel", "Otel")
                        .WithMany()
                        .HasForeignKey("OtelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelRate2.Models.Soru", "Soru")
                        .WithMany()
                        .HasForeignKey("SoruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Otel");

                    b.Navigation("Soru");

                    b.Navigation("kullanicilar");
                });

            modelBuilder.Entity("HotelRate2.Models.OtelResim", b =>
                {
                    b.HasOne("HotelRate2.Models.Otel", "Otel")
                        .WithMany()
                        .HasForeignKey("OtelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Otel");
                });
#pragma warning restore 612, 618
        }
    }
}