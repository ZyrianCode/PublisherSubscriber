using System;
using WithTemplates.PublisherSubscriber.CustomEventArgs;
using WithTemplates.PublisherSubscriber.Publishers;
using static System.Console;

namespace WithTemplates.PublisherSubscriber.Subscribers
{
    public class Subscriber : IDisposable
    {
        private string _ip;

        private readonly Publisher<Func<CustomArg>> _publisher;

        public Subscriber(Publisher<Func<CustomArg>> publisher)
        {
            _publisher = publisher;
            _publisher.StringAdded += OnAddingString;
        }

        private void OnAddingString(Func<CustomArg> eventArgument) =>
            _ip = eventArgument().Ip;

        public void ShowIp() =>
            WriteLine($"{_ip}");

        public void Dispose()
        {
            _publisher.StringAdded -= OnAddingString;
            GC.SuppressFinalize(this);
        }
    }
}
