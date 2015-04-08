using System;
using System.Collections.Generic;
using System.Text;
using PowerServer.DataContracts;

namespace PublisherServer.IModules
{
    interface ITopicInfo
    {
        ClientInfo getClientInfo();
        string getClientAddr();
    }
}
