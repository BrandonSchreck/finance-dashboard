using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceDashboard.WebApi.Features.Income.Entities.Configurations;

public class IncomeTemplateConfiguration : IEntityTypeConfiguration<IncomeTemplate>
{
    public void Configure(EntityTypeBuilder<IncomeTemplate> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.SourceName).IsRequired();
        builder.Property(e => e.EstimatedAmount).HasPrecision(10, 2);

        builder.HasMany(e => e.Instances)
            .WithOne(i => i.Template)
            .HasForeignKey(i => i.TemplateId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => e.UserId);
    }
}
