using System;
using WithTemplates.PublisherSubscriber.CustomEventArgs;
using WithTemplates.PublisherSubscriber.Publishers;
using WithTemplates.PublisherSubscriber.Subscribers;

namespace WithTemplates.Facade
{
    public class Starter
    {
        public void Start()
        {
            var customArg = new CustomArg("192.168.0.1");

            Publisher<Func<CustomArg>> publisher = new();
            var subscriber = new Subscriber(publisher);


            publisher.AddString(() => customArg);

            subscriber.ShowIp();
        }
    }
}
