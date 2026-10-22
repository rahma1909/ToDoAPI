using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Infrastructur.Presistence.Entities
{
    public class ToDoItem
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int ToDoListId { get; set; }

        public ToDoList ToDoList { get; set; } = null!;

        public ICollection<Tag> Tags { get; set; }
            = new List<Tag>();

        public ICollection<Comment> Comments { get; set; }
            = new List<Comment>();

        public ICollection<ActivityLog> ActivityLogs { get; set; }
            = new List<ActivityLog>();
    }
}
