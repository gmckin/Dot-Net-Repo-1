using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MonsterApp.DataClient.Models;
using DA = MonsterApp.DataAccess.Models;
using MonsterApp.DataAccess;

namespace MonsterApp.DataClient
{
  public class MonsterService : IMonsterService
  {
    private AdoData data = new AdoData();
    private EfData ef = new EfData();
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

    //public List<MonsterDAO> GetMonsters()
    //{
    //  var t = new List<MonsterDAO>();

    //  foreach (var monsters in data.GetMonsters())
    //  {
    //    t.Add(MonsterMapper.MapToMonsterDAO(monsters));
    //  }

    //  return t;
    //}

    public bool InsertMonster(MonsterDAO monster)
    {
      var m = new Monster();
      m.Name = monster.Name;
      m.GenderId = monster.Gender.Id;
      m.TypeId = monster.Type.Id;

      return ef.InsertMonster(m);      
    }

    public bool InsertGender(GenderDAO gender)
    {
      var g = new Gender();
      g.GenderName = gender.Name;
      g.GenderId = gender.Id;
     
      return ef.InsertGender(g);
    }

    public bool InsertMonsterType(MonsterTypeDAO mtype)
    {
      var mt = new MonsterType();
      mt.TypeName = mtype.Name;
      mt.MonsterTypeId = mtype.Id;

      return ef.InsertMonsterType(mt);
    }

    public bool InsertTitle(TitleDAO title)
    {
      var t = new Title();
      t.TitleName = title.Name;
      t.TitleId = title.Id;

      return ef.InsertTitle(t);
    }
  }
}
