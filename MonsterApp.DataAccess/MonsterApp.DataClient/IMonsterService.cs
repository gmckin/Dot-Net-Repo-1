using MonsterApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MonsterApp.DataClient
{
  /// <summary>
  /// 
  /// </summary>
  [ServiceContract]
  public interface IMonsterService
  {
    [OperationContract]    
    List<GenderDAO> GetGender();

    [OperationContract]
    List<MonsterTypeDAO> GetMonsterType();

    [OperationContract]    
    List<TitleDAO> GetTitles();

    //[OperationContract]
    //List<MonsterDAO> GetMonsters();

    [OperationContract]
    bool InsertMonster(MonsterDAO monster);

    [OperationContract]
    bool InsertGender(GenderDAO gender);

    [OperationContract]
    bool InsertMonsterType(MonsterTypeDAO mtype);

    [OperationContract]
    bool InsertTitle(TitleDAO title);
  }
}
