using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDo.Infrastructur.Presistence.Entities
{
    public class ToDoAppDbContext: DbContext
    {
        public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext>options) :base(options)
        {
            
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<ToDoList>()
      .HasOne(t => t.User)
      .WithMany(u => u.ToDoLists)
      .HasForeignKey(t => t.UserId);


            modelBuilder.Entity<ToDoList>()
                .HasOne(t => t.User)
                .WithMany(u => u.ToDoLists)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ActivityLog>()
                .HasOne(a => a.User)
                .WithMany(u => u.ActivityLogs)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // ToDoItem - Tag (Many-to-Many)
            modelBuilder.Entity<ToDoItem>()
                .HasMany(x => x.Tags)
                .WithMany(x => x.ToDoItems);


        }




        public DbSet<User> users { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }

    }
}
