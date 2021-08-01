using InvoiceIssuer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceIssuer.Repository.Config
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.CI)
                .IsRequired()
                .HasMaxLength(7)
                .IsFixedLength();
            
            builder.Property(x => x.ComercialName)
                .IsRequired();
            
            builder.Property(x => x.Phone)
                .IsRequired();
            
            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(500);
            
            builder.HasOne(x => x.CompanyType);
            builder.HasOne(x => x.Address);
        }
    }
}