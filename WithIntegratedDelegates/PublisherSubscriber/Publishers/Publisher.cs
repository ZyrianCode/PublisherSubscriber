using System;
using WithIntegratedDelegates.PublisherSubscriber.CustomEventArgs;

namespace WithIntegratedDelegates.PublisherSubscriber.Publishers
{
    public static class Publisher
    {
        public static event Action<CustomArg> StringAdded;
        
        public static void AddString(CustomArg customEventArgs) => 
            StringAdded?.Invoke(customEventArgs);
    }
}
