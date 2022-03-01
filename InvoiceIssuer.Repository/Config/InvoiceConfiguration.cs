using InvoiceIssuer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceIssuer.Repository.Config
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(x => x.Id); //GUID

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(x => x.Description)
                .IsRequired();
            
            builder.Property(x => x.Date)
                .IsRequired();
            
            builder.Property(x => x.TotalValue)
                .IsRequired();

            builder.Property(x => x.TaxValue)
                .IsRequired();

            builder.Property(x => x.Number)
                .IsRequired();
            
            builder.Property(x => x.IsCanceled)
                .HasColumnType("bool")
                .IsRequired();
            
            builder.HasOne(x => x.Taker);
            builder.HasOne(x => x.Provider);
            builder.HasOne(x => x.ServiceType);
        }
    }
}