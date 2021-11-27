using System;
using System.Linq;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Repository.Config;
using Microsoft.EntityFrameworkCore;

namespace InvoiceIssuer.Repository.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Taker> Takers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyTypeConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            modelBuilder.ApplyConfiguration(new ProviderConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TakerConfiguration());

            //Seeding data

            modelBuilder.Entity<CompanyType>().HasData(
                new CompanyType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Individual Business",
                    Description = "This type of company is free from tax applications",
                    TaxRate = 0.0M
                },
                new CompanyType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Small Company",
                    Description = "Small company that is beginning",
                    TaxRate = 2.5M
                },
                new CompanyType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Medium Company",
                    Description = "Mid-port company",
                    TaxRate = 4.5M
                },
                new CompanyType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Large Company",
                    Description = "Large company with more branches",
                    TaxRate = 7.5M
                }
            );

            modelBuilder.Entity<ServiceType>().HasData(
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Software Development",
                    Description = "Activities and plannings that includes software development, management and project architecture"
                },
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Training",
                    Description = "Lead training sessions, workshops or presentations to help team members improve or learn a certain skill"
                },
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Event planning",
                    Description = "Event planning service for office parties, fundraising events and other corporate functions"
                },
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Consulting",
                    Description = "Consulting services for a variety of projects, including financial budgeting, landscaping, audits and more"
                },
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Marketing",
                    Description = "Marketing services for companies advertise their products, services and brand by creating marketing campaigns"
                },
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Waste management",
                    Description = "Collect garbage and take it away to landfills and recycling facilities"
                },
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Construction",
                    Description = "Service that project and execute construnctions for private and public areas"
                },
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Law",
                    Description = "Draft business agreements, ask for advice or navigate a legal issue"
                },
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Health",
                    Description = "Medical assistance and health procedures"
                },
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Security",
                    Description = "Security services to ensure the safety of its employees and guests"
                },
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Finance",
                    Description = "Financial procedures for companies or peoples"
                },
                new ServiceType()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = "Child care",
                    Description = "Service for child care assistance"
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}