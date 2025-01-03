
using EComm.Domain.Interface;
using EComm.Persistance.Repositories.Non_Genric_Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EComm.Persistance.Extensions
{
    public static class ServiceExtension
    {

        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<EcommerceDBContext>(option => option.UseSqlServer("Server=CPC-param-7Q3RT;Database=ParamEcomm2DB;Trusted_Connection=True;TrustServerCertificate=true;")
            .UseLazyLoadingProxies());

            services.AddScoped<ICustomerRepo, CustomerRepo>();
            return services;
        }
    }
}




