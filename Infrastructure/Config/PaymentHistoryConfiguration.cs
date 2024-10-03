using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class PaymentHistoryConfiguration : IEntityTypeConfiguration<PaymentHistory>
{
    public void Configure(EntityTypeBuilder<PaymentHistory> builder)
    {
        builder.Property(x => x.ReferenceNumber).HasMaxLength(255);
        builder.Property(x => x.Description).HasMaxLength(255);
        builder.Property(x => x.CreatedBy).HasMaxLength(255);
        builder.Property(x => x.ModifiedBy).HasMaxLength(255);
        builder.Property(x => x.TotalAmountPaid).HasColumnType("decimal(18,2)");
        builder.HasOne(x => x.PaymentMethod)
               .WithMany()
               .HasForeignKey(x => x.PaymentMethodId)
               .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.PaymentStatus)
               .WithMany()
               .HasForeignKey(x => x.PaymentStatusId)
               .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.Client)
               .WithMany()
               .HasForeignKey(x => x.ClientId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}
