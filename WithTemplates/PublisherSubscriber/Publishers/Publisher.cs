using System;

namespace WithTemplates.PublisherSubscriber.Publishers
{
    public class Publisher<TDelegateType> where TDelegateType : Delegate
    {
        public event Action<TDelegateType> StringAdded;

        public void AddString(TDelegateType customEventArgs) =>
            StringAdded?.Invoke(customEventArgs);
    }
}
