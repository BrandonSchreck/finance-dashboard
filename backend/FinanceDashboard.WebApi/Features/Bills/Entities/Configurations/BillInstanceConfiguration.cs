using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceDashboard.WebApi.Features.Bills.Entities.Configurations;

public class BillInstanceConfiguration : IEntityTypeConfiguration<BillInstance>
{
    public void Configure(EntityTypeBuilder<BillInstance> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Amount).HasPrecision(10, 2);
        builder.Property(e => e.Status);

        builder.HasOne(e => e.Template)
            .WithMany(t => t.Instances)
            .HasForeignKey(e => e.TemplateId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => new { e.UserId, e.EstimatedDueDate });    
    }
}