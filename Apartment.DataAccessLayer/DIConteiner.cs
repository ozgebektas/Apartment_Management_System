using Apartment.BusinessLayer.Abstract;
using Apartment.BusinessLayer.Concrete;
using Apartment.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.DataAccessLayer
{
    public static class DIContainer
    {

        public static IServiceCollection DataDependencies(this IServiceCollection services, IConfiguration configuration)
        {

            //DbContext
            var connectionString = configuration.GetConnectionString("SqlServer");
            services.AddDbContext<ApartmentDbContext>(opt => opt.UseSqlServer(connectionString));

            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IBankInfoRepository, BankInfoRepository>();
            services.AddScoped<IBillRepository, BillRepository>();
            services.AddScoped<IDueRepository, DueRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IResidenceRepository, ResidenceRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }




    }
}