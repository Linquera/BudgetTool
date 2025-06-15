using Microsoft.EntityFrameworkCore;

namespace BudgetTool.Infra.Contexts;

internal class BudgetDbContext(DbContextOptions<BudgetDbContext> options) : DbContext(options)
{

}
