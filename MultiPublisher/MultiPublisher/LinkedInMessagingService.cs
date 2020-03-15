using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisher
{
    public class LinkedInMessagingService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Enviando mensaje por LinkedIn: {message}");
        }
    }
}
