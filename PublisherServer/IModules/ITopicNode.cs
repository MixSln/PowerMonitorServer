﻿using System;
using System.Collections.Generic;
using System.Text;
using PowerServer.ServerAil;

namespace PublisherServer.IModules
{
    interface ITopicNode
    {
        IPublisherEvents getPublisherEvents();
        ITopicInfo getTopicInfo();
    }
}
