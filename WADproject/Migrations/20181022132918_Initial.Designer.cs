﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WADproject.Models;

namespace WADproject.Migrations
{
    [DbContext(typeof(WADprojectContext))]
    [Migration("20181022132918_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WADproject.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.Property<string>("Picture");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WADproject.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Discontinued");

                    b.Property<string>("ProductName");

                    b.Property<string>("QuantityPerUnit");

                    b.Property<string>("ReorderLevel");

                    b.Property<int>("SupplierId");

                    b.Property<string>("UnitPrice");

                    b.Property<string>("UnitsInStock");

                    b.Property<string>("UnitsOnOrder");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WADproject.Models.Product", b =>
                {
                    b.HasOne("WADproject.Models.Category", "Categories")
                        .WithOne("Product")
                        .HasForeignKey("WADproject.Models.Product", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}