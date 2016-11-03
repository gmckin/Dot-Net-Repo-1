using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MonsterApp.DataClient.Models
{
  [DataContract]
  public class MonsterDAO
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public GenderDAO Gender { get; set; }

    [DataMember]
    public MonsterTypeDAO Type { get; set; }
  }
}