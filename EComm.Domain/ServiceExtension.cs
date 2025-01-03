using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace EComm.Domain
{
    public static class ServiceExtension
    {

        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            return services;
        }
    }
}

