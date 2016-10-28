using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Test
{
  public class AdoDataTests
  {
    [Fact]

    public void Test_GetGenders()
    {
      AdoData data = new AdoData();
      var expected = 5;

      var actual = data.GetGenders();

      Assert.Equal(expected, actual.Count);
    }

    [Fact]
    public void Test_GetMonsterTypes()
    {
      AdoData data = new AdoData();
      var expected = 3;

      var actual = data.GetMonsterTypes();

      Assert.Equal(expected, actual.Count);
    }

    [Fact]
    public void Test_GetTitles()
    {
      AdoData data = new AdoData();
      var expected = 3;

      var actual = data.GetTitles();

      Assert.Equal(expected, actual.Count);
    }

    [Fact]
    public void Test_GetMonsters()
    {
      AdoData data = new AdoData();
      var expected = 0;

      var actual = data.GetMonsters();

      Assert.Equal(expected, actual.Count);
    }

    [Fact]
    //Negative tests
    public void Test_GetRecentGenders()
    {
      AdoData data = new AdoData();
      var expected = 5;

      var actual = data.GetGenders();

      Assert.Equal(expected, actual.Count);
    }


  }
}
