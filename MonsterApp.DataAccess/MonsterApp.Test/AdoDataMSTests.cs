using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.Test
{
  [TestClass]
  public class AdoDataMSTests
  {
    private DataAccess.Models.Gender gender;
    [TestInitialize]
    public void Initializ()
    {
      gender = new DataAccess.Models.Gender() { GenderName = "TestGender" };
    }

    [TestCleanup]

    public void Cleanup()
    {
      GC.Collect();
    }

    [TestMethod]
    public void Test_GetGenders()
    {
      AdoData data = new AdoData();
      var expected = 5;

      var actual = data.GetGenders();

      Assert.Equals(expected, actual.Count);
    }

      }
}
