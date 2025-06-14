using BudgetTool.Domain.Enums;

namespace BudgetTool.Domain.Entities;

public record Transaction
{
    public Guid Id { get; set; }

    public DateTime Date { get; set; }

    public OperationType Operation { get; set; }

    public required Account Account { get; set; }

    public Category? Category { get; set; }
}
