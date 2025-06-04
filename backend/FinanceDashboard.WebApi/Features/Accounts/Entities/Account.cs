namespace FinanceDashboard.WebApi.Features.Accounts.Entities;

public class Account
{
    public int Id { get; set; }

    public required string Name { get; set; }
    public decimal CurrentBalance { get; set; }
    public bool IsPrimary { get; set; }

    public required Guid UserId { get; set; }
}
