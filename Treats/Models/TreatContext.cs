using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public virtual DbSet<Flavor> Flavors { get; set; }   // virtual here?
    
    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}