using System;
using WithEventHandler.PublisherSubscriber.CustomEventArgs;
using WithEventHandler.PublisherSubscriber.Publishers;
using static System.Console;

namespace WithEventHandler.PublisherSubscriber.Subscribers
{
    public class Subscriber : IDisposable
    {
        private string _ip;

        public Subscriber()
        {
            Publisher.StringAdded += OnAddingString;
        }

        private void OnAddingString(object sender, CustomArg eventArgument) => 
            _ip = eventArgument.Ip;
        
        public void ShowIp() =>
            WriteLine($"{_ip}");

        public void Dispose() =>
            Publisher.StringAdded -= OnAddingString;
        
    }
}
