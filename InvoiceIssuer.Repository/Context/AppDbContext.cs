using InvoiceIssuer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceIssuer.Repository.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Taker> Takers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
    }
}