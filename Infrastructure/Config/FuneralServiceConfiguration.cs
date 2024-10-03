using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class FuneralServiceConfiguration : IEntityTypeConfiguration<FuneralService>
{
    public void Configure(EntityTypeBuilder<FuneralService> builder)
    {
        builder.Property(x => x.Location).HasMaxLength(255);
        builder.Property(x => x.Minister).HasMaxLength(255);
        builder.Property(x => x.CreatedBy).HasMaxLength(255);
        builder.Property(x => x.ModifiedBy).HasMaxLength(255);
        builder.HasOne(x => x.Client)
               .WithMany()
               .HasForeignKey(x => x.ClientId)
               .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.ServiceType)
               .WithMany()
               .HasForeignKey(x => x.ServiceTypeId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}
