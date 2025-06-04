using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceDashboard.WebApi.Features.Accounts.Entities.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Name).IsRequired();
        builder.Property(e => e.CurrentBalance).HasPrecision(10, 2);

        builder.HasIndex(e => new { e.UserId, e.IsPrimary })
            .IsUnique()
            .HasFilter("\"IsPrimary\" = TRUE");
    }
}