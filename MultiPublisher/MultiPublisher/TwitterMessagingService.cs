using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisher
{
    public class TwitterMessagingService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Enviando mensaje por Twitter: {message}");
        }
    }
}
