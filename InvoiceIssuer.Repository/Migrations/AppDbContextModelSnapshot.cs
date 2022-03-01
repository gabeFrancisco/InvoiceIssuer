﻿// <auto-generated />
using System;
using InvoiceIssuer.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InvoiceIssuer.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("58837249-b572-4c69-a7a3-454c99f5bdd5"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 980, DateTimeKind.Utc).AddTicks(8689),
                            Description = "This type of company is free from tax applications",
                            Name = "Individual Business",
                            TaxRate = 0.0m
                        },
                        new
                        {
                            Id = new Guid("60a13227-9992-4f95-b387-855fdb34cef4"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 981, DateTimeKind.Utc).AddTicks(782),
                            Description = "Small company that is beginning",
                            Name = "Small Company",
                            TaxRate = 2.5m
                        },
                        new
                        {
                            Id = new Guid("dffc8e53-207d-4076-8bf4-096d8df87649"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 981, DateTimeKind.Utc).AddTicks(870),
                            Description = "Mid-port company",
                            Name = "Medium Company",
                            TaxRate = 4.5m
                        },
                        new
                        {
                            Id = new Guid("d6675f73-2593-4d61-bf76-2926faef7373"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 981, DateTimeKind.Utc).AddTicks(923),
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

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("bool");

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
                            Id = new Guid("bde37595-5f20-43cb-aa91-a2eb37233ccc"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(3456),
                            Description = "Activities and plannings that includes software development, management and project architecture",
                            Name = "Software Development"
                        },
                        new
                        {
                            Id = new Guid("8d711f35-dfa1-4333-a3cf-31e33ada93d3"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4439),
                            Description = "Lead training sessions, workshops or presentations to help team members improve or learn a certain skill",
                            Name = "Training"
                        },
                        new
                        {
                            Id = new Guid("76e33afb-fd17-4f7b-8c29-b00fe28f4a65"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4516),
                            Description = "Event planning service for office parties, fundraising events and other corporate functions",
                            Name = "Event planning"
                        },
                        new
                        {
                            Id = new Guid("2c13bd1b-4edf-43b6-802b-2d93154092c3"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4567),
                            Description = "Consulting services for a variety of projects, including financial budgeting, landscaping, audits and more",
                            Name = "Consulting"
                        },
                        new
                        {
                            Id = new Guid("db0f68de-c8e5-4b64-abba-bd1b8eceb237"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4617),
                            Description = "Marketing services for companies advertise their products, services and brand by creating marketing campaigns",
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = new Guid("8a4952e6-0993-4a8d-a4c4-6922a73d8902"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4666),
                            Description = "Collect garbage and take it away to landfills and recycling facilities",
                            Name = "Waste management"
                        },
                        new
                        {
                            Id = new Guid("c70af450-9852-4cd7-8285-9c7e166dcc64"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4716),
                            Description = "Service that project and execute construnctions for private and public areas",
                            Name = "Construction"
                        },
                        new
                        {
                            Id = new Guid("2b90f47b-f3a2-4477-a359-8036523a2b48"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4766),
                            Description = "Draft business agreements, ask for advice or navigate a legal issue",
                            Name = "Law"
                        },
                        new
                        {
                            Id = new Guid("f4903fab-30b4-4979-8b9f-8b67adeb7756"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4817),
                            Description = "Medical assistance and health procedures",
                            Name = "Health"
                        },
                        new
                        {
                            Id = new Guid("e6895aa7-9563-4223-9f4f-a9c6914d9f95"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4867),
                            Description = "Security services to ensure the safety of its employees and guests",
                            Name = "Security"
                        },
                        new
                        {
                            Id = new Guid("277ddf89-a921-4e1d-a204-caa7d2415108"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4917),
                            Description = "Financial procedures for companies or peoples",
                            Name = "Finance"
                        },
                        new
                        {
                            Id = new Guid("4c7ffb03-5bc5-43b9-a782-831be7ccc862"),
                            CreatedAt = new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4966),
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
