using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ToDo.Domain.DomainEntities.RepositoryInterface;
using ToDo.Infrastructur.Presistence.Entities;

namespace ToDo.Infrastructur.Repository
{
    public class GenericRepository<TDomain, TEntity>
        : IGenericRepository<TDomain> where TDomain : class
                                      where TEntity: class

    {
        private readonly ToDoAppDbContext toDoAppDbContext;
        private readonly Mapper mapper;

        public GenericRepository(ToDoAppDbContext ToDoAppDbContext,Mapper mapper)
        {
            toDoAppDbContext = ToDoAppDbContext;
            this.mapper = mapper;
        }
        public async Task AddAsync(TDomain domain)
        {
            var entity =  mapper.Map<TEntity>(domain);
             await toDoAppDbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task<int> CommitAsync()
        {
            return await toDoAppDbContext.SaveChangesAsync
                ();
        }

        public async Task<IEnumerable<TDomain>> GetAllAsync()
        {
           return await toDoAppDbContext.Set<TEntity>().ProjectTo<TDomain>
                 (mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<TDomain> GetByIdAsync(object id)
        {
            var entity = await toDoAppDbContext.Set<TEntity>().FindAsync(id);

            return entity == null ? null : mapper.Map<TDomain>(entity);
        
        }
    }
}
