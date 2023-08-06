using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Core
{
    public static class DIContainer
    {
        public static IServiceCollection ApplicationDependencies(this IServiceCollection services)
        {

            //Mapper added to container
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
