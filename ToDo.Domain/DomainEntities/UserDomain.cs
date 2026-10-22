using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.DomainEntities
{
    public class UserDomain
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
    }
}
