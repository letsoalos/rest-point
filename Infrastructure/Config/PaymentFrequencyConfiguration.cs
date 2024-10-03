using Core.Entities._LookUps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class PaymentFrequencyConfiguration : IEntityTypeConfiguration<PaymentFrequency>
{
    public void Configure(EntityTypeBuilder<PaymentFrequency> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(255);
    }
}
