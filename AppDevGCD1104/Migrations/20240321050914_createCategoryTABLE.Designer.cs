﻿// <auto-generated />
using AppDevGCD1104.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppDevGCD1104.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240321050914_createCategoryTABLE")]
    partial class createCategoryTABLE
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppDevGCD1104.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "So funny",
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 2,
                            Description = "So romantic",
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 3,
                            Description = "So scary",
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            Description = "So boring",
                            Name = "Science"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
