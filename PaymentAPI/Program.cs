using Microsoft.EntityFrameworkCore;
using PaymentData.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var conStr = builder.Configuration.GetConnectionString("sql");
builder.Services.AddDbContext<PaymentDbContext>(options => options.UseSqlServer(conStr));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

//Middleware
//1. Container -> Add services, implement DI(Depenedency Injection)
//2. HTTP pipleline

// Rest API -> it is software architecture style. it will have constraints. based one constraint
//API will handle Reqest and Response
// HTTP Verbs- GET, POST, PUT, DELETE, Patch
// http://abcbank.com/transaction?acno=123&amount=1000&type=saving&option=debit
// HTTP PUT


// http://google.com/report?city=blr&date=12/2/2024


