using BudgetTool.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApiIoc(builder.Configuration);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
