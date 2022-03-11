using Tweet.API.Infrastructure;
using Tweet.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwagger();
builder.Services.AddServices();

// DI Tweet.Data.Services
builder.Services.AddTweetDataServices(builder.Configuration);

builder.Services.AddAuthorization();


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
