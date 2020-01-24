namespace ToDoList.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Description { get; set; }
    public int TreatId { get; set; }
    public virtual Treat Treat { get; set; }
  }
}