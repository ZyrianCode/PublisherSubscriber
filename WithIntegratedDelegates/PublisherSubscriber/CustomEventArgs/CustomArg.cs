using System;

namespace WithIntegratedDelegates.PublisherSubscriber.CustomEventArgs
{
    public class CustomArg : EventArgs
    {
        public string IP { get; set; }

        public CustomArg(string ip)
        {
            IP = ip;
        }
    }
}
