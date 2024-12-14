﻿// <auto-generated />
using System;
using MIS331_07.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MIS331_07.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241116215350_MIS331Week07")]
    partial class MIS331Week07
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MIS331_07.Models.PriceList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Discount")
                        .HasColumnType("double precision");

                    b.Property<double>("ExtendedPrice")
                        .HasColumnType("double precision");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("OriginalPrice")
                        .HasColumnType("double precision");

                    b.Property<string>("UOM")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PriceLists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 450.0,
                            Brand = "Your Fresh Market",
                            Date = new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Utc),
                            Discount = 0.0,
                            ExtendedPrice = 7.4800000000000004,
                            Item = "Lean Ground Beef",
                            OriginalPrice = 7.4800000000000004,
                            UOM = "grams"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}