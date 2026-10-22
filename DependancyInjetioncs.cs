using System.Runtime.CompilerServices;
using ToDo.Infrastructur.Presistence.Entities;
namespace ToDo.API
{
    public static class DependancyInjetioncs
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
                                                             IConfiguration configuration) {


            var ConnectionString = configuration.GetConnectionString("ConnectionStrings");
            return services;
        }








    }
}
