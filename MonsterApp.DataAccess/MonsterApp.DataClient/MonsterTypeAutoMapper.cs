using AutoMapper;
using MonsterApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonsterApp.DataClient.Models;

namespace MonsterApp.DataClient
{
  public class MonsterTypeAutoMapper
  {
    private MapperConfiguration mapper =
      new MapperConfiguration(m => m.CreateMap<MonsterType, MonsterTypeDAO>().ForMember(d => d.Id, o => o.MapFrom(s => s.MonsterTypeId)));


    public object MapTo(object o, object o1)
    {
      var m = mapper.CreateMapper();


      return m.Map(o, o1);
    }
  }
}