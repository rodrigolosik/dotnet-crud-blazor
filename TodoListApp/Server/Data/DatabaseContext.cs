using Microsoft.EntityFrameworkCore;
using TodoListApp.Shared.Models;

namespace TodoListApp.Server.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public virtual DbSet<Todo> Todos { get; set; }
}
