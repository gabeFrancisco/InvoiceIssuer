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
    [Migration("20211114213748_Seed")]
    partial class Seed
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
                            Id = new Guid("b92c0161-994e-4566-b5de-36733e26c9e7"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 915, DateTimeKind.Utc).AddTicks(4365),
                            Description = "This type of company is free from tax applications",
                            Name = "Individual Business",
                            TaxRate = 0.0m
                        },
                        new
                        {
                            Id = new Guid("09688420-9927-4ae0-994c-4ed99596d39a"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 915, DateTimeKind.Utc).AddTicks(6707),
                            Description = "Small company that is beginning",
                            Name = "Small Company",
                            TaxRate = 2.5m
                        },
                        new
                        {
                            Id = new Guid("e0c56739-de2e-4c85-853f-df290f90ed58"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 915, DateTimeKind.Utc).AddTicks(6751),
                            Description = "Mid-port company",
                            Name = "Medium Company",
                            TaxRate = 4.5m
                        },
                        new
                        {
                            Id = new Guid("7466597e-68fb-4587-99e3-245a2a3e061e"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 915, DateTimeKind.Utc).AddTicks(6763),
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

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<Guid>("ProviderId")
                        .HasColumnType("char(36)");

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

                    b.HasIndex("ProviderId");

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

                    b.HasData(
                        new
                        {
                            Id = new Guid("0cc9cd1c-1928-4c2d-a0ef-cc032768a412"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(8792),
                            Description = "Activities and plannings that includes software development, management and project architecture",
                            Name = "Software Development"
                        },
                        new
                        {
                            Id = new Guid("83d29a79-ccf7-4959-999a-abc82b72d726"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9490),
                            Description = "Lead training sessions, workshops or presentations to help team members improve or learn a certain skill",
                            Name = "Training"
                        },
                        new
                        {
                            Id = new Guid("81c48a6a-37ea-4bc4-8ad9-42102670e11c"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9524),
                            Description = "Event planning service for office parties, fundraising events and other corporate functions",
                            Name = "Event planning"
                        },
                        new
                        {
                            Id = new Guid("8f608867-782d-46fb-a011-c6b7476fa81d"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9536),
                            Description = "Consulting services for a variety of projects, including financial budgeting, landscaping, audits and more",
                            Name = "Consulting"
                        },
                        new
                        {
                            Id = new Guid("c06ed54e-bb29-4a09-9d29-40d5d54db779"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9546),
                            Description = "Marketing services for companies advertise their products, services and brand by creating marketing campaigns",
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = new Guid("52079df6-841b-48cf-bbd7-69cf1f12c506"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9557),
                            Description = "Collect garbage and take it away to landfills and recycling facilities",
                            Name = "Waste management"
                        },
                        new
                        {
                            Id = new Guid("c4fa0388-1d87-4f60-b2c1-335729720d71"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9568),
                            Description = "Service that project and execute construnctions for private and public areas",
                            Name = "Construction"
                        },
                        new
                        {
                            Id = new Guid("fb2cc9b8-dd3a-4f86-a8b8-3ee882760332"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9579),
                            Description = "Draft business agreements, ask for advice or navigate a legal issue",
                            Name = "Law"
                        },
                        new
                        {
                            Id = new Guid("ef32aeab-08d6-44b4-a10f-b257a0b612fe"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9589),
                            Description = "Medical assistance and health procedures",
                            Name = "Health"
                        },
                        new
                        {
                            Id = new Guid("06dcd283-9c0e-44f9-aa8e-3d8109f2b0f7"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9600),
                            Description = "Security services to ensure the safety of its employees and guests",
                            Name = "Security"
                        },
                        new
                        {
                            Id = new Guid("1334a3c9-e3a3-4683-85bd-d32a51ad159f"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9610),
                            Description = "Financial procedures for companies or peoples",
                            Name = "Finance"
                        },
                        new
                        {
                            Id = new Guid("1335d9f8-cc3d-42c2-a82c-f40fbf98588a"),
                            CreatedAt = new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9621),
                            Description = "Service for child care assistance",
                            Name = "Child care"
                        });
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
                    b.HasOne("InvoiceIssuer.Domain.Entities.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
