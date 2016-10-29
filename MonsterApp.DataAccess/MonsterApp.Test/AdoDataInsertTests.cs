using MonsterApp.DataAccess;
using MonsterApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Test
{
  public class AdoDataInsertTests
  {
    [Fact]
    public void Test_InsertMonster()
    {
      AdoData data = new AdoData();
      var monster = new DataAccess.Models.Monster();
      monster.Name = "Dracula";
      monster.GenderId = 1;
      monster.TitleId = 1;
      monster.TypeId = 1;
      monster.PicturePath = "x";
      monster.Active = true;

      var actual = data.InsertMonster(monster);


    }

    //[Theory(gender = new Models.Gender() { Name = "blah", Active = true })]
    //public void Theory_InsertGender(DataAccess.Models.Gender gender)
    //{
    //  var data = new AdoData();
    //  var actual = data.InsertGender(gender);

    //  Assert.True(actual);
    //}

  }
}
