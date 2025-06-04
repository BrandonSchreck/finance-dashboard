namespace FinanceDashboard.WebApi.Features.Income.Entities;

public class IncomeInstance
{
    public int Id { get; set; }
    
    public required int TemplateId { get; set; }
    public IncomeTemplate Template { get; set; } = default!;

    public DateOnly EstimatedReceivedDate { get; set; }
    public decimal Amount { get; set; }

    public IncomeStatus Status { get; set; } = IncomeStatus.Pending;
    public DateOnly? ReceivedDate { get; set; }

    public required Guid UserId { get; set; }
}
