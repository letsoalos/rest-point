using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(255);
        builder.Property(x => x.LastName).HasMaxLength(255);
        builder.Property(x => x.IdentityNumber).HasMaxLength(100);
        builder.Property(x => x.Passport).HasMaxLength(100);
        builder.Property(x => x.PhoneNumber).HasMaxLength(100);
        builder.Property(x => x.Email).HasMaxLength(255);
        builder.Property(x => x.ClientReferenceNumber).HasMaxLength(255);
        builder.HasOne(x => x.Gender)
               .WithMany()
               .HasForeignKey(x => x.GenderId)
               .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.DocumentType)
               .WithMany()
               .HasForeignKey(x => x.DocumentTypeId)
               .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.ClientStatus)
               .WithMany()
               .HasForeignKey(x => x.ClientStatusId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}
