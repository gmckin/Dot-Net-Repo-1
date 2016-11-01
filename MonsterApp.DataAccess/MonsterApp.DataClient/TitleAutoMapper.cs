using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MonsterApp.DataAccess.Models;

namespace MonsterApp.DataClient.Models
{
  public class TitleAutoMapper
  {
    private MapperConfiguration mapper =
      new MapperConfiguration(m => m.CreateMap < Title, TitleDAO>().ForMember(d => d.Id, o => o.MapFrom(s => s.TitleId)));


    public object MapTo(object o, object o1)
    {
      var m = mapper.CreateMapper();


      return m.Map(o, o1);
    }
  }
}