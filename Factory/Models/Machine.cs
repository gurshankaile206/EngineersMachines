
using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<FactoryMachine>();
    }

    public int MachineId { get; set; }
    public string Description { get; set; }

    public virtual ICollection<FactoryMachine> JoinEntities { get;}
  }
}