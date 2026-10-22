using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using ToDo.Infrastructur.Presistence.Entities;
namespace ToDo.API
{
    public static class DependancyInjetioncs
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
                                                             IConfiguration configuration) {


            var ConnectionString = configuration.GetConnectionString("DefaultConnection");


            services.AddDbContext<ToDoAppDbContext>(options =>
            options.UseSqlServer(ConnectionString)
            );

            return services;
        }








    }
}
