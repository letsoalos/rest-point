using Core.Entities._LookUps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class ClientStatusConfiguration : IEntityTypeConfiguration<ClientStatus>
{
    public void Configure(EntityTypeBuilder<ClientStatus> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(255);
        builder.Property(x => x.Description).HasMaxLength(255);
    }
}
