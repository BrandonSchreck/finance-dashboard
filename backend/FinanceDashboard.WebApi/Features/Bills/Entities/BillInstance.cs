namespace FinanceDashboard.WebApi.Features.Bills.Entities;

public class BillInstance
{
    public int Id { get; set; }

    public required int TemplateId { get; set; }
    public BillTemplate Template { get; set; } = default!;

    public DateOnly EstimatedDueDate { get; set; }
    public decimal Amount { get; set; }

    public BillStatus Status { get; set; } = BillStatus.Pending;
    public DateOnly? ClearedDate { get; set; }

    public required Guid UserId { get; set; }
}
