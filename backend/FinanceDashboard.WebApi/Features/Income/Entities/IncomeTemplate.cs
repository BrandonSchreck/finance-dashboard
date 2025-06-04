namespace FinanceDashboard.WebApi.Features.Income.Entities;

public class IncomeTemplate
{
    public int Id { get; set; }
    public required string SourceName { get; set; }
    public decimal EstimatedAmount { get; set; }
    public int EstimatedReceivedDay { get; set; }

    public required Guid UserId { get; set; }

    public ICollection<IncomeInstance> Instances { get; set; } = [];
}
