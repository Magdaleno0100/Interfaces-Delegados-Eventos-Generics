using System;

namespace MultiPublisher
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitterMessagingService = new TwitterMessagingService();
            var facebookMessangingService = new FacebookMessagingService();
            var linkedinMessagingService = new LinkedInMessagingService();

            MessagingHelper.SayHelloAllServices(twitterMessagingService,facebookMessangingService,linkedinMessagingService);
        }
    }
}
