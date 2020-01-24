using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<Flavor>();
        }

        public int TreatId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Flavor> Flavors { get; set; }
    }
}