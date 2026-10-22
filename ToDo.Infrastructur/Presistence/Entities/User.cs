namespace ToDo.Infrastructur.Presistence.Entities
{
    public class User:BaseAuditTableEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public ICollection<ToDoList> ToDoLists { get; set; }
        = new List<ToDoList>();

        public ICollection<Comment> Comments { get; set; }
            = new List<Comment>();

        public ICollection<ActivityLog> ActivityLogs { get; set; }
            = new List<ActivityLog>();
    }



    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }

    public abstract class BaseAuditTableEntity : BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }

}
