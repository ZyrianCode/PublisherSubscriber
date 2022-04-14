using WithIntegratedDelegates.PublisherSubscriber.CustomEventArgs;
using WithIntegratedDelegates.PublisherSubscriber.Publishers;
using WithIntegratedDelegates.PublisherSubscriber.Subscribers;

namespace WithIntegratedDelegates.Facades
{
    public class Starter
    {
        public void Start()
        {
            var customArg = new CustomArg("192.168.0.1");
            var subscriber = new Subscriber();

            Publisher.AddString(customArg);

            subscriber.ShowIp();
        }
    }
}
