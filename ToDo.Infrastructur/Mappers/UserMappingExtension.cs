using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ToDo.Domain.DomainEntities;
using ToDo.Infrastructur.Presistence.Entities;

namespace ToDo.Infrastructur.Mappers
{
    public class UserMappingExtension
        :Profile 
        
    {


        public UserMappingExtension()
        {
            CreateMap<User, UserDomain>();
        }
    }
}
