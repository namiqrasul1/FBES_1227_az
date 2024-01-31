using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoWebService.Models.Entities;

namespace TodoWebService.Data
{
    public class TodoDbContext : IdentityDbContext<AppUser>
    {
        public TodoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TodoItem> TodoItems => Set<TodoItem>();
    }
}
