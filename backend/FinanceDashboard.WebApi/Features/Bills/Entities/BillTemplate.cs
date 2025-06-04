namespace FinanceDashboard.WebApi.Features.Bills.Entities;

public class BillTemplate
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public decimal EstimatedAmount { get; set; }
    public int EstimatedDueDay { get; set; }

    public required Guid UserId { get; set; }

    public ICollection<BillInstance> Instances { get; set; } = [];
}
