using AutoMapper;
using MonsterApp.DataAccess;
using MonsterApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterApp.DataClient
{
  public class MonsterAutoMapper
  {
    private MapperConfiguration mapper =
       new MapperConfiguration(m => m.CreateMap<Monster, MonsterDAO>().ForMember(d => d.Id, o => o.MapFrom(s => s.MonsterId)));


    public object MapTo(object o, object o1)
    {
      var m = mapper.CreateMapper();


      return m.Map(o, o1);
    }
  }
}