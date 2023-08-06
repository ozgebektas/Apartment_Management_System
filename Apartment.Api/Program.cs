using Apartment.BusinessLayer.Abstract;
using Apartment.BusinessLayer.Concrete;
using Apartment.Core;
using Apartment.DataAccessLayer;
using Apartment.DataAccessLayer.Context;
using Apartment.EntityLayer.Concretes;
using Apartment.EntityLayer.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

 builder.Services.AddDbContext<ApartmentDbContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ApartmentDbContext>();


builder.Services.AddScoped<IMessageRepository, MessageRepository>();
builder.Services.AddScoped<IBankInfoRepository, BankInfoRepository>();
builder.Services.AddScoped<IBillRepository, BillRepository>();
builder.Services.AddScoped<IDueRepository, DueRepository>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IResidenceRepository, ResidenceRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.ApplicationDependencies();



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

app.UseAuthorization();

app.MapControllers();

app.Run();
