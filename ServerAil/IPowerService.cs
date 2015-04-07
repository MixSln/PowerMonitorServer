using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace PowerServer.ServerAil
{
    [ServiceContract(Namespace="PowerServer")]
    interface IPowerService
    {
        [OperationContract]
        bool checkUser(string username,string passwd);
    }
}
