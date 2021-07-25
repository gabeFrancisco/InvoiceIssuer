using System;
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
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}