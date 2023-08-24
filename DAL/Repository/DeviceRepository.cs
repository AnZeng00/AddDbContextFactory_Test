using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly IServiceScopeFactory _scopeFactory;
        public DeviceRepository(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }
        public void Add(Device device)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<DataContext>();
                var result = context.Devices.ToList();
            }
        }
    }
}
