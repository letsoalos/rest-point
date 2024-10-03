using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.Property(x => x.TransactionId).HasMaxLength(255);
        builder.Property(x => x.InvoiceNumber).HasMaxLength(255);
        builder.Property(x => x.CreatedBy).HasMaxLength(255);
        builder.Property(x => x.ModifiedBy).HasMaxLength(255);
        builder.Property(x => x.AmountPaid).HasColumnType("decimal(18,2)");
        builder.HasOne(x => x.PaymentMethod)
               .WithMany()
               .HasForeignKey(x => x.PaymentMethodId)
               .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.PaymentStatus)
               .WithMany()
               .HasForeignKey(x => x.PaymentStatusId)
               .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.ClientPremium)
               .WithMany()
               .HasForeignKey(x => x.ClientPremiumId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}
