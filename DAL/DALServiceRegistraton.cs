using DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DALServiceRegistraton
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextFactory<DataContext>(options =>
               options.UseNpgsql(
                   configuration.GetConnectionString("DefaultConnection")),ServiceLifetime.Scoped);
            services.AddScoped<IDeviceRepository,DeviceRepository>();
            return services;
        }
    }
}
