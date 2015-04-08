using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using PowerServer.DataContracts;

namespace PowerServer.ServerAil
{
    [ServiceContract(Namespace="PowerServer",CallbackContract=typeof(IPublisherEvents))]
    public interface IPowerService
    {
        [OperationContract]
        bool checkUser(string username,string passwd);
    }

    public interface IPublisherEvents
    {
        [OperationContract(IsOneWay = true)]
        void refresh();

        [OperationContract(IsOneWay=true)]
        void pushRTInfo(ClientInfo clientinfo);
    }
}
