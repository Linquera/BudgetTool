namespace BudgetTool.Domain.Entities;

public record Category
{
    public Guid Id { get; set; }

    public required string Description { get; set; }

    public string? Icon { get; set; }
}
