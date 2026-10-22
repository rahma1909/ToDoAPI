using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.DomainEntities
{
    public class ActivityLogDomain
    {
        public int Id { get; set; }

        public string Action { get; set; } = string.Empty;

        public string? Details { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
