using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MonsterApp.DataClient.Models
{
  [DataContract]
  public class GenderDAO
  {
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }
  }
}