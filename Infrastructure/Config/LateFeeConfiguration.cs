using Core.Entities._LookUps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class LateFeeConfiguration : IEntityTypeConfiguration<LateFee>
{
    public void Configure(EntityTypeBuilder<LateFee> builder)
    {
        builder.Property(x => x.Amount).HasColumnType("decimal(18,2)");
        builder.HasOne(x => x.ClientPremium)
               .WithMany()
               .HasForeignKey(x => x.ClientPremiumId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}
