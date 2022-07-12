using Backend;
using Microsoft.EntityFrameworkCore;

var policyName = "_myAllowSpecificOrigins"; // variable que definira las politicas de cors
var builder = WebApplication.CreateBuilder(args);


//Inyecsion de dependencias 
var connectionStrings = builder.Configuration.GetConnectionString("DefaultConex");
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(connectionStrings));

//construye la politica, inidcando que permitira todos lso origenes, todos los metodos y todos los encabezados
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policyName,
                      builder =>
                      {
                          builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                      });
});


// Add services to the container.
builder.Services.AddControllers();

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

//
app.UseCors(policyName);

app.UseAuthorization();

app.MapControllers();

app.Run();
