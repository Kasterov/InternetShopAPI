using InternetShopAPI.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.ConfigureService();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app
    .UseRouting()
    .UseSwagger()
    .UseSwaggerUI()
    .UseEndpoints(x => x.MapControllers());

app.Run();
