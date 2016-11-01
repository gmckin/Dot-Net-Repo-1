using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DA = MonsterApp.DataAccess.Models;

namespace MonsterApp.DataClient.Models
{
  public class TitleMapper
  {
    public static TitleDAO MapToTitleDAO(Title title)
    {
      var t = new TitleDAO();
      t.Id = title.TitleId;
      t.Name = title.TitleName;


      return t;
    }

    public static object MapTo(object o)
    {
      var properties = o.GetType().GetProperties();
      var ob = new object();

      foreach (var item in properties.ToList())
      {
        ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));
      }
      return ob;
    }

  }
}