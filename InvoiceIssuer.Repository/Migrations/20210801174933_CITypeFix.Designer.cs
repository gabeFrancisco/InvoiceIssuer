﻿// <auto-generated />
using System;
using InvoiceIssuer.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InvoiceIssuer.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210801174933_CITypeFix")]
    partial class CITypeFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InvoiceIssuer.Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Block")
                        .IsRequired()
                        .HasColumnType("char(30) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(30);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("char(30) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(30);

                    b.Property<string>("Complement")
                        .HasColumnType("char(20) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(20);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("char(10) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("char(10) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("Road")
                        .IsRequired()
                        .HasColumnType("char(70) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(70);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("char(30) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(30);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("InvoiceIssuer.Domain.Entities.CompanyType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("char(30) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(30);

                    b.Property<decimal>("TaxRate")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("CompanyTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bb4b9ab5-0643-47a9-aab6-7309aa09720d"),
                            CreatedAt = new DateTime(2021, 8, 1, 17, 49, 32, 811, DateTimeKind.Utc).AddTicks(1584),
                            Description = "This type of company is free from tax applications",
                            Name = "Individual Business",
                            TaxRate = 0.0m
                        },
                        new
                        {
                            Id = new Guid("0e2a9b0c-3958-4929-af5d-3bbbd3ba69d7"),
                            CreatedAt = new DateTime(2021, 8, 1, 17, 49, 32, 811, DateTimeKind.Utc).AddTicks(3960),
                            Description = "Small company that is beginning",
                            Name = "Small Company",
                            TaxRate = 2.5m
                        },
                        new
                        {
                            Id = new Guid("aa80d9e5-2162-474b-8cb3-1195f6a0f0bb"),
                            CreatedAt = new DateTime(2021, 8, 1, 17, 49, 32, 811, DateTimeKind.Utc).AddTicks(4015),
                            Description = "Mid-port company",
                            Name = "Medium Company",
                            TaxRate = 4.5m
                        },
                        new
                        {
                            Id = new Guid("6a41aeda-3353-45b7-93ed-45b85f9fe167"),
                            CreatedAt = new DateTime(2021, 8, 1, 17, 49, 32, 811, DateTimeKind.Utc).AddTicks(4041),
                            Description = "Large company with more branches",
                            Name = "Large Company",
                            TaxRate = 7.5m
                        });
                });

            modelBuilder.Entity("InvoiceIssuer.Domain.Entities.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("ServiceTypeId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TakerId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("TaxValue")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<decimal>("TotalValue")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ServiceTypeId");

                    b.HasIndex("TakerId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("InvoiceIssuer.Domain.Entities.Provider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("char(36)");

                    b.Property<string>("CI")
                        .IsRequired()
                        .HasColumnType("char(7) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(7);

                    b.Property<string>("ComercialName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("CompanyTypeId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LogoPath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CompanyTypeId");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("InvoiceIssuer.Domain.Entities.ServiceType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("char(200) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("char(50) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("ServiceTypes");
                });

            modelBuilder.Entity("InvoiceIssuer.Domain.Entities.Taker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("char(36)");

                    b.Property<string>("CI")
                        .IsRequired()
                        .HasColumnType("char(7) CHARACTER SET utf8mb4")
                        .IsFixedLength(true)
                        .HasMaxLength(7);

                    b.Property<string>("ComercialName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("CompanyTypeId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CompanyTypeId");

                    b.ToTable("Takers");
                });

            modelBuilder.Entity("InvoiceIssuer.Domain.Entities.Invoice", b =>
                {
                    b.HasOne("InvoiceIssuer.Domain.Entities.ServiceType", "ServiceType")
                        .WithMany()
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvoiceIssuer.Domain.Entities.Taker", "Taker")
                        .WithMany()
                        .HasForeignKey("TakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InvoiceIssuer.Domain.Entities.Provider", b =>
                {
                    b.HasOne("InvoiceIssuer.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvoiceIssuer.Domain.Entities.CompanyType", "CompanyType")
                        .WithMany()
                        .HasForeignKey("CompanyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InvoiceIssuer.Domain.Entities.Taker", b =>
                {
                    b.HasOne("InvoiceIssuer.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvoiceIssuer.Domain.Entities.CompanyType", "CompanyType")
                        .WithMany()
                        .HasForeignKey("CompanyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
