﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
  public class EfData
  {

    private MonsterDBEntities1 db = new MonsterDBEntities1();


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

    public int SearchGender()
    {
      //var actives = db.Genders.Where(a => a.Active);
      //var inactives = db.Genders.Select(a => !a.Active);
      //var ma = db.Genders.Where(m => m.GenderName.ToLower().Contains("ma"));
      var topgenderid = db.Genders.Where(a => a.Active).Max(a => a.GenderId);
      //actives.ToList();
      //inactives.ToList();
      //ma.ToList();

      return topgenderid;

    }

    public bool DeleteGender(Gender gender, EntityState state)
    {
      var entry = db.Entry<Gender>(gender);

      gender.Active = false;
      
      entry.State = state;

      return db.SaveChanges() > 0;      
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

    public bool InsertMonster(Monster monster)
    {
      db.Monsters.Add(monster);

      return db.SaveChanges() > 0;
    }
    
    public bool ChangeMonster(Monster monster, EntityState state)
    {
      var entry = db.Entry<Monster>(monster);
      entry.State = state;

      return db.SaveChanges() > 0;
    }

  }
}
