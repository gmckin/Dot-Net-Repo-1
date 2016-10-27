using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Test
{
  public class EfDataTests
  {

    [Fact]
    public void Test_GetGender()
    {
      var data = new EfData();
      var actual = data.GetGender();

      Assert.NotNull(actual);
    }

    [Fact]
    public void Test_InsertGender()
    {
      var data = new EfData();
      var expected = new Gender() { GenderName = "Martian", Active = true };

      var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Added);

      Assert.True(actual);
    }


    [Fact]
    public void Test_ChangeGender()
    {
      //var data = new EfData();
      //var expected = data.ChangeGender("ET", "Martian";

      //var actual = data.GetGender();

      //Assert.True(actual);
    }

    [Fact]
    public void Test_DeleteGender()
    {

    }

    [Fact]
    public void Test_SearchGender()
    {

    }
  }
}
