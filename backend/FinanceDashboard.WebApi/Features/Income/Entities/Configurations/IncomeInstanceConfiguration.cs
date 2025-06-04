using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceDashboard.WebApi.Features.Income.Entities.Configurations;

public class IncomeInstanceConfiguration : IEntityTypeConfiguration<IncomeInstance>
{
    public void Configure(EntityTypeBuilder<IncomeInstance> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Amount).HasPrecision(10, 2);
        builder.Property(e => e.Status);

        builder.HasOne(e => e.Template)
            .WithMany(t => t.Instances)
            .HasForeignKey(e => e.TemplateId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => new { e.UserId, e.EstimatedReceivedDate });
    }
}
