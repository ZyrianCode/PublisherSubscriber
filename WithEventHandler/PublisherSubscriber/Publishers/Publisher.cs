using System;
using WithEventHandler.PublisherSubscriber.CustomEventArgs;

namespace WithEventHandler.PublisherSubscriber.Publishers
{
    public static class Publisher
    {
        public static event EventHandler<CustomArg> StringAdded;
        
        public static void AddString(object? sender, CustomArg customEventArgs) => 
            StringAdded?.Invoke(sender, customEventArgs);
    }
}
