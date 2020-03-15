using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisher
{
    public interface IMessagingService
    {
        void SendMessage(string message);
    }
}
