var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Rus ?  ��� ��� ���!");

app.Run();
