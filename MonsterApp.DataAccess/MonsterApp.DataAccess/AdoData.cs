using MonsterApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
  public class AdoData
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

       return null;
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
            Name = row[1].ToString(),
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
    #endregion

    private DataSet GetDataDisconnected(string query)
    {
      
      // create the sql command
      SqlCommand cmd;

      //our container this time
      DataSet ds;

      // the bridge between code and db
      SqlDataAdapter da = new SqlDataAdapter();

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
