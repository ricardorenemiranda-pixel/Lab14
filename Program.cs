using lab08_ricardoquispea.Models;
using lab08_ricardoquispea.Repositories;
using lab08_ricardoquispea.Repositories.Interfaces;
using lab08_ricardoquispea.Services;
using lab08_ricardoquispea.Services.Interfaces;
using lab08_ricardoquispea.UnitOfWork;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LinqexampleContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>(); 
builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>(); 
builder.Services.AddScoped<IOrderRepository, OrderRepository>();  
builder.Services.AddScoped<IOrderService, OrderService>();        
builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();       
builder.Services.AddScoped<IProductService, ProductService>();        
var app = builder.Build();

// Swagger disponible siempre (necesario para revisar la API en Render)
app.UseSwagger();
app.UseSwaggerUI();

// HTTPS redirect deshabilitado: Render maneja TLS en el proxy
// app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();