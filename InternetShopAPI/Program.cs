using InternetShopAPI.Configuration;
using InternetShopAPI.DataBase;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.ConfigureService();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var context = app.Services.GetRequiredService<ApiDbContext>();
context.Database.EnsureCreated();

app
    .UseRouting()
    .UseSwagger()
    .UseSwaggerUI()
    .UseEndpoints(x => x.MapControllers());

app.Run();
