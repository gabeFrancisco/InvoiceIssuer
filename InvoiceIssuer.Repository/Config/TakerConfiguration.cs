using InvoiceIssuer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceIssuer.Repository.Config
{
    public class TakerConfiguration : IEntityTypeConfiguration<Taker>
    {
        public void Configure(EntityTypeBuilder<Taker> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CI)
                .IsRequired()
                .HasMaxLength(7);

            builder.Property(x => x.ComercialName)
                .IsRequired();
          
            builder.HasOne(x => x.CompanyType);
            builder.HasOne(x => x.Address);
        }
    }
}