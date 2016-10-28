using MonsterApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MonsterApp.DataAccess
{
  public partial class AdoData
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="gender"></param>
    /// <returns></returns>
    public bool InsertGender(Models.Gender gender)
    {
      var n = new SqlParameter("name", gender.GenderName);
      var query = "insert into Monster.Gender(GenderName, Active) values (@name, 1)";

      return InsertData(query, n) == 1;
    }

    public bool InsertMonster(Models.Monster monster)
    {
      var name = new SqlParameter("name", monster.Name);
      var genderid = new SqlParameter("genderid", monster.GenderId);
      var titleid = new SqlParameter("titleid", monster.TitleId);
      var monstertypeid = new SqlParameter("monstertypeid", monster.MonsterTypeId);
      var picture = new SqlParameter("picture", monster.Picture);
      var active = new SqlParameter("active", 1);
      var query = "insert into Monster.Monster(Name, GenderId, TitleId, MonsterTypeId, Picture, Active) values (@name, @genderid, @titleid, @monstertypeid, @picture, 1)";

      return InsertData(query, name, genderid, titleid, monstertypeid, picture, active) == 1; ;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="query"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    private int InsertData(string query, params SqlParameter[] parameters)
    {
      int result;

      using (var connection = new SqlConnection(connectionString))
      {
        var cmd = new SqlCommand(query, connection);

        connection.Open();
        cmd.Parameters.AddRange(parameters);
        result = cmd.ExecuteNonQuery();
      }

      return result;
    }
  }
}