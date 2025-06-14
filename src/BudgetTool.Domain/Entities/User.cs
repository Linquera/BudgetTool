namespace BudgetTool.Domain.Entities;

public record User
{
    public Guid Id { get; set; }

    public required string Name { get; set; }
}
