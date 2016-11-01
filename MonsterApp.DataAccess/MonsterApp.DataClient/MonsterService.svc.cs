using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MonsterApp.DataClient.Models;
using MonsterApp.DataAccess;
using MonsterApp.DataAccess.Models;

namespace MonsterApp.DataClient
{
  public class MonsterService : IMonsterService
  {
    private AdoData data = new AdoData();
    public List<GenderDAO> GetGender()
    {
      
      var g = new List<GenderDAO>();

      foreach (var gender in data.GetGenders())
      {
        g.Add(GenderMapper.MapToGenderDAO(gender));
      }

      return g;
    }

    public List<MonsterTypeDAO> GetMonsterType()
    {
      var m = new List<MonsterTypeDAO>();

      foreach (var monstertype in data.GetMonsterTypes())
      {
        m.Add(MonsterTypeMapper.MapToMonsterTypeDAO(monstertype));
      }

      return m;
    }

    public List<TitleDAO> GetTitles()
    {
      var t = new List<TitleDAO>();

      foreach (var titles in data.GetTitles())
      {
        t.Add(TitleMapper.MapToTitleDAO(titles));
      }

      return t;
    }
  }
}
