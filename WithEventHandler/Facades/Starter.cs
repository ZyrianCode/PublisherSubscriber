using WithEventHandler.PublisherSubscriber.CustomEventArgs;
using WithEventHandler.PublisherSubscriber.Publishers;
using WithEventHandler.PublisherSubscriber.Subscribers;

namespace WithEventHandler.Facades
{
    public class Starter
    {
        public void Start()
        {
            var customArg = new CustomArg("192.168.0.1");
            var subscriber = new Subscriber();

            Publisher.AddString(this, customArg);

            subscriber.ShowIp();

        }
    }
}
