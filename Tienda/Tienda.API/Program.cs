using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Tienda.API.Context;
using Tienda.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//CONECCTION
builder.Services.AddDbContext<TiendaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConecction"));
});


builder.Services.AddScoped<IProductosServices, ProductosServices>();
builder.Services.AddScoped<IProveedoresServices, ProveedoresServices>();


builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());


//CORS
builder.Services.AddCors(options=>{
    options.AddPolicy(name: "myCors",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("myCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
