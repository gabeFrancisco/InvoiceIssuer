using InvoiceIssuer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceIssuer.Repository.Config
{
    public class CompanyTypeConfiguration : IEntityTypeConfiguration<CompanyType>
    {
        public void Configure(EntityTypeBuilder<CompanyType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30)
                .IsFixedLength();
            
            builder.Property(x => x.Description)
                .IsRequired();
            
            builder.Property(x => x.TaxRate)
                .IsRequired();
        }
    }
}