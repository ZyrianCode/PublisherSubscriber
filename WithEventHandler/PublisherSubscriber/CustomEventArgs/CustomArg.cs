using System;

namespace WithEventHandler.PublisherSubscriber.CustomEventArgs
{
    public class CustomArg : EventArgs
    {
        public string Ip { get; set; }
        
        public CustomArg(string ip)
        {
            Ip = ip;
        }
    }
}
