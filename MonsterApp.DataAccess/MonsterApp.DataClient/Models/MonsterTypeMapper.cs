using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DA = MonsterApp.DataAccess.Models;

namespace MonsterApp.DataClient.Models
{
  public class MonsterTypeMapper
  {
    public static MonsterTypeDAO MapToMonsterTypeDAO(DA.MonsterType monstertype)
    {
      var m = new MonsterTypeDAO();
      m.Id = monstertype.MonsterTypeId;
      m.Name = monstertype.Name;


      return m;
    }

    public static object MapTo(object o)
    {
      var properties = o.GetType().GetProperties();
      var ob = new object();

      foreach (var item in properties.ToList())
      {
        ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));
      }
      return ob;
    }

  }
}