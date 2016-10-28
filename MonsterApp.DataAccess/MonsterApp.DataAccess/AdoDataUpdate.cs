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
    public bool UpdateGender(Models.Gender gender)
    {
      var query = "update Monster.Gender set Name = @name, Active = @active where GenderId = @id";
      var name = new SqlParameter("name", gender.GenderName);
      var active = new SqlParameter("active", gender.Active ? 1 : 0);
      var id = new SqlParameter("id", gender.GenderId);
      int result;

      using (var connection = new SqlConnection(connectionString))
      {
        var cmd = new SqlCommand(query, connection);

        connection.Open();
        cmd.Parameters.AddRange(new SqlParameter[] { id, name, active });
        result = cmd.ExecuteNonQuery();
      }

      return result >= 0;
    }

    public bool UpdateMonster(Models.Monster monster)
    {
      var query = "update Monster.Monster set Name = @name, GenderId = @genderid, TitleId = @titleid, MonsterTypeId = @monstertypeid, Picture =  @picture, Active = @active where MonsterId = @id";

      var name = new SqlParameter("name", monster.Name);
      var genderid = new SqlParameter("genderid", monster.GenderId);
      var titleid = new SqlParameter("titleid", monster.TitleId);
      var monstertypeid = new SqlParameter("monstertypeid", monster.MonsterTypeId);
      var picture = new SqlParameter("picture", monster.Picture);
      var active = new SqlParameter("active", 1);
      
      var id = new SqlParameter("id", monster.MonsterId);
      int result;

      using (var connection = new SqlConnection(connectionString))
      {
        var cmd = new SqlCommand(query, connection);

        connection.Open();
        cmd.Parameters.AddRange(new SqlParameter[] { id, name, genderid, titleid, monstertypeid, picture, active });
        result = cmd.ExecuteNonQuery();
      }

      return result >= 0;
    }
  }
}
