using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Infrastructur.Presistence.Entities
{
    public class ToDoList
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<ToDoItem> ToDoItems { get; set; } = new List<ToDoItem>();
    }
}
