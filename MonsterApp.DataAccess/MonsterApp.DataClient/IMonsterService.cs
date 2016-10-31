using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
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
    string DoWork();

   
  }
}
