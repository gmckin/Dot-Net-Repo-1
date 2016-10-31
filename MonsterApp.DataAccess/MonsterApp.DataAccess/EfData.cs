using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
  public class EfData
  {

    private MonsterDBEntities db = new MonsterDBEntities();


    public List<Gender> GetGender()
    {
      return db.Genders.ToList();
    }

    public bool InsertGender(Gender gender)
    {
      db.Genders.Add(gender);

      return db.SaveChanges() > 0;
    }

    public bool ChangeGender(Gender gender, EntityState state)
    {
      var entry = db.Entry<Gender>(gender);
      entry.State = state;

      return db.SaveChanges() > 0;
    }

    public void SearchGender()
    {
      var actives = db.Genders.Where(a => a.Active);
      var inactives = db.Genders.Select(a => !a.Active);
      var ma = db.Genders.Where(m => m.GenderName.ToLower().Contains("ma"));

      //actives.ToList();
      //inactives.ToList();
      //ma.ToList();

    }

    public void DeleteGender()
    {

    }



    public List<MonsterType> GetMonsterType()
    {
      return db.MonsterTypes.ToList();
    }

    public bool InsertMonsterType(MonsterType type)
    {
      db.MonsterTypes.Add(type);

      return db.SaveChanges() > 0;
    }

    public bool ChangeMonsterType(MonsterType type, EntityState state)
    {
      var entry = db.Entry<MonsterType>(type);
      entry.State = state;

      return db.SaveChanges() > 0;
    }

    public List<Title> GetTitle()
    {
      return db.Titles.ToList();
    }

    public bool InsertTitle(Title title)
    {
      db.Titles.Add(title);

      return db.SaveChanges() > 0;
    }

    //public List<Title> GetMonster()
    //{
    //  return db.Monsters.ToList();
    //}

    //public void InsertMonster()
    //{
    //  db.Monsters.Add(monster);

    //  return db.SaveChanges() > 0;
    //}
  }
}
