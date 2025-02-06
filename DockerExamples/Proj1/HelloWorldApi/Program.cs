var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();

app.MapGet("/", () =>
{
    return "Hello World!";
});

app.Run();

