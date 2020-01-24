using Microsoft.EntityFrameworkCore;

namespace TreatsList.Models
{
  public class TreatsListContext : DbContext
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public virtual DbSet<Flavor> Flavors { get; set; }  
    
    public TreatsListContext(DbContextOptions options) : base(options) { }
  }
}