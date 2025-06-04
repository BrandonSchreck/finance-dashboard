using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceDashboard.WebApi.Features.Bills.Entities.Configurations;

public class BillTemplateConfiguration : IEntityTypeConfiguration<BillTemplate>
{
    public void Configure(EntityTypeBuilder<BillTemplate> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Name).IsRequired();
        builder.Property(e => e.EstimatedAmount).HasPrecision(10, 2);

        builder.HasMany(e => e.Instances)
            .WithOne(i => i.Template)
            .HasForeignKey(i => i.TemplateId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => e.UserId);
    }
}
