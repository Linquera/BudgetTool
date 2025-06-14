namespace BudgetTool.Domain.Entities;

public record Account
{
    public Guid Id { get; set; }

    public required string Description { get; set; }

    public required User User { get; set; }

    public decimal CurrentBalance { get; set; }
}
