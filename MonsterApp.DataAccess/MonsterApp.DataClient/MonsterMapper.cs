using MonsterApp.DataAccess;
using DA = MonsterApp.DataAccess.Models;
using MonsterApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterApp.DataClient
{
  public class MonsterMapper
  {

    public static MonsterDAO MapToMonsterDAO(Monster monster)
    {
      var m = new MonsterDAO();
      m.Id = monster.MonsterId;
      m.Name = monster.Name;
      m.Gender.Id = monster.Gender.GenderId;
      m.Type.Id = monster.MonsterType.MonsterTypeId;

      return m;
    }

    public static DA.Monster MapToMonster(MonsterDAO monster)
    {
      throw new NotImplementedException();
    }


    // this is an example of "Reflection"
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