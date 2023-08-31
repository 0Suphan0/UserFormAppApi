using Microsoft.EntityFrameworkCore;
using UserWebApiProject.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Genel CORS Politikasý Belirleme
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(builder =>
        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));

//DbContexi service üzerinden ekleme... 
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); //appsetting.json üzerinden default conn. tanýmlandý...

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseCors();
app.UseAuthentication();


app.MapControllers();

app.UseHttpsRedirection();


app.Run();
