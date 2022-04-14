using System;

namespace WithTemplates.PublisherSubscriber.CustomEventArgs
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
