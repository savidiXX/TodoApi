using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data
{
    public class TodoContext : DbContext
    {
        
        TodoContext(DbContextOptions<TodoContext> options)  : base(options) { }
        public DbSet<TodoItem> Todos {get; set;}
        
    
    }
}