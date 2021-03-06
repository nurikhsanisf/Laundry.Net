﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcLaundry.Data;

namespace MvcLaundry.Migrations
{
    [DbContext(typeof(MvcLaundryContext))]
    partial class MvcLaundryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("MvcLaundry.Models.JenisPakaian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HargaPerKg")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NamaPakaian")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("JenisPakaian");
                });

            modelBuilder.Entity("MvcLaundry.Models.Transaksi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlamatUser")
                        .HasColumnType("TEXT");

                    b.Property<int>("JenisPakaianId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NamaUser")
                        .HasColumnType("TEXT");

                    b.Property<string>("NoHPUser")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TglTransaksi")
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalTransaksi")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("JenisPakaianId");

                    b.HasIndex("UserId");

                    b.ToTable("Transaksi");
                });

            modelBuilder.Entity("MvcLaundry.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MvcLaundry.Models.Transaksi", b =>
                {
                    b.HasOne("MvcLaundry.Models.JenisPakaian", "JenisPakaian")
                        .WithMany()
                        .HasForeignKey("JenisPakaianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcLaundry.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
