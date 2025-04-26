using Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//
builder.Services.AddTransient<IAccountService, AccountService>();


//DB
builder.Services.AddDbContext<AppDbContext>(options => options
    .UseSqlServer("Server = WIN-T0TUUU3CIMK\\SQLEXPRESS;Database=Identity;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;"));


//Identity
builder.Services
    .AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddAuthorization();

//Controllers
builder.Services.AddControllers();


// Add services to the container.
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

app.UseHttpsRedirection();

app.MapGet("/teste", () => "Hello World")
    .RequireAuthorization();


app.MapControllers();
app.Run();
