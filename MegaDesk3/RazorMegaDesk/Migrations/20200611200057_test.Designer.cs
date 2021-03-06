﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorMegaDesk.Data;

namespace RazorMegaDesk.Migrations
{
    [DbContext(typeof(DeskQuotesContext))]
    [Migration("20200611200057_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorMegaDesk.Models.DeskQuote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeskDepth")
                        .HasColumnType("int");

                    b.Property<int>("DeskDrawers")
                        .HasColumnType("int");

                    b.Property<int>("DeskMaterial")
                        .HasColumnType("int");

                    b.Property<int>("DeskWidth")
                        .HasColumnType("int");

                    b.Property<DateTime>("QuoteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RushDays")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("DeskQuote");
                });
#pragma warning restore 612, 618
        }
    }
}
