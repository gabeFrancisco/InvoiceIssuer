using InvoiceIssuer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceIssuer.Repository.Config
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Road)
                .IsRequired()
                .HasMaxLength(70)
                .IsFixedLength();
            
            builder.Property(x => x.Number)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();

            builder.Property(x => x.Complement)
                .HasMaxLength(20)
                .IsFixedLength();
            
            builder.Property(x => x.Block)
                .IsRequired()
                .HasMaxLength(30)
                .IsFixedLength();
            
            builder.Property(x => x.City)
                .IsRequired()
                .HasMaxLength(30)
                .IsFixedLength();

            builder.Property(x => x.State)
                .IsRequired()
                .HasMaxLength(30)
                .IsFixedLength();
            
            builder.Property(x => x.PostalCode)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();
        }
    }
}