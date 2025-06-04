using FinanceDashboard.WebApi.Features.Accounts.Entities;
using FinanceDashboard.WebApi.Features.Bills.Entities;
using FinanceDashboard.WebApi.Features.Income.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceDashboard.WebApi.Infrastructure.Data;

public class FinanceDashboardDbContext(DbContextOptions<FinanceDashboardDbContext> options) : DbContext(options)
{
    public DbSet<Account> Accounts => Set<Account>();

    public DbSet<BillInstance> BillInstances => Set<BillInstance>();
    public DbSet<BillTemplate> BillTemplates => Set<BillTemplate>();
    
    public DbSet<IncomeInstance> IncomeInstances => Set<IncomeInstance>();
    public DbSet<IncomeTemplate> IncomeTemplates => Set<IncomeTemplate>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FinanceDashboardDbContext).Assembly);
    }
}
