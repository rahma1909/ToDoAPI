using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Infrastructur.Presistence.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Foreign Key
        public int ToDoItemId { get; set; }

        // Navigation Property
        public ToDoItem ToDoItem { get; set; } = null!;


        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
