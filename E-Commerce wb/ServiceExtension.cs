using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EComm.Application;
using EComm.Infrastructure;
using EComm.Persistance.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce_wb
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddAPI(this IServiceCollection services)
        {

            services.AddAutoMapper(typeof(MappingProfile));
            services.AddApplication()
                    .AddPersistence()
                    . AddInfra(); 


            return services;
        }
    }
}
