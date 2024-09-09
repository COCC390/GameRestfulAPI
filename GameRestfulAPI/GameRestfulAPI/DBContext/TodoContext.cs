using GameRestfulAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameRestfulAPI.DBContext
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
       : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
