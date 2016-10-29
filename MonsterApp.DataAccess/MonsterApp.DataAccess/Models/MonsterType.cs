using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess.Models
{
  public class MonsterType
  {
    public int MonsterTypeId { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
  }
}
