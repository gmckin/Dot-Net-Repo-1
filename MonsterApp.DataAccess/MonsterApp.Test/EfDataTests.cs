using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
      

     
    }

    [Fact]
    public void Test_DeleteGender()
    {
      //var data = new EfData();
      //var expected = data.GetGender();
      //var actual = data.DeleteGender(expected);

      //Assert.True(actual);
    }

    [Fact]
    public void Test_SearchGender()
    {
      EfData data = new EfData();
      var expected = 7;

      var actual = data.SearchGender();

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_InsertMonster()
    {
      var data = new EfData();
      var expected = new Monster() { Name = "Dalek", GenderId = null, TitleId = null, TypeId = null, Picture = "x", Active = true };

      var actual = data.InsertMonster(expected);

      Assert.True(actual);
    }
  }
}
