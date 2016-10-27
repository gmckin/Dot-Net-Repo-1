using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess.Models
{
  public class Monster
  {
    public int MonsterId { get; set; }
    public int GenderId { get; set; }
    public int TitleId { get; set; }
    public int MonsterTypeId { get; set; }
    public string Name { get; set; }
    public string Picture { get; set; }
    public bool Active { get; set; }
  }
}
