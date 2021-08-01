using InvoiceIssuer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceIssuer.Repository.Config
{
    public class ServiceTypeConfiguration : IEntityTypeConfiguration<ServiceType>
    {
        public void Configure(EntityTypeBuilder<ServiceType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsFixedLength();
            
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(200)
                .IsFixedLength();
        }
    }
}