using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateDatabaseExtension_Domain = CafeManagement.Domain.Extensions.UpdateDatabaseExtension;
namespace CafeManagement.Business.Extensions
{
    public static class UpdataDatabaseExtension
    {
        public static void UpdateDatabase(this IServiceProvider serviceProvider)    
            => UpdateDatabaseExtension_Domain.SeedAndMigrate(serviceProvider);
        
    }
}
