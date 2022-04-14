using System;
using WithIntegratedDelegates.PublisherSubscriber.CustomEventArgs;
using WithIntegratedDelegates.PublisherSubscriber.Publishers;
using static System.Console;

namespace WithIntegratedDelegates.PublisherSubscriber.Subscribers
{
    public class Subscriber : IDisposable
    {
        private string _ip;

        public Subscriber()
        {
            Publisher.StringAdded += OnAddingString;
        }

        private void OnAddingString(CustomArg eventArgument) => 
            _ip = eventArgument.IP;

        public void ShowIp() =>
            WriteLine($"{_ip}");

        public void Dispose() =>
            Publisher.StringAdded -= OnAddingString;
        
    }
}
