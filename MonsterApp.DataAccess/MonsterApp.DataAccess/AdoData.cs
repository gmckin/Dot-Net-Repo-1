using Monster = MonsterApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
  public partial class AdoData
  {
    private string connectionString = ConfigurationManager.ConnectionStrings["MonsterDB"].ConnectionString;

    #region Methods
    public List<Gender> GetGenders()
    {
      try
      {
        var ds = GetDataDisconnected("select * from Monster.Gender;");
        var genders = new List<Gender>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
          genders.Add(new Gender
          {
            GenderId = int.Parse(row[0].ToString()),
            GenderName = row[1].ToString(),
            Active = bool.Parse(row[2].ToString())
          });
        }
        return genders;
      }
      catch (Exception)
      {
        Debug.WriteLine("wtf");
       return null;
      }      
    }

    public int GetRecentGender()
    {
      try
      {
        var ds = GetDataDisconnected("select Top[1] * from Monster.Gender as g order by g.GenderId desc;");
        Models.Gender gen = new Models.Gender();
        gen.GenderId = int.Parse(ds.Tables[0].Rows[0][0].ToString());
        gen.GenderName = ds.Tables[0].Rows[0][1].ToString();
        gen.Active = bool.Parse(ds.Tables[0].Rows[0][2].ToString());

        //var genders = new List<Gender>();

        //foreach (DataRow row in ds.Tables[0].Rows)
        //{
        //  genders.Add(new Gender
        //  {
        //    GenderId = int.Parse(row[0].ToString()),
        //    GenderName = row[1].ToString(),
        //    Active = bool.Parse(row[2].ToString())
        //  });
        //}
        return gen.GenderId;
      }
      catch (Exception)
      {
        Debug.WriteLine("wtf");
        return 0;
      }
    }

    public List<MonsterType> GetMonsterTypes()
    {
      try
      {
        var ds = GetDataDisconnected("select * from Monster.MonsterType;");

        var monstertype = new List<MonsterType>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
          monstertype.Add(new MonsterType
          {
           MonsterTypeId = int.Parse(row[0].ToString()),
           TypeName = row[1].ToString(),
            Active = bool.Parse(row[2].ToString())
          });
        }
        return monstertype;
      }
      catch (Exception)
      {
        return null;
      }      
    }

    public List<Title> GetTitles()
    {
      try
      {
        var ds = GetDataDisconnected("select * from Monster.Title;");
        var title = new List<Title>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
          title.Add(new Title
          {
            TitleId = int.Parse(row[0].ToString()),
            TitleName = row[1].ToString(),
            Active = bool.Parse(row[2].ToString())
          });
        }
        return title;
      }
      catch (Exception)
      {
        return null;
      }
    }

    public List<Monster> GetMonsters()
    {
      try
      {
        var ds = GetDataDisconnected("select * from Monster.Monster;");
        var monster = new List<Monster>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
          monster.Add(new Monster
          {
            MonsterId = int.Parse(row[0].ToString()),
            GenderId = int.Parse(row[1].ToString()),
            TitleId = int.Parse(row[2].ToString()),
            TypeId = int.Parse(row[3].ToString()),
            Name = row[4].ToString(),
            PicturePath = row[5].ToString(),
            Active = bool.Parse(row[6].ToString())
          });
        }
        return monster;
      }
      catch (Exception)
      {
        return null;
      }

    }


    
    #endregion

    private DataSet GetDataDisconnected(string query)
    {      
     
      SqlCommand cmd;
      
      DataSet ds;
     
      SqlDataAdapter da;

      using (var con = new SqlConnection(connectionString))
      {
        cmd = new SqlCommand(query, con);        
        da = new SqlDataAdapter(cmd);

        ds = new DataSet();
        da.Fill(ds);
      }
      return ds;
    }
  }
}
