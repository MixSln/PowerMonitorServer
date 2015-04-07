using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using PowerServer.ServerBll;

namespace PowerServer.ServerAil
{
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Multiple,InstanceContextMode=InstanceContextMode.Single)]
    class PowerService:IPowerService
    {
        #region Service Start
        protected ServiceHost host = null;
        public void startService()
        {

        }
        #endregion

        #region Implement Interface
        /// <summary>
        /// user login check
        /// </summary>
        /// <param name="username"></param>
        /// <param name="passwd"></param>
        /// <returns></returns>
        public bool checkUser(string username, string passwd)
        {
            return false;
        }
        #endregion
    }
}
