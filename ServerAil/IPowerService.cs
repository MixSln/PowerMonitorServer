using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace PowerServer.ServerAil
{
    [ServiceContract(Namespace="PowerServer")]
    public interface IPowerService
    {
        [OperationContract]
        bool checkUser(string username,string passwd);
    }
}
