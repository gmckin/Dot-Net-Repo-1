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
  }
}
