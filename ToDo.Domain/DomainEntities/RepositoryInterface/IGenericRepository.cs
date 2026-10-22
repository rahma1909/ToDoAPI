using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.DomainEntities.RepositoryInterface
{
    public interface IGenericRepository<TDomain> where TDomain: class
    
    {
        Task<TDomain> GetByIdAsync(object id);

        Task<IEnumerable<TDomain>> GetAllAsync();

        Task AddAsync(TDomain domain);

        Task<int> CommitAsync();



            }
}
